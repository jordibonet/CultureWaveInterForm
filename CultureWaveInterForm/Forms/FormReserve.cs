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

            dataGridViewReserves.DataSource = reservesBindingSource;
            dataGridViewReserves.Visible = false;
            labelNameReserves.Visible = false;
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
            dataGridViewReserves.Visible = true;
            labelNameReserves.Visible = true;

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

                    // Asignar los datos al BindingSource
                    reservesBindingSource.DataSource = reservas;

                    // Configuración del DataGridView
                    dataGridViewReserves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewReserves.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    // Asignación de cabeceras de columnas
                    dataGridViewReserves.Columns["ReservationId"].HeaderText = "ID";
                    dataGridViewReserves.Columns["EventName"].HeaderText = "Nombre del Evento";
                    dataGridViewReserves.Columns["StartDate"].HeaderText = "Fecha de Inicio";
                    dataGridViewReserves.Columns["EndDate"].HeaderText = "Fecha de Fin";
                    dataGridViewReserves.Columns["Status"].HeaderText = "Estado del Evento";
                    dataGridViewReserves.Columns["SpaceName"].HeaderText = "Espacio";
                    dataGridViewReserves.Columns["ReserveDate"].HeaderText = "Fecha de Reserva";
                    dataGridViewReserves.Columns["SeatInfo"].HeaderText = "Información del Asiento";

                    // Llenar la columna del ID de reserva
                    foreach (DataGridViewRow row in dataGridViewReserves.Rows)
                    {
                        row.Cells["ReservationId"].Value = row.Cells["ReservationId"].Value; // Asegúrate de que la celda esté bien vinculada
                    }

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

        private void roundedButtonDeleteReserve_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dataGridViewReserves.SelectedRows.Count > 0)
            {
                // Obtener el ID de la reserva desde la columna "ReservationId" del DataGridView
                int reservationId = Convert.ToInt32(dataGridViewReserves.SelectedRows[0].Cells["ReservationId"].Value);

                // Obtener información de la reserva para mostrar en el mensaje de confirmación
                string reserveInfo = dataGridViewReserves.SelectedRows[0].Cells["NombreReserva"].Value?.ToString() ??
                                    $"Reserva ID: {reservationId}";

                // Mostrar mensaje de confirmación
                DialogResult result = MessageBox.Show(
                    $"¿Estás seguro que deseas eliminar la reserva: {reserveInfo}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2); // No como opción por defecto

                if (result == DialogResult.Yes)
                {
                    // Intentar eliminar la reserva
                    bool isDeleted = ReserveOrm.DeleteReservation(reservationId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Reserva eliminada exitosamente.", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refrescar el DataGridView para mostrar las reservas actualizadas
                        roundedButtonSearch_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la reserva.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada.", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una reserva para eliminar.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}
