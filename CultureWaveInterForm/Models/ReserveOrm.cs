using CultureWaveInterForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CultureWaveInterForm.Forms
{
    public static class ReserveOrm
    {
        public static List<object> GetEventsForComboBox()
        {
            using (var db = new cultureWaveEntities2())
            {
                return db.eventTable
                         .AsNoTracking()
                         .Select(e => new
                         {
                             Id = e.idEvent,
                             Name = e.name
                         })
                         .ToList<object>();
            }
        }

        public static bool EventHasFixedSeats(int eventId)
        {
            using (var db = new cultureWaveEntities2())
            {
                return db.eventTable
                         .Include("space")
                         .AsNoTracking()
                         .Any(e => e.idEvent == eventId && e.space.fixeSeats == true);
            }
        }

        public static bool IsSeatAvailable(int eventId, char row, int numSeat)
        {
            using (var db = new cultureWaveEntities2())
            {
                // Convertimos el char a string fuera del LINQ
                string rowString = row.ToString();

                var idSpace = db.eventTable
                                .Where(e => e.idEvent == eventId)
                                .Select(e => e.idSpace)
                                .FirstOrDefault();

                // Validar si no hay espacio asociado
                if (idSpace == 0) // idSpace es int, así que comparas con 0, no null
                    return false;

                return !db.seat.Any(s =>
                    s.idSpace == idSpace &&
                    s.row == rowString &&
                    s.numSeat == numSeat &&
                    s.reserve.idEvent == eventId);
            }
        }



        public static int CreateReservationWithSeat(int userId, int eventId, char row, int numSeat)
        {
            using (var db = new cultureWaveEntities2())
            {
                var idSpace = db.eventTable
                                .Where(e => e.idEvent == eventId)
                                .Select(e => e.idSpace)
                                .FirstOrDefault();

                if (idSpace == null)
                    throw new Exception("El evento no tiene espacio asignado.");

                var reservation = new reserve
                {
                    idEvent = eventId,
                    reserveDate = DateTime.Now
                };

                var user = db.user.Find(userId);
                if (user != null)
                {
                    reservation.user.Add(user);
                }

                db.reserve.Add(reservation);
                db.SaveChanges();

                var newSeat = new seat
                {
                    idSpace = idSpace.Value,
                    idReserve = reservation.idReserve,
                    row = row.ToString(),
                    numSeat = numSeat
                };

                db.seat.Add(newSeat);
                db.SaveChanges();

                return reservation.idReserve;
            }
        }

        public static int CreateReservationWithoutSeat(int userId, int eventId)
        {
            using (var db = new cultureWaveEntities2())
            {
                var reservation = new reserve
                {
                    idEvent = eventId,
                    reserveDate = DateTime.Now
                };

                var user = db.user.Find(userId);
                if (user != null)
                {
                    reservation.user.Add(user);
                }

                db.reserve.Add(reservation);
                db.SaveChanges();

                return reservation.idReserve;
            }
        }

        public static List<object> GetUserReservesWithDetails(int userId)
        {
            using (var db = new cultureWaveEntities2())
            {
                var user = db.user.Find(userId);
                if (user == null)
                    return new List<object>();

                var reservas = user.reserve
                    .Select(r => new
                    {
                        ReservationId = r.idReserve,
                        EventName = r.eventTable.name,
                        StartDate = r.eventTable.startDate,
                        EndDate = r.eventTable.endDate,
                        Status = r.eventTable.status,
                        SpaceName = r.eventTable.space.name,
                        ReserveDate = r.reserveDate,
                        SeatInfo = r.seat.Any() ?
                                   $"Fila: {r.seat.FirstOrDefault().row}, Asiento: {r.seat.FirstOrDefault().numSeat}" :
                                   "Sin asiento asignado"
                    })
                    .ToList<object>();

                return reservas;
            }
        }

        public static bool DeleteReservation(int reservationId)
        {
            using (var db = new cultureWaveEntities2())
            {
                var reservation = db.reserve
                    .Include("seat")
                    .Include("user")
                    .FirstOrDefault(r => r.idReserve == reservationId);

                if (reservation == null)
                    return false;

                // Eliminar asientos relacionados
                db.seat.RemoveRange(reservation.seat);

                // Desvincular usuarios
                reservation.user.Clear();

                db.reserve.Remove(reservation);
                db.SaveChanges();

                return true;
            }
        }
    }
}
