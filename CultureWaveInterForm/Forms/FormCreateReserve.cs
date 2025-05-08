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

namespace CultureWaveInterForm.Forms
{
    public partial class FormCreateReserve : Form
    {

        public FormCreateReserve()
        {
            InitializeComponent();
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxUsers.SelectedIndex == -1 || comboBoxEvents.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione usuario y evento.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userId = (int)comboBoxUsers.SelectedValue;
                int eventId = (int)comboBoxEvents.SelectedValue;

                bool hasFixedSeats = ReserveOrm.EventHasFixedSeats(eventId);
                int reservationId;

                if (hasFixedSeats)
                {
                    if (comboBoxRow.SelectedIndex == -1 || comboBoxNumSeat.SelectedIndex == -1)
                    {
                        MessageBox.Show("Seleccione fila y número de asiento.", "Asiento requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // row como char
                    string rowString = comboBoxRow.SelectedItem.ToString();
                    if (string.IsNullOrEmpty(rowString) || rowString.Length != 1)
                    {
                        MessageBox.Show("La fila debe ser un solo carácter (ej. A, B, C).", "Fila inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    char row = rowString[0];

                    // numSeat como int
                    int numSeat = Convert.ToInt32(comboBoxNumSeat.SelectedItem);

                    if (!ReserveOrm.IsSeatAvailable(eventId, row, numSeat))
                    {
                        MessageBox.Show("El asiento seleccionado no está disponible",
                                      "Asiento ocupado",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                        return;
                    }

                    reservationId = ReserveOrm.CreateReservationWithSeat(userId, eventId, row, numSeat);
                }
                else
                {
                    reservationId = ReserveOrm.CreateReservationWithoutSeat(userId, eventId);
                }

                if (reservationId > 0)
                {
                    MessageBox.Show($"Reserva creada exitosamente.\nID: {reservationId}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo crear la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCreateReserve_Load(object sender, EventArgs e)
        {
            loadNames();
            loadEvents();
        }

        private void loadEvents()
        {
            comboBoxEvents.SelectedIndexChanged -= comboBoxEvents_SelectedIndexChanged;

            var eventos = ReserveOrm.GetEventsForComboBox();
            comboBoxEvents.DataSource = eventos;
            comboBoxEvents.DisplayMember = "Name";
            comboBoxEvents.ValueMember = "Id";
            comboBoxEvents.SelectedIndex = -1;

            comboBoxEvents.SelectedIndexChanged += comboBoxEvents_SelectedIndexChanged;
        }


        private void loadNames()
        {
            // Obtener los datos desde el ORM
            var usuarios = UsersReserveOrm.GetUsersForComboBox(3); // RolId = 3

            // Configurar el ComboBox
            comboBoxUsers.DataSource = usuarios;
            comboBoxUsers.DisplayMember = "DisplayText";
            comboBoxUsers.ValueMember = "Id";

            comboBoxUsers.SelectedIndex = -1;
        }

        private void comboBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEvents.SelectedIndex != -1)
            {
                try
                {
                    // Obtener el ID del evento seleccionado como int
                    var selectedEventValue = comboBoxEvents.SelectedValue;
                    if (selectedEventValue is int selectedEventId)
                    {
                        // Consultar si el evento tiene sillas
                        bool hasFixedSeats = ReserveOrm.EventHasFixedSeats(selectedEventId);

                        // Activar o desactivar los combobox de fila y asiento
                        comboBoxRow.Enabled = hasFixedSeats;
                        comboBoxNumSeat.Enabled = hasFixedSeats;
                    }
                    else
                    {
                        MessageBox.Show("Error: El ID del evento no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el ID del evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                comboBoxRow.Enabled = false;
                comboBoxNumSeat.Enabled = false;
            }
        }
    }
}
