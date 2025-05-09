using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace CultureWaveInterForm.Models
{
    class SpacesOrm
    {
        /* SELECT */

        /// <summary>
        /// Select de todos los espacios que esten disponibles
        /// </summary>
        /// <returns>Devuelve una lista dinamica</returns>
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

        /// <summary>
        /// Select de todos los espacios (sin filtros)
        /// </summary>
        /// <returns>Devuelve una lista dinamica</returns>
        public static List<dynamic> SelectSpaces()
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    return db.space
                        .Select(s => new // Esta parte es correcta
                        {
                            s.idSpace,
                            s.name,
                            s.capacity,
                            s.fixedSeats,
                            s.available
                        })
                        .ToList<dynamic>(); // Convertir a dynamic al final
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener espacios: {ex.Message}");
                return new List<dynamic>();
            }
        }

        /* INSERT */

        /// <summary>
        /// Creamos un nuevo espacio con los parametros que pase el usuario.
        /// </summary>
        /// <param name="name">Nombre que haya escrito el usuario</param>
        /// <param name="capacity">Cpacidad total del espacio</param>
        /// <param name="fixedSeats">Si tiene asientos fijos</param>
        /// <param name="available">Y si esta disponible el sitio</param>
        /// <returns>Devuelve un booleano, true es que todo esta correcto y false es que ha ocurrido un error</returns>
        public static bool CreateSpace(string name, int capacity, bool fixedSeats, bool available)
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    // Crear nuevo objeto space
                    var nuevoEspacio = new space
                    {
                        name = name,
                        capacity = capacity,
                        fixedSeats = fixedSeats,
                        available = available
                    };

                    // Agregar a la base de datos
                    db.space.Add(nuevoEspacio);
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el espacio: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /* UPDATE */

        /// <summary>
        /// Actualizamos un espacio en concreto.
        /// </summary>
        /// <param name="idSpace">ID del espacio que queremos modificar</param>
        /// <param name="name">Nombre que le queremos poner</param>
        /// <param name="capacity">Capacidad maxima del espacio</param>
        /// <param name="fixedSeats">Si tiene asientos el espacio</param>
        /// <param name="available">Si esta disponible el lugar</param>
        /// <returns>Devuelve un booleano, true es que todo esta correcto y false es que ha ocurrido un error</returns>
        public static bool UpdateSpace(int idSpace, string name, int capacity, bool fixedSeats, bool available)
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    // Buscar el espacio existente
                    var espacio = db.space.Find(idSpace);
                    if (espacio == null)
                    {
                        MessageBox.Show("Espacio no encontrado", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Actualizar propiedades
                    espacio.name = name;
                    espacio.capacity = capacity;
                    espacio.fixedSeats = fixedSeats;
                    espacio.available = available;

                    db.SaveChanges();
                    return true;
                }
            }
            catch (DbUpdateException dbEx)
            {
                string errorMessage = "Error al actualizar en la base de datos:\n";
                var innerException = dbEx.InnerException?.InnerException ?? dbEx.InnerException ?? dbEx;
                errorMessage += innerException.Message;

                MessageBox.Show(errorMessage, "Error de base de datos",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}