using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using CultureWave_Form.Forms;

namespace CultureWave_Form
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            FormData formData = new FormData();
            formData.LoadFormIntoPanel("FormCreateEditSpace");
            formData.Show();
            this.Hide();
        }
    }
}
