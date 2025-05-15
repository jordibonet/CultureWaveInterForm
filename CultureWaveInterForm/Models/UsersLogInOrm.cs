using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureWaveInterForm.Models
{
    class UsersLogInOrm
    {
        /* SELECT */

        /// <summary>
        /// Obtenemos los usuarios que tengan de rol 1 y 2
        /// </summary>
        /// <returns>Devuelve una lista de los usuarios del objeto user</returns>
        public static List<user> GetUsersWithRoles1And2() 
        {
            try
            {
                using (var dbContext = new cultureWaveEntities2())
                {
                    return dbContext.user
                        .Where(u => u.rol == 1 || u.rol == 2)  // Filtra rol 1 y 2
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener usuarios: {ex.Message}");
                return new List<user>();
            }
        }
    }
}