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
        public static List<user> GetUsersWithRoles1And2() 
        {
            try
            {
                using (var dbContext = new cultureWaveEntities())
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