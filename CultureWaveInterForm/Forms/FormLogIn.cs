using System;
using System.Linq;
using System.Windows.Forms;
using CultureWave_Form.Forms;
using CultureWaveInterForm.Models;
using CultureWaveInterForm.Utils;

namespace CultureWave_Form
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            roundedTextBoxPassword.PasswordChar = true;

            LanguageManager.LoadLanguage += UpdateLanguage;
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            labelUser.Text = LanguageManager.GetString("labelUser");
            labelPassword.Text = LanguageManager.GetString("labelPassword");
            buttonLogIn.Text = LanguageManager.GetString("buttonLogIn");
        }

        /// <summary>
        /// Cuando le de al botón de LogIn hará las comprobaciones para poder iniciar sesión.
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

            // Encriptamos la contraseña con la clase de BCryptClass
            string encryptedPassword = BCryptClass.EncryptSHA256(password);

            // Obtener los usuarios con rol 1 y 2 desde la base de datos
            var usersWithRoles = UsersLogInOrm.GetUsersWithRoles1And2();

            // Buscar el usuario que coincida con el email y la contraseña encriptada
            var usuarioAutenticado = usersWithRoles.FirstOrDefault(u =>
                u.email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                u.password == encryptedPassword);  // Comparar con la contraseña encriptada

            if (usuarioAutenticado != null)
            {
                // Si se encuentra el usuario, cargar la siguiente pantalla
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
