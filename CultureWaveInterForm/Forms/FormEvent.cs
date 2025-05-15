using System;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Configuration;
using CultureWaveInterForm.Models;
using CultureWaveInterForm.Utils;
using System.Diagnostics;
using System.Linq;

namespace CultureWave_Form.Forms
{
    public partial class FormEvent : Form
    {
        private FormData formData;

        public FormEvent(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;

            LanguageManager.LoadLanguage += UpdateLanguage;
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            roundedButtonCreateEvent.Text = LanguageManager.GetString("roundedButtonCreateEvent");
            roundedButtonGenerateIA.Text = LanguageManager.GetString("roundedButtonGenerateIA");
            labelNameEvents.Text = LanguageManager.GetString("labelNameEvents");
            labelDescription.Text = LanguageManager.GetString("labelDescription");
            labelEventDate.Text = LanguageManager.GetString("labelEventDate");
            labelSpaces.Text = LanguageManager.GetString("labelSpaces");
            labelStatus.Text = LanguageManager.GetString("labelStatus");
        }

        private void FormEvent_Load(object sender, EventArgs e)
        {
            loadSpacesComboBox();
        }

        private void loadSpacesComboBox()
        {
            try
            {
                var espacios = SpacesOrm.SelectAvailableSpaces();
                comboBoxSpaceEvents.DataSource = espacios;
                comboBoxSpaceEvents.DisplayMember = "name";
                comboBoxSpaceEvents.ValueMember = "idSpace";
                comboBoxSpaceEvents.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los espacios: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private async void roundedButtonGenerateIA_Click(object sender, EventArgs e)
        {
            string prompt = $@"Genera un JSON con los campos 'titulo', 'descripcion', 'fecha_inicio' y 'fecha_fin' para un evento cultural. 
            El 'titulo' debe ser breve y atractivo.
            La 'descripcion' debe ser clara y detallada, con un máximo de 200 caracteres, explicando el evento, su contexto y lo que ofrece.
            'fecha_inicio' y 'fecha_fin' deben tener el formato exacto: 'yyyy-MM-dd HH:mm' (por ejemplo: 2025-06-18 19:30).
            Haz que el tipo de evento y contenido varíe creativamente cada vez.
            No repitas ideas anteriores. Imagina que estás escribiendo para diferentes públicos y ciudades.
            Devuelve únicamente el JSON, sin explicaciones ni texto adicional.
            Semilla creativa: {Guid.NewGuid()}";

            var client = new RestClient("https://api.groq.com/openai/v1/chat/completions");
            var request = new RestRequest("", Method.Post);

            string apiKey = ConfigurationManager.AppSettings["GroqApiKey"];
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                MessageBox.Show("No se encontró la clave de API en App.config.", "Error de configuración", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            request.AddHeader("Authorization", $"Bearer {apiKey}");
            request.AddHeader("Content-Type", "application/json");

            request.AddJsonBody(new
            {
                model = "llama3-8b-8192",
                messages = new[] { new { role = "user", content = prompt } },
                temperature = 0.9
            });

            try
            {
                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    var json = JsonDocument.Parse(response.Content);

                    if (!json.RootElement.TryGetProperty("choices", out var choicesArray) ||
                        choicesArray.GetArrayLength() == 0)
                    {
                        MessageBox.Show("La respuesta no contiene opciones válidas.");
                        return;
                    }

                    var responseText = choicesArray[0]
                        .GetProperty("message")
                        .GetProperty("content")
                        .GetString();

                    var match = Regex.Match(responseText, @"\{[\s\S]*?\}");

                    if (match.Success)
                    {
                        var cleanJson = JsonDocument.Parse(match.Value);
                        var root = cleanJson.RootElement;

                        string titulo = root.TryGetProperty("titulo", out var tituloElem) ? tituloElem.GetString() : "";
                        string descripcion = root.TryGetProperty("descripcion", out var descElem) ? descElem.GetString() : "";
                        string fechaInicio = root.TryGetProperty("fecha_inicio", out var iniElem) ? iniElem.GetString() : "";
                        string fechaFin = root.TryGetProperty("fecha_fin", out var finElem) ? finElem.GetString() : "";

                        if (!FechaEsValida(fechaInicio) || !FechaEsValida(fechaFin))
                        {
                            MessageBox.Show("Las fechas no tienen el formato correcto (yyyy-MM-dd HH:mm).");
                            return;
                        }

                        roundedTextBoxNameEvent.Texts = titulo;
                        roundedRichTextBoxDescription.Texts = descripcion;
                        roundedTextBoxEvenDateStart.Texts = fechaInicio;
                        roundedTextBoxEndDate.Texts = fechaFin;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró JSON válido en la respuesta de la IA.");
                    }
                }
                else
                {
                    MessageBox.Show($"Error: {(int)response.StatusCode} - {response.Content}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error crítico: {ex.Message}");
            }
        }

        private bool FechaEsValida(string fecha)
        {
            var formato = "yyyy-MM-dd HH:mm";
            var cultura = CultureInfo.InvariantCulture;

            return DateTime.TryParseExact(fecha, formato, cultura, DateTimeStyles.None, out _);
        }

        private void roundedButtonCreateEvent_Click(object sender, EventArgs e)
        {
            // Limpiar y normalizar los textos
            string eventName = roundedTextBoxNameEvent.Texts?.Trim() ?? "";
            string description = roundedRichTextBoxDescription.Texts?.Trim() ?? "";
            string startDateText = roundedTextBoxEvenDateStart.Texts?.Trim() ?? "";
            string endDateText = roundedTextBoxEndDate.Texts?.Trim() ?? "";

            // Depuración avanzada
            Debug.WriteLine($"Depuración - Fecha Inicio (cruda): '{startDateText}'");
            Debug.WriteLine($"Depuración - Fecha Fin (cruda): '{endDateText}'");

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(eventName) ||
                string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(startDateText) ||
                string.IsNullOrWhiteSpace(endDateText) ||
                comboBoxSpaceEvents.SelectedIndex == -1 ||
                comboBoxStateEvents.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.",
                              "Campos requeridos",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            // Solo se permite el formato "yyyy-MM-dd HH:mm"
            var formatoAceptado = "yyyy-MM-dd HH:mm";
            DateTime startDate, endDate;

            if (!FechaValidaFormatoExacto(startDateText, formatoAceptado, out startDate))
            {
                ShowDateError("inicio", startDateText);
                return;
            }

            if (!FechaValidaFormatoExacto(endDateText, formatoAceptado, out endDate))
            {
                ShowDateError("fin", endDateText);
                return;
            }

            // Validación lógica de fechas
            if (startDate >= endDate)
            {
                MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin.",
                              "Error en fechas",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return;
            }

            // Crear y guardar el evento
            var newEvent = new eventTable
            {
                idSpace = (int)comboBoxSpaceEvents.SelectedValue,
                name = eventName,
                description = description,
                startDate = startDate,
                endDate = endDate,
                status = comboBoxStateEvents.SelectedItem.ToString()
            };

            if (EventsOrm.Insert(newEvent))
            {
                MessageBox.Show("Evento creado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            else
            {
                MessageBox.Show("Error al crear el evento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool FechaValidaFormatoExacto(string fechaText, string formato, out DateTime result)
        {
            return DateTime.TryParseExact(fechaText, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out result);
        }

        private void ShowDateError(string fieldName, string invalidValue)
        {
            MessageBox.Show($"Formato de fecha de {fieldName} inválido: '{invalidValue}'\n\n" +
                           "Formato aceptado:\n" +
                           "- yyyy-MM-dd HH:mm (ej: 2025-05-10 14:30)",
                           "Error de formato",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
        }

        private void ResetForm()
        {
            roundedTextBoxNameEvent.Texts = "";
            roundedRichTextBoxDescription.Texts = "";
            roundedTextBoxEvenDateStart.Texts = "";
            roundedTextBoxEndDate.Texts = "";
            comboBoxSpaceEvents.SelectedIndex = -1;
            comboBoxStateEvents.SelectedIndex = -1;
        }
    }
}
