using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace CultureWaveInterForm.Models
{
    class ReserveOrm
    {
        /** SELECT **/

        /// <summary>
        /// Select a la BBDD para saber las reservas de un usuario filtrandolo por us ID.
        /// </summary>
        /// <param name="userId">Pasamos el ID del usuario para saber que usuario queremos buscar</param>
        /// <param name="maxResults">Que no se pase de 50 resultados</param>
        /// <returns>Devuelve una lista dinamica del resultado</returns>
        public static List<dynamic> GetUserReservesWithDetails(int userId, int maxResults = 50)
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    // Obtener reservas del usuario con relaciones necesarias
                    var reserves = db.reserve
                        .AsNoTracking()
                        .Where(r => r.user.Any(u => u.idUser == userId)) // Filtra por usuario
                        .Include(r => r.eventTable)
                        .Include(r => r.eventTable.space)
                        .Include(r => r.seat)
                        .OrderByDescending(r => r.reserveDate)
                        .Take(maxResults)
                        .ToList();

                    var result = new List<dynamic>();

                    foreach (var r in reserves)
                    {
                        // Obtener información del asiento (si existe)
                        var seat = r.seat?.FirstOrDefault();

                        // Agregar el idReserve al objeto anónimo para cada reserva
                        result.Add(new
                        {
                            ReservationId = r.idReserve,  // Incluye el ID de la reserva
                            EventName = r.eventTable?.name ?? "Evento no disponible",
                            StartDate = r.eventTable?.startDate ?? DateTime.MinValue,
                            EndDate = r.eventTable?.endDate ?? DateTime.MinValue,
                            Status = r.eventTable?.status ?? "Estado no disponible",
                            SpaceName = r.eventTable?.space?.name ?? "Espacio no disponible",
                            ReserveDate = r.reserveDate,
                            SeatInfo = seat != null ? $"{seat.row}{seat.numSeat}" : "Sin asiento"
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

        /// <summary>
        /// Seleccionamos los nombres de los eventos y sus IDs.
        /// </summary>
        /// <returns>Devuelve una lista de los eventos</returns>
        public static List<Event> GetEventsForComboBox()
        {
            using (var db = new cultureWaveEntities1())
            {
                // Obtener todos los eventos
                return db.eventTable
                         .Select(e => new Event { Id = e.idEvent, Name = e.name })
                         .ToList();
            }
        }

        /// <summary>
        /// Select para saber que asientos estan disponibles
        /// </summary>
        /// <param name="eventId">ID del evento</param>
        /// <param name="row">Fila en la que se encuetra el asiento</param>
        /// <param name="numSeat">Número de la silla</param>
        /// <returns>Devuelve un booleano para saber si ha salido correctamente</returns>
        public static bool IsSeatAvailable(int eventId, char row, int numSeat)
        {
            using (var db = new cultureWaveEntities1())
            {
                var evento = db.eventTable
                    .Include(e => e.space)
                    .FirstOrDefault(e => e.idEvent == eventId);

                if (evento?.space == null) return false;

                string rowString = row.ToString();

                return db.seat.Any(s =>
                    s.row == rowString &&
                    s.numSeat == numSeat &&
                    s.idSpace == evento.space.idSpace &&
                    !db.reserve.Any(r => r.idEvent == eventId && r.seat.Any(se => se.idSeat == s.idSeat)));
            }
        }

        /// <summary>
        /// Verifica que el evento tenga sillas fillas
        /// </summary>
        /// <param name="eventId">ID del evento para saber si tiene sillas o no</param>
        /// <returns>Devuelve un false si no tiene sillas, true si tiene</returns>
        public static bool EventHasFixedSeats(int eventId)
        {
            using (var db = new cultureWaveEntities1())
            {
                var evento = db.eventTable.Include(e => e.space).FirstOrDefault(e => e.idEvent == eventId);
                return evento != null && evento.space.fixedSeats == true;
            }
        }

        /** INSERT **/

        /// <summary>
        /// Creamos una reserva con asiento asignado para un usuario en especifico para un evento.
        /// </summary>
        /// <param name="userId">Pasamos el ID del usuario para saber a que usuario hacerle la reserva</param>
        /// <param name="eventId">El evento al que quiere ir</param>
        /// <param name="row">La fila en la que se encuentra su silla</param>
        /// <param name="numSeat">Número de la silla</param>
        /// <returns>Devuelve el ID de la reserva creada</returns>
        public static int CreateReservationWithSeat(int userId, int eventId, char row, int numSeat)
        {
            using (var db = new cultureWaveEntities1())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // 1. Verificar usuario
                        var usuario = db.user.Find(userId);
                        if (usuario == null)
                            throw new Exception("Usuario no válido");

                        // 2. Verificar evento y espacio
                        var evento = db.eventTable
                            .Include(e => e.space)
                            .FirstOrDefault(e => e.idEvent == eventId);

                        if (evento == null)
                            throw new Exception("Evento no encontrado");

                        if (evento.space == null || evento.space.fixedSeats == false)
                            throw new Exception("Este evento no tiene asientos fijos");

                        // 3. Verificar asiento disponible
                        string rowString = row.ToString();

                        var asiento = db.seat.FirstOrDefault(s =>
                            s.row == rowString &&
                            s.numSeat == numSeat &&
                            s.idSpace == evento.space.idSpace &&
                            !db.reserve.Any(r => r.idEvent == eventId && r.seat.Any(se => se.idSeat == s.idSeat)));

                        if (asiento == null)
                            throw new Exception("Asiento no disponible o no encontrado");

                        // 4. Crear la reserva y asociar el asiento y usuario
                        var reserva = new reserve
                        {
                            eventTable = evento,
                            reserveDate = DateTime.Now
                        };

                        reserva.user.Add(usuario);
                        reserva.seat.Add(asiento);

                        db.reserve.Add(reserva);
                        db.SaveChanges();

                        transaction.Commit();
                        return reserva.idReserve;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error: {ex.Message}");
                        return -1;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public static int CreateReservationWithoutSeat(int userId, int eventId)
        {
            using (var db = new cultureWaveEntities1())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // Validar el usuario
                        var usuario = db.user.Find(userId);
                        if (usuario == null)
                            throw new Exception("Usuario no válido");

                        // Obtener el evento y el espacio asociado
                        var evento = db.eventTable
                            .Include(e => e.space)
                            .FirstOrDefault(e => e.idEvent == eventId);

                        if (evento == null)
                            throw new Exception("Evento no encontrado");

                        // Validar que el espacio NO tenga asientos fijos
                        if (evento.space.fixedSeats == true)
                            throw new Exception("Este evento requiere selección de asiento");

                        // Crear la reserva sin asiento
                        var reserva = new reserve
                        {
                            idEvent = eventId,
                            reserveDate = DateTime.Now,
                            user = new List<user> { usuario }
                        };

                        db.reserve.Add(reserva);
                        db.SaveChanges();
                        transaction.Commit();

                        return reserva.idReserve;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error al crear la reserva sin asiento: {ex.Message}");
                        return -1;
                    }
                }
            }
        }



        /* DELETE */

        /// <summary>
        /// Borra una reserva de la BBDD
        /// </summary>
        /// <param name="reservationId">Le pasamos el ID de la reserva que queramos borrar</param>
        /// <returns>Devuelve un booleano, true si ha salido todo bien y false si algo ha fallado</returns>
        public static bool DeleteReservation(int reservationId)
        {
            using (var db = new cultureWaveEntities1())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // Obtener la reserva con TODAS sus relaciones incluidas
                        var reserva = db.reserve
                            .Include(r => r.seat)
                            .Include(r => r.ticket)
                            .Include(r => r.eventTable)
                            .Include(r => r.user)
                            .FirstOrDefault(r => r.idReserve == reservationId);

                        if (reserva == null)
                        {
                            MessageBox.Show("Reserva no encontrada en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        // 1. Eliminar tickets relacionados
                        if (reserva.ticket != null && reserva.ticket.Any())
                        {
                            db.ticket.RemoveRange(reserva.ticket);
                            db.SaveChanges();
                        }

                        // 2. Manejar asientos relacionados
                        if (reserva.seat != null && reserva.seat.Any())
                        {
                            // Opción A: Eliminar los asientos
                            db.seat.RemoveRange(reserva.seat);
                            // Opción B: Quitar la relación (actualizar idReserve a null)
                            // foreach (var seat in reserva.seat) { seat.idReserve = null; }
                            db.SaveChanges();
                        }

                        // 3. Manejar relación con eventTable (si es necesario)
                        if (reserva.eventTable != null)
                        {
                            // Dependiendo de tus reglas de negocio:
                            // reserva.eventTable = null; // Rompe la relación sin eliminar el evento
                            db.SaveChanges();
                        }

                        // 4. Manejar relación con user (si es necesario)
                        if (reserva.user != null)
                        {
                            // Dependiendo de tus reglas de negocio:
                            // reserva.user = null; // Rompe la relación sin eliminar el usuario
                            db.SaveChanges();
                        }

                        // 5. Finalmente eliminar la reserva
                        db.reserve.Remove(reserva);
                        db.SaveChanges();

                        transaction.Commit();
                        return true;
                    }
                    catch (DbUpdateException dbEx)
                    {
                        transaction.Rollback();
                        string errorMessage = "Error de base de datos:\n";
                        var innerException = dbEx.InnerException?.InnerException ?? dbEx.InnerException ?? dbEx;
                        errorMessage += innerException.Message;

                        MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error inesperado: {ex.Message}\nStack Trace: {ex.StackTrace}",
                                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
    }
}