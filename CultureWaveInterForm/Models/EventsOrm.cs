using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CultureWaveInterForm.Models
{
    class EventsOrm
    {

        /* SELECT */

        /// <summary>
        /// Select a la BBDD de todos los eventos que esten en estado "Programat"
        /// </summary>
        /// <returns>Los devuelve en una lista dinamica</returns>
        public static List<dynamic> GetProgrammedEvents()
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    return db.eventTable
                        .Where(e => e.status == "Programat") // Filtra por estado
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

        /* INSERT */

        /// <summary>
        /// Añadir un nuevo evento a la BBDD
        /// </summary>
        /// <param name="newEvent">Pasamos por parametros le nombre del evento que ha escrito el usuario</param>
        /// <returns>devuelve un boolean; true = ha salido perfectamente, false = ha fallado algo</returns>
        public static bool Insert(eventTable newEvent)
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    db.eventTable.Add(newEvent);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Propiedad: {validationError.PropertyName} Error: {validationError.ErrorMessage}",
                                        "Error de validación",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el evento: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
        }
    }
}