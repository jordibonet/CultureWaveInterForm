using System;
using System.Linq;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CultureWaveInterForm.Models
{
    class TicketOrm
    {
        public static List<dynamic> GetActiveTickets()
        {
            try
            {
                using (var context = new cultureWaveEntities1())
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

        public static bool CloseTicket(int ticketId)
        {
            try
            {
                using (var context = new cultureWaveEntities1())
                {
                    var ticket = context.ticket.Find(ticketId);

                    if (ticket != null)
                    {
                        ticket.status = "Tancat";
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