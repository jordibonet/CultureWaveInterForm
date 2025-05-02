using System;
using System.Collections.Generic;
using System.Linq;

namespace CultureWaveInterForm.Models
{
    class SpacesOrm
    {
        public static List<dynamic> SelectAvailableSpaces()
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    return db.space
                        .Where(s => s.available == true)  // Filtra solo espacios disponibles
                        .Select(s => new
                        {
                            s.idSpace,
                            s.name,
                            s.capacity,
                            s.fixedSeats,
                            s.available
                        })
                        .ToList<dynamic>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener espacios disponibles: {ex.Message}");
                return new List<dynamic>();
            }
        }
    }
}