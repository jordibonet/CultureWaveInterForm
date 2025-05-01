using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CultureWave_Form.Forms
{
    public partial class FormEvent : Form
    {
        private FormData formData;

        public FormEvent(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;

            //si
        }

        private async void roundedButtonGenerateIA_Click(object sender, EventArgs e)
        {
            string prompt = "Genera un título y una breve descripción para un evento cultural en formato JSON. Incluye campos 'titulo' y 'descripcion'. Considera el tipo de evento, el público objetivo y socios importantes. Ejemplo:\n{\n  \"titulo\": \"Noches latinas de baile y sabor en el centro cultural\",\n  \"descripcion\": \"Únete a nosotros para una noche llena de ritmos latinos vibrantes y deliciosos sabores gastronómicos...\"\n}";

            var client = new RestClient("https://api-inference.huggingface.co/models/mistralai/Mixtral-8x7B-Instruct-v0.1");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Authorization", "Bearer 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");
            request.AddJsonBody(new { inputs = prompt });

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                try
                {
                    var json = JsonDocument.Parse(response.Content);
                    var generatedText = json.RootElement[0].GetProperty("generated_text").GetString();

                    // Buscar el JSON dentro del texto generado
                    var match = Regex.Match(generatedText, @"\{[\s\S]*?\}");

                    if (match.Success)
                    {
                        var jsonExtracted = match.Value;
                        var cleanJson = JsonDocument.Parse(jsonExtracted);

                        var titulo = cleanJson.RootElement.GetProperty("titulo").GetString();
                        var descripcion = cleanJson.RootElement.GetProperty("descripcion").GetString();

                        roundedTextBoxNameEvent.Texts = titulo;
                        roundedRichTextBoxDescription.Texts = descripcion;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un JSON válido en la respuesta de la IA.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al interpretar el resultado generado por IA:\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la IA.");
            }
        }
    }
}
