using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace CultureWaveInterForm.Models
{
    class ReserveOrm
    {
        public static List<dynamic> GetUserReservesWithDetails(int userId, int maxResults = 50)
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    // Obtener reservas del usuario con relaciones necesarias
                    var reserves = db.reserve
                        .AsNoTracking()
                        .Where(r => r.user.Any(u => u.idUser == userId)) // Filtra por usuario
                        .Include(r => r.eventTable)
                        .Include(r => r.eventTable.space)
                        .Include(r => r.seat)
                        .OrderByDescending(r => r.reserveDate)
                        .Take(maxResults)
                        .ToList();

                    var result = new List<dynamic>();

                    foreach (var r in reserves)
                    {
                        // Obtener información del asiento (si existe)
                        var seat = r.seat?.FirstOrDefault();

                        result.Add(new
                        {
                            EventName = r.eventTable?.name ?? "Evento no disponible",
                            StartDate = r.eventTable?.startDate ?? DateTime.MinValue,
                            EndDate = r.eventTable?.endDate ?? DateTime.MinValue,
                            Status = r.eventTable?.status ?? "Estado no disponible",
                            SpaceName = r.eventTable?.space?.name ?? "Espacio no disponible",
                            ReserveDate = r.reserveDate,
                            SeatInfo = seat != null ? $"{seat.row}{seat.numSeat}" : "Sin asiento"
                        });
                    }

                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener reservas: {ex.Message}");
                return new List<dynamic>();
            }
        }

        public static List<Event> GetEventsForComboBox()
        {
            using (var db = new cultureWaveEntities1())
            {
                // Obtener todos los eventos
                return db.eventTable
                         .Select(e => new Event { Id = e.idEvent, Name = e.name })
                         .ToList();
            }
        }



        public static int CreateReservationWithSeat(int userId, int eventId, char row, int numSeat)
        {
            using (var db = new cultureWaveEntities1())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var usuario = db.user.Find(userId);
                        if (usuario == null)
                            throw new Exception("Usuario no válido");

                        var evento = db.eventTable
                            .Include(e => e.space)
                            .FirstOrDefault(e => e.idEvent == eventId);

                        if (evento == null)
                            throw new Exception("Evento no encontrado");

                        if (evento.space.fixedSeats == false)
                            throw new Exception("Este evento no requiere asiento");

                        // Buscar asiento
                        var asiento = db.seat.FirstOrDefault(s => s.row == row.ToString()
                        && s.numSeat == numSeat
                        && s.idSpace == evento.space.idSpace);

                        if (asiento == null)
                            throw new Exception("Asiento no encontrado");

                        var reserva = new reserve
                        {
                            idEvent = eventId,
                            reserveDate = DateTime.Now,
                            user = new List<user> { usuario },
                            seat = new List<seat> { asiento }
                        };

                        db.reserve.Add(reserva);
                        db.SaveChanges();
                        transaction.Commit();

                        return reserva.idReserve;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error: {ex.Message}");
                        return -1;
                    }
                }
            }
        }


        public static bool EventHasFixedSeats(int eventId)
        {
            using (var db = new cultureWaveEntities1())
            {
                var evento = db.eventTable.Include(e => e.space).FirstOrDefault(e => e.idEvent == eventId);
                return evento != null && evento.space.fixedSeats == true;
            }
        }

        public static int CreateReservationWithoutSeat(int userId, int eventId)
        {
            using (var db = new cultureWaveEntities1())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // Validar el usuario
                        var usuario = db.user.Find(userId);
                        if (usuario == null)
                            throw new Exception("Usuario no válido");

                        // Obtener el evento y el espacio asociado
                        var evento = db.eventTable
                            .Include(e => e.space)
                            .FirstOrDefault(e => e.idEvent == eventId);

                        if (evento == null)
                            throw new Exception("Evento no encontrado");

                        // Validar que el espacio NO tenga asientos fijos
                        if (evento.space.fixedSeats == true)
                            throw new Exception("Este evento requiere selección de asiento");

                        // Crear la reserva sin asiento
                        var reserva = new reserve
                        {
                            idEvent = eventId,
                            reserveDate = DateTime.Now,
                            user = new List<user> { usuario }
                        };

                        db.reserve.Add(reserva);
                        db.SaveChanges();
                        transaction.Commit();

                        return reserva.idReserve;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error al crear la reserva sin asiento: {ex.Message}");
                        return -1;
                    }
                }
            }
        }














    }
}