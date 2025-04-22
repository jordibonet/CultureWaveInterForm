using System;
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
    public partial class FormUser : Form
    {
        FormData formData;
        public FormUser(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;
        }

        private void roundedButtonCreate_Click(object sender, EventArgs e)
        {
            FormCreateEditUser formCreateEditUser = new FormCreateEditUser();
            formCreateEditUser.ShowDialog();
        }
    }
}
