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
                using (var db = new cultureWaveEntities1())
                {
                    // Obtener reservas con relaciones necesarias
                    var reserves = db.reserve
                        .AsNoTracking()
                        .Include(r => r.eventTable)
                        .Include(r => r.eventTable.space)
                        .Include(r => r.seat)
                        .Include(r => r.user) // Incluir usuarios correctamente
                        .OrderByDescending(r => r.reserveDate)
                        .Take(maxResults)
                        .ToList();

                    var result = new List<dynamic>();

                    foreach (var r in reserves)
                    {
                        // Obtener el primer asiento (si hay varios)
                        var seat = r.seat?.FirstOrDefault();

                        // Obtener nombres de usuarios
                        var userNames = r.user?
                            .Select(u => u.name)
                            .Where(name => !string.IsNullOrWhiteSpace(name))
                            .ToList();

                        string usersText = (userNames != null && userNames.Any())
                            ? string.Join(", ", userNames)
                            : "Sin usuarios asignados";

                        result.Add(new
                        {
                            r.idReserve,
                            r.idEvent,
                            r.reserveDate,
                            EventName = r.eventTable?.name ?? "Evento no disponible",
                            SpaceName = r.eventTable?.space?.name ?? "Espacio no disponible",
                            SeatInfo = seat != null ? $"Fila {seat.row}, Asiento {seat.numSeat}" : "Sin asiento asignado",
                            Users = usersText
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
//si