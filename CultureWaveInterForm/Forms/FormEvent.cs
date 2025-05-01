using System;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;
using System.Text.RegularExpressions;

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

        private async void roundedButtonGenerateIA_Click(object sender, EventArgs e)
        {
            string prompt = $@"Genera un JSON con los campos 'titulo', 'descripcion', 'fecha_inicio' y 'fecha_fin' para un evento cultural. 
El 'titulo' debe ser breve y atractivo.
La 'descripcion' debe ser clara y detallada, con un máximo de 3 frases completas que expliquen el evento, su contexto y lo que ofrece.
'fecha_inicio' y 'fecha_fin' deben tener el formato exacto: 'yyyy/MM/dd HH:mm' (por ejemplo: 2025/06/18 19:30).
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
                            MessageBox.Show("Las fechas no tienen el formato correcto (yyyy/MM/dd HH:mm).");
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
            return Regex.IsMatch(fecha, @"^\d{4}/\d{2}/\d{2} \d{2}:\d{2}$");
        }
    }
}
