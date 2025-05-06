using CultureWaveInterForm.Forms;
using CultureWaveInterForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{
    public partial class FormReserve : Form
    {
        FormData formData;
        BindingSource reservesBindingSource = new BindingSource();

        public FormReserve(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;
        }

        private void FormReserve_Load(object sender, EventArgs e)
        {
            loadUsersComboBox();

            dataGridViewSpaces.DataSource = reservesBindingSource;
            dataGridViewSpaces.Visible = false;
        }

        private void loadUsersComboBox()
        {
            List<string> users = UsersReserveOrm.GetUserNamesOrEmailsByRoleId(3);

            // Crear BindingSource para el ComboBox
            BindingSource usersBindingSource = new BindingSource();
            usersBindingSource.DataSource = users;
            comboBoxUsers.DataSource = usersBindingSource;

            // Configurar qué valor se debe mostrar en el ComboBox
            comboBoxUsers.DisplayMember = "ToString"; // Cada item es una cadena

            if (comboBoxUsers.Items.Count > 0)
            {
                comboBoxUsers.SelectedIndex = -1;
            }
        }

        private void roundedButtonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewSpaces.Visible = true;

            // Verificar si hay un usuario seleccionado
            if (comboBoxUsers.SelectedIndex != -1)
            {
                string selectedUser = comboBoxUsers.SelectedItem.ToString();
                var userDetails = selectedUser.Split(new string[] { " - " }, StringSplitOptions.None); // Usamos un delimitador de cadena
                string userEmail = userDetails[1]; // Obtener el correo electrónico

                // Obtener el ID del usuario a partir del correo electrónico
                var userId = UsersReserveOrm.GetUserIdByEmail(userEmail);

                if (userId != 0)
                {
                    // Obtener las reservas del usuario utilizando el método GetUserReservesWithDetails
                    var reservas = ReserveOrm.GetUserReservesWithDetails(userId);

                    reservesBindingSource.DataSource = reservas;

                    dataGridViewSpaces.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewSpaces.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    dataGridViewSpaces.Columns["EventName"].HeaderText = "Nombre del Evento";
                    dataGridViewSpaces.Columns["StartDate"].HeaderText = "Fecha de Inicio";
                    dataGridViewSpaces.Columns["EndDate"].HeaderText = "Fecha de Fin";
                    dataGridViewSpaces.Columns["Status"].HeaderText = "Estado del Evento";
                    dataGridViewSpaces.Columns["SpaceName"].HeaderText = "Espacio";
                    dataGridViewSpaces.Columns["ReserveDate"].HeaderText = "Fecha de Reserva";
                    dataGridViewSpaces.Columns["SeatInfo"].HeaderText = "Información del Asiento";

                    // Refrescar los bindings
                    reservesBindingSource.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("No se encontró un usuario con ese correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void roundedButtonReserve_Click(object sender, EventArgs e)
        {
            FormCreateReserve reserve = new FormCreateReserve();
            reserve.Show();
        }
    }
}
