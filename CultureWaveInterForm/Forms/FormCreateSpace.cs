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
    public partial class FormCreateSpace : Form
    {
        FormData formData;
        public FormCreateSpace(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(roundedTextBoxNameSpace.Texts))
                {
                    MessageBox.Show("El nombre del espacio es obligatorio", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    roundedTextBoxNameSpace.Focus();
                    return;
                }

                if (!int.TryParse(roundedTextBoxCapacity.Texts, out int capacity) || capacity <= 0)
                {
                    MessageBox.Show("La capacidad debe ser un número positivo", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    roundedTextBoxCapacity.Focus();
                    return;
                }

                // Obtener valores de los radio buttons
                bool fixedSeats = roundedRadioButtonYesSeats.Checked;
                bool available = roundedRadioButtonYesAvailable.Checked;

                // Crear el nuevo espacio
                bool success = SpacesOrm.CreateSpace(
                    name: roundedTextBoxNameSpace.Texts.Trim(),
                    capacity: capacity,
                    fixedSeats: fixedSeats,
                    available: available
                );

                if (success)
                {
                    MessageBox.Show("Espacio creado exitosamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el espacio", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
