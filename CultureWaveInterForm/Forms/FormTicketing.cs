using CultureWave_Form.Forms;
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
    public partial class FormTicketing : Form
    {
        private FormData formData;
        private BindingSource ticketsBindingSource = new BindingSource();

        public FormTicketing(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;

            loadTickets();
        }

        /// <summary>
        /// Cargamos los tickets de los usuarios que tengan los tickets abiertos en el dataGridView.
        /// </summary>
        private void loadTickets()
        {
            try
            {
                // Obtener tickets activos con los campos específicos
                var activeTickets = TicketOrm.GetActiveTickets();

                // Asignar los datos al DataGridView
                ticketsBindingSource.DataSource = activeTickets;
                dataGridViewTicketing.DataSource = ticketsBindingSource;

                // Habilitar la generación automática de columnas
                dataGridViewTicketing.AutoGenerateColumns = true;
                dataGridViewTicketing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                // Si quieres ocultar alguna columna, puedes hacerlo aquí
                // dataGridViewTicketing.Columns["Status"].Visible = false;

                // Limpiar la selección
                dataGridViewTicketing.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los tickets: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Pasa el ticket a estan "Tancat" para no mostrarlo mas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundedButtonCloseTicket_Click(object sender, EventArgs e)
        {
            if (dataGridViewTicketing.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un ticket para cerrar",
                              "Advertencia",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            var selectedTicket = (dynamic)dataGridViewTicketing.SelectedRows[0].DataBoundItem;

            try
            {
                // Confirmar el cierre
                var result = MessageBox.Show($"¿Está seguro que desea cerrar el ticket #{selectedTicket.ID}?",
                                            "Confirmar cierre",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Actualizar el estado del ticket
                    bool success = TicketOrm.CloseTicket(selectedTicket.ID);

                    if (success)
                    {
                        MessageBox.Show("Ticket cerrado correctamente",
                                      "Éxito",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        loadTickets(); // Refrescar la lista
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cerrar el ticket",
                                      "Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cerrar ticket: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
    }
}
