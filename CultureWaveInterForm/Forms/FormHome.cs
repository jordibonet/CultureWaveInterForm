using CultureWaveInterForm.Models;
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
        public FormHome(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            loadEvents();
            loadBookings();

        }

        private void loadBookings()
        {
            try
            {
                // Obtener las reservas con información completa del asiento
                var reserves = BookingOrm.GetReservesWithSeatInfo();

                // Configurar el DataGridView
                dataGridViewBookings.AutoGenerateColumns = false;
                dataGridViewBookings.DataSource = reserves;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reservas: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




            private void loadEvents()
            {
                try
                {
                    // Obtener los eventos programados con el nombre del espacio
                    var events = EventsOrm.GetProgrammedEvents();

                    dataGridViewEvents.DataSource = events;

                // Asignar las propiedades a las columnas
                dataGridViewEvents.Columns["name"].DataPropertyName = "name";
                    dataGridViewEvents.Columns["description"].DataPropertyName = "description";
                    dataGridViewEvents.Columns["startDate"].DataPropertyName = "startDate";
                    dataGridViewEvents.Columns["endDate"].DataPropertyName = "endDate";
                    dataGridViewEvents.Columns["SpaceName"].DataPropertyName = "SpaceName";

                    // Formatear columnas de fecha
                    dataGridViewEvents.Columns["startDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dataGridViewEvents.Columns["endDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar eventos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }
}
