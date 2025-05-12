using CultureWaveInterForm.Models;
using CultureWaveInterForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{ //sia

    public partial class FormHome : Form
    {
        FormData formData;
        private BindingSource eventsBindingSource = new BindingSource();
        private BindingSource bookingsBindingSource = new BindingSource();
        public FormHome(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;

            LanguageManager.LoadLanguage += UpdateLanguage;
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            labelActiveEvents.Text = LanguageManager.GetString("labelActiveEvents");
            labelRecentReservations.Text = LanguageManager.GetString("labelRecentReservations");
        }

        /// <summary>
        /// Ejecutará los dos siguientes metodos la primera vez que se ejecute este formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormHome_Load(object sender, EventArgs e)
        {
            loadEvents();
            loadBookings();
        }

        /// <summary>
        /// Cargamos los eventos en una dataGridView mediante BindingSource
        /// </summary>
        private void loadEvents()
        {
            try
            {
                // Obtener los eventos programados con el nombre del espacio
                var events = EventsOrm.GetProgrammedEvents();

                // Asignar los datos al BindingSource
                eventsBindingSource.DataSource = events;

                // Configurar el DataGridView
                dataGridViewEvents.AutoGenerateColumns = false;
                dataGridViewEvents.DataSource = eventsBindingSource;

                // Asignar las propiedades a las columnas
                dataGridViewEvents.Columns["name"].DataPropertyName = "name";
                dataGridViewEvents.Columns["description"].DataPropertyName = "description";
                dataGridViewEvents.Columns["startDate"].DataPropertyName = "startDate";
                dataGridViewEvents.Columns["endDate"].DataPropertyName = "endDate";
                dataGridViewEvents.Columns["SpaceName"].DataPropertyName = "SpaceName";

                // Formatear columnas de fecha
                dataGridViewEvents.Columns["startDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dataGridViewEvents.Columns["endDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                dataGridViewEvents.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar eventos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Agregar las reservas al dataGridView mediante BindingSource
        /// </summary>
        private void loadBookings()
        {
            try
            {
                // Obtener las reservas con información completa del asiento
                var reserves = BookingOrm.GetReservesWithSeatInfo();

                // Asignar los datos al BindingSource
                bookingsBindingSource.DataSource = reserves;

                // Configurar el DataGridView
                dataGridViewBookings.AutoGenerateColumns = false;
                dataGridViewBookings.DataSource = bookingsBindingSource;

                // Asignar las propiedades a las columnas
                dataGridViewBookings.Columns["idReserve"].DataPropertyName = "idReserve";
                dataGridViewBookings.Columns["idEvent"].DataPropertyName = "idEvent";
                dataGridViewBookings.Columns["reserveDate"].DataPropertyName = "reserveDate";
                dataGridViewBookings.Columns["EventName"].DataPropertyName = "EventName";
                dataGridViewBookings.Columns["SpaceNameBooking"].DataPropertyName = "SpaceName";
                dataGridViewBookings.Columns["SeatInfo"].DataPropertyName = "SeatInfo";
                dataGridViewBookings.Columns["Users"].DataPropertyName = "Users";

                // Formatear columna de fecha
                dataGridViewBookings.Columns["reserveDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                // Ajustar automáticamente el ancho de las columnas
                dataGridViewBookings.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Limpiar la selección
                dataGridViewBookings.ClearSelection();
                if (dataGridViewBookings.CurrentRow != null)
                {
                    dataGridViewBookings.CurrentRow.Selected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reservas: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
