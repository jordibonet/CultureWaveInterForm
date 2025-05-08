using CultureWaveInterForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CultureWave_Form.Utils;


namespace CultureWave_Form.Forms
{
    public partial class FormUser : Form
    {
        private FormData formData;
        private BindingSource usersBindingSource = new BindingSource(); // BindingSource para enlazar los usuarios

        public FormUser(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            loadUsers();
            ConfigureEmailAutocomplete();

        }

        private void ConfigureEmailAutocomplete()
        {
            List<string> correos = UsersOrm.SelectAllUserEmails(); // Tu método para obtener emails

            AutoCompleteStringCollection autoSource = new AutoCompleteStringCollection();
            autoSource.AddRange(correos.ToArray());

            // Asignar al textbox interno del RoundedTextBox
            roundedTextBoxEmail.Controls
                .OfType<TextBox>()
                .FirstOrDefault()?.ApplyAutoComplete(autoSource);
        }

        private void roundedButtonBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el TextBox interno
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



        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            // Crear y mostrar el formulario para agregar o editar un usuario
            FormCreateEditUser formCreateEditUser = new FormCreateEditUser();
            formCreateEditUser.ShowDialog();

            // Recargar usuarios después de crear/editar
            loadUsers();
        }

        private void loadUsers()
        {
            try
            {
                // Obtener usuarios con los campos específicos
                var users = UsersOrm.SelectUsersWithSpecificFields();

                // Asignar directamente al DataGridView
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

        private void roundedButtonReset_Click(object sender, EventArgs e)
        {
            loadUsers();
        }
    }
}
