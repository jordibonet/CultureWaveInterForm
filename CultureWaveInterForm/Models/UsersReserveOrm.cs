using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureWaveInterForm.Models
{
    class UsersReserveOrm
    {
        public static List<string> GetUserNamesOrEmailsByRoleId(int roleId = 3)
        {
            try
            {
                using (var db = new cultureWaveEntities1())
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
                return new List<string>();
            }
        }


        public static int GetUserIdByEmail(string email)
        {
            try
            {
                using (var db = new cultureWaveEntities1())
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

        public static dynamic GetUsersForComboBox(int roleId = 3)
        {
            try
            {
                using (var db = new cultureWaveEntities1())
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