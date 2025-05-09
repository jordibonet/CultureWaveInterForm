using System.Windows.Forms;

namespace CultureWave_Form.Utils 
{
    public static class TextBoxExtensions
    {
        /// <summary>
        /// Metodo para autcompletar la textBox para buscar correos de los usuarios.
        /// </summary>
        /// <param name="textBox">le pasamos el texto buscado por el usuario</param>
        /// <param name="source">define el conjunto de opciones de autocompletado para el TextBox</param>
        public static void ApplyAutoComplete(this TextBox textBox, AutoCompleteStringCollection source)
        {
            textBox.AutoCompleteCustomSource = source;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
