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
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string email = roundedTextBoxUser.Texts;
            string password = roundedTextBoxPassword.Texts;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese correo y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener usuarios con rol = 1
            var usersWithRol1 = UsersLogInOrm.GetUsersWithRolId1();

            // Verificar si el correo y contraseña coinciden con algún usuario de rol 1
            bool loginExitoso = usersWithRol1.Any(u =>
                u.email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                u.password == password);

            if (loginExitoso)
            {
                // Autenticación exitosa
                FormData formData = new FormData();
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
