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
{ 

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

                // Configurar columnas manualmente
                if (dataGridViewBookings.Columns.Count == 0)
                {
                    dataGridViewBookings.Columns.Add("idReserve", "ID Reserva");
                    dataGridViewBookings.Columns.Add("idEvent", "ID Evento");
                    dataGridViewBookings.Columns.Add("reserveDate", "Fecha Reserva");
                    dataGridViewBookings.Columns.Add("EventName", "Evento");
                    dataGridViewBookings.Columns.Add("SpaceName", "Espacio");
                    dataGridViewBookings.Columns.Add("SeatInfo", "Ubicación Asiento");
                }

                // Asignar las propiedades a las columnas
                dataGridViewBookings.Columns["idReserve"].DataPropertyName = "idReserve";
                dataGridViewBookings.Columns["idEvent"].DataPropertyName = "idEvent";
                dataGridViewBookings.Columns["reserveDate"].DataPropertyName = "reserveDate";
                dataGridViewBookings.Columns["EventName"].DataPropertyName = "EventName";
                dataGridViewBookings.Columns["SpaceName"].DataPropertyName = "SpaceName";
                dataGridViewBookings.Columns["SeatInfo"].DataPropertyName = "SeatInfo";

                // Formatear columna de fecha
                dataGridViewBookings.Columns["reserveDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                // Opcional: Ajustar automáticamente el ancho de las columnas
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

                // Configurar el DataGridView
                dataGridViewEvents.AutoGenerateColumns = false;
                dataGridViewEvents.DataSource = events;

                // Configurar columnas manualmente (opcional para mejor control)
                if (dataGridViewEvents.Columns.Count == 0)
                {
                    dataGridViewEvents.Columns.Add("name", "Nombre del Evento");
                    dataGridViewEvents.Columns.Add("description", "Descripción");
                    dataGridViewEvents.Columns.Add("startDate", "Fecha Inicio");
                    dataGridViewEvents.Columns.Add("endDate", "Fecha Fin");
                    dataGridViewEvents.Columns.Add("SpaceName", "Espacio");
                }

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
