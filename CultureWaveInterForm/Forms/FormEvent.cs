using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{
    public partial class FormEvent : Form
    {
        private FormData formData;

        // Lista de eventos y sus descripciones
        private List<(string Nombre, string Descripcion)> eventos;

        public FormEvent(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;

            // Inicializar la lista de eventos
            eventos = new List<(string, string)>
            {
                ("Festival de Música Internacional", "Un evento que reúne a artistas de todo el mundo para compartir su música y cultura."),
                ("Exposición de Arte Contemporáneo", "Una muestra de las últimas tendencias en arte visual, con obras de artistas emergentes."),
                ("Feria de Gastronomía Global", "Un evento que celebra la diversidad culinaria mundial, con platos típicos de diferentes países."),
                ("Teatro Experimental", "Una serie de representaciones teatrales que exploran nuevas formas de expresión en el escenario."),
                ("Carnaval de la Diversidad", "Un desfile lleno de colores, música y danza para celebrar las distintas culturas del mundo."),
                ("Conferencia sobre Innovación Cultural", "Un espacio para discutir nuevas tendencias en la industria cultural y su impacto global.")
            };
        }

        private void roundedButtonGenerateIA_Click(object sender, EventArgs e)
        {
            var eventoAleatorio = eventos[new Random().Next(eventos.Count)];

            // Depuración: Verifica si el evento aleatorio se ha seleccionado correctamente
            MessageBox.Show($"Evento seleccionado: {eventoAleatorio.Nombre}");

            // Usar la propiedad correcta 'Texts' en lugar de 'Text'
            roundedTextBoxNameEvent.Texts = eventoAleatorio.Nombre;
            roundedTextBoxDescription.Texts = eventoAleatorio.Descripcion;
        }
    }
}
