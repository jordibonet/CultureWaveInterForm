using System;
using System.Collections.Generic;
using System.Linq;

namespace CultureWaveInterForm.Models
{
    class EventsOrm
    {
        public static List<dynamic> GetProgrammedEvents()
        {
            try
            {
                using (var db = new cultureWaveEntities())
                {
                    return db.eventTable
                        .Where(e => e.status == "Programado") // Filtra por estado
                        .Select(e => new
                        {
                            e.idEvent,
                            e.name,
                            e.description,
                            e.startDate,
                            e.endDate,
                            SpaceName = e.space.name // Nombre del espacio relacionado
                        })
                        .ToList<dynamic>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener eventos: {ex.Message}");
                return new List<dynamic>();
            }
        }
    }
}