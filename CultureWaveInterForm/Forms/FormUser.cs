using CultureWaveInterForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CultureWave_Form.Utils;
using CultureWaveInterForm.Utils;


namespace CultureWave_Form.Forms
{
    public partial class FormUser : Form
    {
        private FormData formData;

        public FormUser(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;

            LanguageManager.LoadLanguage += UpdateLanguage;
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            roundedButtonSearch.Text = LanguageManager.GetString("roundedButtonSearch");
            roundedButtonReset.Text = LanguageManager.GetString("roundedButtonReset");
            roundedButtonEdit.Text = LanguageManager.GetString("roundedButtonEdit");
            roundedButtonDelete.Text = LanguageManager.GetString("roundedButtonDelete");
            roundedButtonCreate.Text = LanguageManager.GetString("roundedButtonCreate");
            labelUsers.Text = LanguageManager.GetString("labelUsers");
        }

        /// <summary>
        /// Ejecuta estos metodos la primera vez que se ejecute.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormUser_Load(object sender, EventArgs e)
        {
            loadUsers();
            ConfigureEmailAutocomplete();
        }

        /// <summary>
        /// Carga los usuarios en el dataGridViewUsers mediante DataSource.
        /// </summary>
        private void loadUsers()
        {
            try
            {
                // Obtener usuarios con los campos específicos
                var users = UsersOrm.SelectUsersWithSpecificFields();
                dataGridViewUsers.DataSource = users;

                // Configuración de las columnas
                dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Configurar los encabezados de las columnas
                dataGridViewUsers.Columns["idUser"].HeaderText = "ID Usuario";
                dataGridViewUsers.Columns["name"].HeaderText = "Nombre";
                dataGridViewUsers.Columns["email"].HeaderText = "Correo Electrónico";
                dataGridViewUsers.Columns["password"].HeaderText = "Contraseña";
                dataGridViewUsers.Columns["RolName"].HeaderText = "Rol";
                dataGridViewUsers.Columns["IdRol"].HeaderText = "ID ROL";
                dataGridViewUsers.Columns["ReserveCount"].HeaderText = "N° Reservas";

                dataGridViewUsers.Columns["password"].Visible = false;
                dataGridViewUsers.Columns["IdRol"].Visible = false;

                // Limpiar la selección
                dataGridViewUsers.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Configuración para autocompletar el correo al escribirse con correos de usuarios de la BBDD.
        /// </summary>
        private void ConfigureEmailAutocomplete()
        {
            List<string> correos = UsersOrm.SelectAllUserEmails(); 

            AutoCompleteStringCollection autoSource = new AutoCompleteStringCollection();
            autoSource.AddRange(correos.ToArray());

            roundedTextBoxEmail.Controls
                .OfType<TextBox>()
                .FirstOrDefault()?.ApplyAutoComplete(autoSource);
        }

        /// <summary>
        /// Cuando le de a buscar actualizará el dataGridViewUsers y mostrara el usuario escrito por el usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundedButtonBuscar_Click(object sender, EventArgs e)
        {
            var innerTextBox = roundedTextBoxEmail.Controls
                .OfType<TextBox>()
                .FirstOrDefault();

            if (innerTextBox != null)
            {
                string email = innerTextBox.Text.Trim();

                if (!string.IsNullOrEmpty(email))
                {
                    var usuariosFiltrados = UsersOrm.SelectUserByEmail(email);
                    dataGridViewUsers.DataSource = usuariosFiltrados;
                }
                else
                {
                    MessageBox.Show("Por favor, introduce un correo válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Resetea la dataGridViewUsers para mostrar nuevamente todos los usuarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundedButtonReset_Click(object sender, EventArgs e)
        {
            loadUsers();
        }

        /// <summary>
        /// Muestra el formulario para crear un usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            FormCreateEditUser formCreateEditUser = new FormCreateEditUser();
            formCreateEditUser.ShowDialog();

            // Recargar usuarios después de crear/editar
            loadUsers();
        }

        /// <summary>
        /// Muestra el formulario para editar los usuario, le pasamos los datos del usuario con un objeto user y recarga os usuarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un espacio para editar", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewUsers.SelectedRows[0];
            var user = new user
            {
                idUser = Convert.ToInt32(selectedRow.Cells["idUser"].Value),
                name = selectedRow.Cells["name"].Value.ToString(),
                email = selectedRow.Cells["email"].Value.ToString(),
                password = selectedRow.Cells["password"].Value.ToString(),
                rol = Convert.ToInt32(selectedRow.Cells["idRol"].Value)
            };

            var editForm = new FormCreateEditUser();
            editForm.loadUsersData(user);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                loadUsers();
            }
        }

        /// <summary>
        /// Elimina el usuario que tenga el usuario seleccionado en la dataGridViewUsers y da un mensaje de confirmación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundedButtonDelete_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un usuario para eliminar",
                              "Advertencia",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del usuario seleccionado
            int selectedUserId = (int)dataGridViewUsers.SelectedRows[0].Cells["idUser"].Value;
            string userName = dataGridViewUsers.SelectedRows[0].Cells["name"].Value.ToString();

            // Confirmar eliminación
            DialogResult confirm = MessageBox.Show(
                $"¿Está seguro que desea eliminar al usuario '{userName}' (ID: {selectedUserId})?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Llamar al método de eliminación
                string resultado = UsersOrm.DeleteUser(selectedUserId);

                // Mostrar resultado
                MessageBox.Show(resultado,
                               resultado.StartsWith("Error") ? "Error" : "Éxito",
                               MessageBoxButtons.OK,
                               resultado.StartsWith("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information);

                // Recargar la lista si fue exitoso
                if (!resultado.StartsWith("Error"))
                {
                    loadUsers();
                }
            }
        }
    }
}
