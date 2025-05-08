using CultureWaveInterForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void roundedButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCreateEditUser_Load(object sender, EventArgs e)
        {
            
        }

        private void loadRol()
        {
            try
            {
                // Obtener todos los roles
                var roles = UsersOrm.SelectAllRoles();

                // Crear el BindingSource
                var rolesBindingSource = new BindingSource();

                // Configurar el BindingSource
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

            // Determinar si es creación o actualización
            if (currentUserId == null)
            {
                // Lógica para crear nuevo usuario
                string resultado = UsersOrm.InsertUser(nombre, email, password, idRol);

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
                string resultado = UsersOrm.UpdateUser(currentUserId.Value, nombre, email, password, idRol);

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
