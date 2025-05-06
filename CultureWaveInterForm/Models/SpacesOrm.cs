using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

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