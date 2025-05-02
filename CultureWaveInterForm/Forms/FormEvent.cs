using System;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Globalization;
using CultureWaveInterForm.Models;

namespace CultureWave_Form.Forms
{
    public partial class FormEvent : Form
    {
        private FormData formData;

        public FormEvent(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;
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
            La 'descripcion' debe ser clara y detallada, con un máximo de 3 frases completas que expliquen el evento, su contexto y lo que ofrece.
            'fecha_inicio' y 'fecha_fin' deben tener el formato exacto: 'yyyy-MM-dd HH:mm' (por ejemplo: 2025-06-18 19:30).
            Haz que el tipo de evento y contenido varíe creativamente cada vez.
            No repitas ideas anteriores. Imagina que estás escribiendo para diferentes públicos y ciudades.
            Devuelve únicamente el JSON, sin explicaciones ni texto adicional.
            Semilla creativa: {Guid.NewGuid()}";

            var client = new RestClient("https://api.groq.com/openai/v1/chat/completions");
            var request = new RestRequest("", Method.Post);

            request.AddHeader("Authorization", "Bearer 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");
            request.AddHeader("Content-Type", "application/json");

            request.AddJsonBody(new
            {
                model = "llama3-8b-8192",
                messages = new[]
                {
                    new { role = "user", content = prompt }
                },
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
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(roundedTextBoxNameEvent.Texts) ||
                string.IsNullOrWhiteSpace(roundedRichTextBoxDescription.Texts) ||
                string.IsNullOrWhiteSpace(roundedTextBoxEvenDateStart.Texts) ||
                string.IsNullOrWhiteSpace(roundedTextBoxEndDate.Texts) ||
                comboBoxSpaceEvents.SelectedIndex == -1 ||
                comboBoxStateEvents.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.",
                              "Campos requeridos",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            var formato = "yyyy-MM-dd HH:mm";
            var cultura = CultureInfo.InvariantCulture;

            if (!DateTime.TryParseExact(roundedTextBoxEvenDateStart.Texts, formato, cultura, DateTimeStyles.None, out DateTime startDate) ||
                !DateTime.TryParseExact(roundedTextBoxEndDate.Texts, formato, cultura, DateTimeStyles.None, out DateTime endDate))
            {
                MessageBox.Show("Formato de fecha inválido. Use el formato: yyyy-MM-dd HH:mm",
                              "Error de formato",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return;
            }

            if (startDate >= endDate)
            {
                MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin.",
                              "Error en fechas",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return;
            }

            // Crear objeto eventTable
            var newEvent = new eventTable
            {
                idSpace = (int)comboBoxSpaceEvents.SelectedValue,
                name = roundedTextBoxNameEvent.Texts,
                description = roundedRichTextBoxDescription.Texts,
                startDate = startDate,
                endDate = endDate,
                status = comboBoxStateEvents.SelectedItem.ToString()
            };

            if (EventsOrm.Insert(newEvent))
            {
                MessageBox.Show("Evento creado exitosamente!",
                              "Éxito",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                // Limpiar campos
                roundedTextBoxNameEvent.Texts = "";
                roundedRichTextBoxDescription.Texts = "";
                roundedTextBoxEvenDateStart.Texts = "";
                roundedTextBoxEndDate.Texts = "";
                comboBoxSpaceEvents.SelectedIndex = -1;
                comboBoxStateEvents.SelectedIndex = -1;
            }
        }
    }
}
