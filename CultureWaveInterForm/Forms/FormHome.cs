using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{ 

    public partial class FormHome : Form
    {
        FormData formData;
        public FormHome(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;
        }
    }
}
