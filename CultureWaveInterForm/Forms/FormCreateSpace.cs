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
    public partial class FormCreateSpace : Form
    {
        private FormData formData;
        private int? currentSpaceId = null;

        public FormCreateSpace(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;

            LanguageManager.LoadLanguage += UpdateLanguage;
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            roundedButtonCreate.Text = LanguageManager.GetString("roundedButtonCreate");
            labelNameSpace.Text = LanguageManager.GetString("labelNameSpace");
            labelCapacity.Text = LanguageManager.GetString("labelCapacity");
            labelFixedSeats.Text = LanguageManager.GetString("labelFixedSeats");
            roundedRadioButtonYesSeats.Text = LanguageManager.GetString("roundedRadioButtonYesSeats");
            labelAvailable.Text = LanguageManager.GetString("labelAvailable");
            roundedRadioButtonYesAvailable.Text = LanguageManager.GetString("roundedRadioButtonYesAvailable");

        }

        /// <summary>
        /// Cargamos los datos del espacio que estamos modificando a los textbox...
        /// </summary>
        /// <param name="espacio"></param>
        public void LoadSpaceData(space espacio)
        {
            currentSpaceId = espacio.idSpace;
            roundedTextBoxNameSpace.Texts = espacio.name;
            roundedTextBoxCapacity.Texts = espacio.capacity.ToString();
            roundedRadioButtonYesSeats.Checked = espacio.fixedSeats.Value;
            roundedRadioButtonNoSeats.Checked = !espacio.fixedSeats.Value;
            roundedRadioButtonYesAvailable.Checked = espacio.available.Value;
            roundedRadioButtonNoAvailable.Checked = !espacio.available.Value;

            this.Text = "Editar Espacio";
            roundedButtonCreate.Text = "Guardar Cambios";
        }

        /// <summary>
        /// Metodo para recoger los datos y hacer un insert para crear un espacio nuevo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            try
            {
                bool success;
                string operation = currentSpaceId.HasValue ? "actualizado" : "creado";

                if (currentSpaceId.HasValue)
                {
                    success = SpacesOrm.UpdateSpace(
                        currentSpaceId.Value,
                        roundedTextBoxNameSpace.Texts.Trim(),
                        Convert.ToInt32(roundedTextBoxCapacity.Texts),
                        roundedRadioButtonYesSeats.Checked,
                        roundedRadioButtonYesAvailable.Checked
                    );
                }
                else
                {
                    success = SpacesOrm.CreateSpace(
                        roundedTextBoxNameSpace.Texts.Trim(),
                        Convert.ToInt32(roundedTextBoxCapacity.Texts),
                        roundedRadioButtonYesSeats.Checked,
                        roundedRadioButtonYesAvailable.Checked
                    );
                }

                if (success)
                {
                    MessageBox.Show($"Espacio {operation} correctamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error al {operation} el espacio", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validamos los campos para que sean medianamente correctos.
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(roundedTextBoxNameSpace.Texts))
            {
                MessageBox.Show("Nombre del espacio es requerido", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(roundedTextBoxCapacity.Texts, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("Capacidad debe ser un número positivo", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
