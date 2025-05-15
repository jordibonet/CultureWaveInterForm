using CultureWaveInterForm.Models;
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

            LanguageManager.LoadLanguage += UpdateLanguage;
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            roundedButtonCreate.Text = LanguageManager.GetString("roundedButtonCreate");
            roundedButtonEdit.Text = LanguageManager.GetString("roundedButtonEdit");
            labelSpaces.Text = LanguageManager.GetString("labelSpaces");
        }

        /// <summary>
        /// Ejecutara este metodo la primera vez que se ejecute el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSpace_Load(object sender, EventArgs e)
        {
            loadSpaces();
        }

        /// <summary>
        /// Carga los datos de los espacios en la dataGridView con los campos que creia "importantes".
        /// </summary>
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
                dataGridViewSpaces.Columns["fixeSeats"].HeaderText = "Sillas fijas";
                dataGridViewSpaces.Columns["available"].HeaderText = "Disponible";

                dataGridViewSpaces.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los espacios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Abrira un formulario para crear un espacio nuevo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            FormCreateSpace createSpace = new FormCreateSpace(formData);
            if (createSpace.ShowDialog() == DialogResult.OK)
            {
                loadSpaces(); // Refrescar después de crear
            }
        }

        /// <summary>
        /// Verifica que tengas un espacio seleccionado; si no lo tienes te dara un error, pero si lo tienes
        /// abrira un formulario y le pasará los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundedButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpaces.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un espacio para editar", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewSpaces.SelectedRows[0];
            var espacio = new space
            {
                idSpace = Convert.ToInt32(selectedRow.Cells["idSpace"].Value),
                name = selectedRow.Cells["name"].Value.ToString(),
                capacity = Convert.ToInt32(selectedRow.Cells["capacity"].Value),
                fixeSeats = Convert.ToBoolean(selectedRow.Cells["fixedSeats"].Value),
                available = Convert.ToBoolean(selectedRow.Cells["available"].Value)
            };

            var editForm = new FormCreateSpace(formData);
            editForm.LoadSpaceData(espacio);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                loadSpaces(); // Refrescar después de editar
            }
        }

        private void dataGridViewSpaces_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewSpaces.Columns[e.ColumnIndex].Name == "fixedSeats")
            {
                if (e.Value == null || Convert.ToInt32(e.Value) == 0)
                {
                    e.Value = "Sin sillas";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
