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
                            u.password,
                            RolName = u.rol1.name, // Nombre del rol o valor por defecto
                            IdRol = u.rol,
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

        public static string UpdateUser(int userId, string nombre, string email, string password, int idRol)
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    // Buscar el usuario existente
                    var usuario = db.user.Find(userId);
                    if (usuario == null)
                    {
                        return "Error: El usuario no existe";
                    }

                    // Validar que el rol exista
                    var rolExistente = db.rol.Any(r => r.idRol == idRol);
                    if (!rolExistente)
                    {
                        return "Error: El rol seleccionado no existe";
                    }

                    // Validar email único (excepto para el propio usuario)
                    if (db.user.Any(u => u.email == email && u.idUser != userId))
                    {
                        return "Error: El correo electrónico ya está registrado por otro usuario";
                    }

                    // Actualizar propiedades
                    usuario.name = nombre;
                    usuario.email = email;
                    usuario.password = password;
                    usuario.rol = idRol;

                    db.SaveChanges();
                    return "Usuario actualizado exitosamente";
                }
            }
            catch (Exception ex)
            {
                return $"Error al actualizar usuario: {ex.Message}";
            }
        }

        public static string DeleteUser(int userId)
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    // Buscar el usuario a eliminar
                    var usuario = db.user.Find(userId);
                    if (usuario == null)
                    {
                        return "Error: El usuario no existe";
                    }

                    // Verificar si tiene reservas o mensajes asociados (opcional)
                    if (usuario.reserve.Any() || usuario.message.Any())
                    {
                        return "Error: El usuario tiene reservas o mensajes asociados. No se puede eliminar.";
                    }

                    // Eliminar el usuario
                    db.user.Remove(usuario);
                    db.SaveChanges();

                    return "Usuario eliminado exitosamente";
                }
            }
            catch (Exception ex)
            {
                return $"Error al eliminar usuario: {ex.Message}";
            }
        }

        public static List<string> SelectAllUserEmails()
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    return db.user
                             .Select(u => u.email)
                             .Distinct()
                             .OrderBy(email => email)
                             .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener correos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }
        }

        public static List<dynamic> SelectUserByEmail(string email)
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    return db.user
                        .Where(u => u.email == email)
                        .Select(u => new
                        {
                            u.idUser,
                            u.name,
                            u.email,
                            u.password,
                            RolName = u.rol1.name,
                            IdRol = u.rol,
                            ReserveCount = u.reserve.Count
                        })
                        .ToList<dynamic>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<dynamic>();
            }
        }








    }
}
