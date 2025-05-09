using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace CultureWaveInterForm.Models
{
    public static class UsersOrm
    {
        /* SELECT */

        /// <summary>
        /// Método para obtener todos los usuarios, incluyendo sus relaciones
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Metodo para obtener todos los roles y ordenarlos por su nombre
        /// </summary>
        /// <returns></returns>
        public static List<rol> SelectAllRoles()
        {
            try
            {
                using (var db = new cultureWaveEntities1())
                {
                    return db.rol
                        .OrderBy(r => r.name)
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

        /// <summary>
        /// Metodo para coger todos los correos de los usuarios.
        /// </summary>
        /// <returns>Devolvemos los correos o un mensaje de error en caso de que falle</returns>
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

        /// <summary>
        /// En este metodo seleccionamos los usuarios de cada correo
        /// </summary>
        /// <param name="email">Le pasamos el correo para poder buscarlo</param>
        /// <returns>Devuelve una lista o un mensaje de error</returns>
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

        /* INSERT */

        /// <summary>
        /// Metodo para insertar el usuario a la BBDD.
        /// </summary>
        /// <param name="nombre">Cogemos el nombre del usuario que queremos insertar</param>
        /// <param name="email">Cogemos el correo del usuario que queremos insertar</param>
        /// <param name="password">Cogemos la contraseña que queremos insertar</param>
        /// <param name="idRol">Cogemos el rol que le queremos poner al usuario que queremos insertar</param>
        /// <returns>Si se crea bien, devolvemos un mensaje y si se crea mal tambien</returns>
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
                        password = password,
                        rol = idRol
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

        /* UPDATE */

        /// <summary>
        /// Modificamos el usuario con los datos introducidos por el usuario, si no se queda como estaba.
        /// </summary>
        /// <param name="userId">ID del usuario que vamos a modificar</param>
        /// <param name="nombre">Nuevo nombre que queremos poner</param>
        /// <param name="email">Nuevo email que queremos poner</param>
        /// <param name="password">Nueva contraseña que le queremos poner</param>
        /// <param name="idRol">ID del rol que le queremos asignar al usuario</param>
        /// <returns>Devolvemos un mensaje si se ha podido crear bien o mal</returns>
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

        /* DELETE */

        /// <summary>
        /// Metodo para borrar el usuario que hemos seleccionado anteriormente.
        /// </summary>
        /// <param name="userId">pasamos la ID del usuario que queremos borrar</param>
        /// <returns>Devolvemos un mensaje de si se ha borrado bien o mal</returns>
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
    }
}
