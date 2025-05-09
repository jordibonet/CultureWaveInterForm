using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using CultureWave_Form.Forms;
using CultureWaveInterForm.Models;

namespace CultureWave_Form
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            roundedTextBoxPassword.PasswordChar = true;
        }

        /// <summary>
        /// Cuando le de al botón de LogIn hara las comprobaciones para poder iniciar sesión.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string email = roundedTextBoxUser.Texts;
            string password = roundedTextBoxPassword.Texts;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese correo y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener usuarios con rol = 1 o 2
            var usersWithRoles = UsersLogInOrm.GetUsersWithRoles1And2();

            // Buscar el usuario específico
            var usuarioAutenticado = usersWithRoles.FirstOrDefault(u =>
                u.email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                u.password == password);

            if (usuarioAutenticado != null)
            {
                FormData formData = new FormData(usuarioAutenticado);
                formData.LoadFormIntoPanel("FormHome");
                formData.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas o no tiene permisos de acceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
