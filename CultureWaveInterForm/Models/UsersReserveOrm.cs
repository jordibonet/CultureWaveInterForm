using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureWaveInterForm.Models
{
    class UsersReserveOrm
    {
        /* SELECT */

        /// <summary>
        /// Select para obtener los nombres, correos de usuarios con el rol 3
        /// </summary>
        /// <param name="roleId">Rol del usuario que queremos coger</param>
        /// <returns>Devuelve una lista de cadenas que combinan el nombre y el correo de cada usuario</returns>
        public static List<string> GetUserNamesOrEmailsByRoleId(int roleId = 3)
        {
            try
            {
                using (var db = new cultureWaveEntities2())
                {
                    // Consulta para obtener nombres y correos de usuarios con rolId = 3
                    var users = db.user
                                .Where(u => u.rol == roleId)  // Filtra por rolId
                                .Select(u => u.name + " - " + u.email)  // Combina nombre y email
                                .ToList();

                    return users;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener usuarios: " + ex.Message);
                return new List<string>(); // Lista vacia
            }
        }

        /// <summary>
        /// Obtenemos el ID del usuario mediante su email.
        /// </summary>
        /// <param name="email">Pasamos el email del usuario que queremos buscar</param>
        /// <returns>Devuelve la ID del usuario</returns>
        public static int GetUserIdByEmail(string email)
        {
            try
            {
                using (var db = new cultureWaveEntities2())
                {
                    var user = db.user.FirstOrDefault(u => u.email == email); // Buscar por correo electrónico
                    return user?.idUser ?? 0; // Si lo encuentra, retorna el ID, si no, 0
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el ID del usuario: {ex.Message}");
                return 0; // Devuelve 0 en caso de error
            }
        }

        /// <summary>
        /// Obtenemos de la BBDD los usuarios con rol 3
        /// </summary>
        /// <param name="roleId">Para obtener los usuarios mediante este rol</param>
        /// <returns>Devuelve una lista de los usuarios</returns>
        public static dynamic GetUsersForComboBox(int roleId = 3)
        {
            try
            {
                using (var db = new cultureWaveEntities2())
                {
                    // Consulta para obtener Id, Nombre y Email
                    var users = db.user
                                .Where(u => u.rol == roleId)
                                .Select(u => new
                                {
                                    Id = u.idUser,           // ValueMember (ID)
                                    DisplayText = u.name + " - " + u.email  // DisplayMember (Nombre - Email)
                                })
                                .ToList();

                    return users;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener usuarios: " + ex.Message);
                return new List<dynamic>(); // Lista vacía en caso de error
            }
        }
    }
}