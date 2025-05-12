using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CultureWaveInterForm.Utils;

namespace CultureWave_Form.Forms
{
    public partial class FormExit : Form
    {
        FormData formData;
        public FormExit(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;

            LanguageManager.LoadLanguage += UpdateLanguage;

        }

        private void UpdateLanguage()
        {
            labelExit.Text = LanguageManager.GetString("labelExit");
            labelLogOut.Text = LanguageManager.GetString("labelLogOut");
            roundedButtonExit.Text = LanguageManager.GetString("roundedButtonExit");
            roundedButtonLogOut.Text = LanguageManager.GetString("roundedButtonLogOut");
        }

        /// <summary>
        /// Este botón cierra la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundedButtonExit_Click(object sender, EventArgs e)
        {
            formData.Close();
        }

        /// <summary>
        /// Este botón cierra sesión del usuario y te devuelve al LogIn.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundedButtonLogOut_Click(object sender, EventArgs e)
        {
            formData.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void pictureBoxSpanish_Click(object sender, EventArgs e)
        {
            LanguageManager.ChangeLanguage("es");
        }

        private void pictureBoxCatalan_Click(object sender, EventArgs e)
        {
            LanguageManager.ChangeLanguage("ca");
        }

        private void pictureBoxEnglish_Click(object sender, EventArgs e)
        {
            LanguageManager.ChangeLanguage("en");
        }
    }
}
