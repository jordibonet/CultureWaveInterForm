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
        public static List<dynamic> GetUsersWithRolId1()
        {
            try
            {
                using (var dbContext = new cultureWaveEntities())
                {
                    var users = dbContext.user
                        .Where(u => u.rol == 1)          
                        .Select(u => new
                        {
                            u.email,
                            u.password
                        })
                        .ToList<dynamic>();

                    return users;
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores (log, relanzar, etc.)
                Console.WriteLine($"Error al obtener usuarios: {ex.Message}");
                return new List<dynamic>(); // Retorna lista vacía en caso de error
            }
        }

    }
}