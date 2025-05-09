﻿using System;
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
    public partial class FormExit : Form
    {
        FormData formData;
        public FormExit(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;
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
    }
}
