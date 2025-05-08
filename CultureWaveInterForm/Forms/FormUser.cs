using CultureWaveInterForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            loadUsers();  // Cargar los usuarios cuando se cargue el formulario
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
                dataGridViewUsers.Columns["RolName"].HeaderText = "Rol";
                dataGridViewUsers.Columns["ReserveCount"].HeaderText = "N° Reservas";

                // Limpiar la selección
                dataGridViewUsers.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
