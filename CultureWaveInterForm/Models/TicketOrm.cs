using System;
using System.Linq;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CultureWaveInterForm.Models
{
    class TicketOrm
    {
        /* SELECT */

        /// <summary>
        /// Seleccionamos los campos de la BBDD y los cargamos en el grid.
        /// </summary>
        /// <returns>Devuelve una lista dinamica de las cosas seleccionadas</returns>
        public static List<dynamic> GetActiveTickets()
        {
            try
            {
                using (var context = new cultureWaveEntities2())
                {
                    // SOLUCIÓN CORREGIDA - Relación muchos a muchos
                    var activeTickets = (from t in context.ticket
                                         join r in context.reserve on t.idReserve equals r.idReserve
                                         from u in r.user // Acceso a usuarios a través de la colección
                                         where t.status == "Actiu"
                                         select new
                                         {
                                             ID = t.idTicket,
                                             Tipo = t.type,
                                             Estado = t.status,
                                             Descripcion = t.description,
                                             FechaCreacion = t.creationDate,
                                             FechaReserva = r.reserveDate,
                                             Usuario = u.name
                                         })
                                      .OrderByDescending(t => t.FechaCreacion)
                                      .ToList<dynamic>();

                    return activeTickets;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener tickets activos: {ex.Message}\n\n" +
                              $"Detalles técnicos: {ex.InnerException?.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return new List<dynamic>();
            }
        }

        /* UPDATE */

        /// <summary>
        /// Pasamos el estado a Tancat del ticket
        /// </summary>
        /// <param name="ticketId">Pasamos el ID del ticket que queremos cerrar</param>
        /// <returns>Devuelve un booleano para saber si se ha realizado bien o mal</returns>
        public static bool CloseTicket(int ticketId)
        {
            try
            {
                using (var context = new cultureWaveEntities2())
                {
                    var ticket = context.ticket.Find(ticketId);

                    if (ticket != null)
                    {
                        ticket.status = "Cerrado";
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}