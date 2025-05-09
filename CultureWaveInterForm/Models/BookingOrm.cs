using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace CultureWaveInterForm.Models
{
    class BookingOrm
    {
        /* SELECT */

        /// <summary>
        /// Select para tener la información de las reservas de la BBDD 
        /// </summary>
        /// <param name="maxResults"></param>
        /// <returns>Devuelva una lista dinamica con los datos formateados</returns>
        public static List<dynamic> GetReservesWithSeatInfo()
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