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

namespace CultureWave_Form.Forms
{
    public partial class FormSpace: Form
    {
        FormData formData;
        private BindingSource spacesBindingSource = new BindingSource();
        public FormSpace(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;
        }

        private void FormSpace_Load(object sender, EventArgs e)
        {
            loadSpaces();
        }

        private void loadSpaces()
        {
            try
            {
                // Obtener todos los espacios
                var espacios = SpacesOrm.SelectSpaces();

                // Asignar la lista de espacios al BindingSource
                spacesBindingSource.DataSource = espacios;

                // Asignar el BindingSource al DataGridView
                dataGridViewSpaces.DataSource = spacesBindingSource;

                // Opcional: Configurar columnas del DataGridView si es necesario
                dataGridViewSpaces.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewSpaces.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridViewSpaces.Columns["idSpace"].HeaderText = "ID Espacio";
                dataGridViewSpaces.Columns["name"].HeaderText = "Nombre";
                dataGridViewSpaces.Columns["capacity"].HeaderText = "Capacidad";
                dataGridViewSpaces.Columns["fixedSeats"].HeaderText = "Sillas fijas";
                dataGridViewSpaces.Columns["available"].HeaderText = "Disponible";

                dataGridViewSpaces.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los espacios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            FormCreateSpace createSpace = new FormCreateSpace(formData);
            createSpace.Show();
        }
    }
}
