using System.Windows.Forms;

namespace CultureWave_Form.Utils 
{
    public static class TextBoxExtensions
    {
        public static void ApplyAutoComplete(this TextBox textBox, AutoCompleteStringCollection source)
        {
            textBox.AutoCompleteCustomSource = source;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
