using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace CultureWaveInterForm.Models
{
    class BookingOrm
    {
        public static List<dynamic> GetReservesWithSeatInfo(int maxResults = 50)
        {
            try
            {
                using (var db = new cultureWaveEntities())
                {
                    // Primero obtener las reservas
                    var reserves = db.reserve
                        .AsNoTracking()
                        .Include(r => r.eventTable)
                        .Include(r => r.eventTable.space)
                        .OrderByDescending(r => r.reserveDate)
                        .Take(maxResults)
                        .ToList();

                    // Luego cargar los asientos para cada reserva
                    var result = new List<dynamic>();
                    foreach (var r in reserves)
                    {
                        var seat = db.seat.FirstOrDefault(s => s.idReserve == r.idReserve);
                        result.Add(new
                        {
                            r.idReserve,
                            r.idEvent,
                            r.reserveDate,
                            EventName = r.eventTable?.name ?? "Evento no disponible",
                            SpaceName = r.eventTable?.space?.name ?? "Espacio no disponible",
                            SeatInfo = seat != null ? $"Fila {seat.row}, Asiento {seat.numSeat}" : "Sin asiento asignado"
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


    }
}