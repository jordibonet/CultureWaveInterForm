﻿using CultureWaveInterForm.Models;
using CultureWaveInterForm.Utils;
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

            LanguageManager.LoadLanguage += UpdateLanguage;
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            labelNameUser.Text = LanguageManager.GetString("labelNameUser");
            labelEvents.Text = LanguageManager.GetString("labelEvents");
            labelSeats.Text = LanguageManager.GetString("labelSeats");
            roundedButtonReserve.Text = LanguageManager.GetString("roundedButtonReserve");
        }

        private void FormCreateReserve_Load(object sender, EventArgs e)
        {
            loadNames();
            loadEvents();
        }

        /// <summary>
        /// Cargamos los nombres de los usuarios en la comboBox con DataSource
        /// </summary>
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

        /// <summary>
        /// Cargamos los nombres de los eventos en la comboBox mediante DataSource
        /// </summary>
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

        /// <summary>
        /// Creamos una reserva para un usuario, depende si el evento tiene sillas o no ejecuta un insert u otro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    if (comboBoxRow.SelectedItem == null || comboBoxNumSeat.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione fila y número de asiento.", "Asiento requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string rowString = comboBoxRow.SelectedItem.ToString().Trim();

                    // Validar que la fila sea un solo carácter alfabético (A-Z)
                    if (rowString.Length != 1 || !char.IsLetter(rowString[0]))
                    {
                        MessageBox.Show("La fila debe ser una letra válida (ej. A, B, C).", "Fila inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    char row = rowString[0];

                    // Validar que el asiento sea un número válido
                    if (!int.TryParse(comboBoxNumSeat.SelectedItem.ToString(), out int numSeat))
                    {
                        MessageBox.Show("Número de asiento inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verificar disponibilidad del asiento
                    if (!ReserveOrm.IsSeatAvailable(eventId, row, numSeat))
                    {
                        MessageBox.Show("El asiento seleccionado no está disponible.",
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

        /// <summary>
        /// Este metodo se ejecuta cada vez que la comboBoxEvents cambie de selección y si el evento tiene sillas 
        /// fijas le deja seleccionar asientos, si no no.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
