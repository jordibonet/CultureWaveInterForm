using System;
using System.Windows.Forms;
using CultureWaveInterForm.Models;
using CultureWaveInterForm.Utils; // Asegúrate de que esta clase esté incluida

namespace CultureWave_Form.Forms
{
    public partial class FormCreateEditUser : Form
    {
        private int? currentUserId = null;

        public FormCreateEditUser()
        {
            InitializeComponent();
            loadRol();
        }

        /// <summary>
        /// Boton para cancelar la creación/modificación de usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Cargamos los roles en el comboBox mediante BindingSource
        /// </summary>
        private void loadRol()
        {
            try
            {
                var roles = UsersOrm.SelectAllRoles();
                var rolesBindingSource = new BindingSource();
                rolesBindingSource.DataSource = roles;

                // Configurar el ComboBox
                comboBoxRol.DataSource = rolesBindingSource;
                comboBoxRol.DisplayMember = "name";  // Mostrar el nombre del rol
                comboBoxRol.ValueMember = "idRol";   // Valor asociado será el ID

                comboBoxRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar roles: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Determinamos si estamos creando o editando un usuario y entonces hacer un insert o un update.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundedButtonAccept_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario
            string nombre = roundedTextBoxUser.Texts.Trim();
            string email = roundedTextBoxEmail.Texts.Trim();
            string password = roundedTextBoxPassword.Texts;
            int idRol = comboBoxRol.SelectedValue != null ?
                       (int)comboBoxRol.SelectedValue : 0;

            // Validaciones básicas
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || idRol == 0)
            {
                MessageBox.Show("Por favor complete todos los campos", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Encriptar la contraseña antes de insertarla o actualizarla
            string encryptedPassword = BCryptClass.EncryptAES(password, "1234567890123456"); // Usa la clave AES

            // Determinar si es creación o actualización
            if (currentUserId == null)
            {
                // Lógica para crear nuevo usuario
                string resultado = UsersOrm.InsertUser(nombre, email, encryptedPassword, idRol);

                MessageBox.Show(resultado, resultado.Contains("Error") ? "Error" : "Éxito",
                               MessageBoxButtons.OK,
                               resultado.Contains("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information);

                if (!resultado.Contains("Error"))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                // Lógica para actualizar usuario existente
                string resultado = UsersOrm.UpdateUser(currentUserId.Value, nombre, email, encryptedPassword, idRol);

                MessageBox.Show(resultado, resultado.Contains("Error") ? "Error" : "Éxito",
                               MessageBoxButtons.OK,
                               resultado.Contains("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information);

                if (!resultado.Contains("Error"))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Cargamos los datos del usuario que modificamos
        /// </summary>
        /// <param name="user"></param>
        internal void loadUsersData(user user)
        {
            currentUserId = user.idUser;
            roundedTextBoxUser.Texts = user.name;
            roundedTextBoxEmail.Texts = user.email.ToString();
            roundedTextBoxPassword.Texts = user.password.ToString();
            comboBoxRol.SelectedValue = user.rol;

            this.Text = "Editar Usuario";
            roundedButtonAccept.Text = "Guardar Cambios";
        }
    }
}
