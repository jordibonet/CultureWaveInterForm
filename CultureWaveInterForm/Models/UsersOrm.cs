using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace CultureWaveInterForm.Models
{
    public static class UsersOrm
    {
        // Método para obtener todos los usuarios, incluyendo sus relaciones
        public static List<dynamic> SelectUsersWithSpecificFields()
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    return db.user
                        .Select(u => new
                        {
                            u.idUser,
                            u.name,
                            u.email,
                            RolName = u.rol1.name, // Nombre del rol o valor por defecto
                            ReserveCount = u.reserve.Count // Conteo de reservas
                        })
                        .ToList<dynamic>(); // Convertimos a dynamic para facilitar el binding
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<dynamic>();
            }
        }

        public static List<rol> SelectAllRoles()
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    return db.rol
                        .OrderBy(r => r.name)  // Ordenar por nombre
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener roles: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<rol>();
            }
        }

        public static string InsertUser(string nombre, string email, string password, int idRol)
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    // Validar que el rol exista
                    var rolExistente = db.rol.Any(r => r.idRol == idRol);
                    if (!rolExistente)
                    {
                        return "Error: El rol seleccionado no existe";
                    }

                    // Validar email único
                    if (db.user.Any(u => u.email == email))
                    {
                        return "Error: El correo electrónico ya está registrado";
                    }

                    // Crear nuevo usuario
                    var nuevoUsuario = new user
                    {
                        name = nombre,
                        email = email,
                        password = password, // Considera hashear la contraseña
                        rol = idRol      // Asignar el ID del rol
                    };

                    // Agregar y guardar
                    db.user.Add(nuevoUsuario);
                    db.SaveChanges();

                    return "Usuario creado exitosamente";
                }
            }
            catch (Exception ex)
            {
                // Registrar el error (opcional)
                return $"Error al crear usuario: {ex.Message}";
            }
        }






    }
}
