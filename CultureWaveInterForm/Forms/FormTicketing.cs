using CultureWave_Form.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CultureWaveInterForm.Forms
{
    public partial class FormTicketing: Form
    {
        private FormData formData;
        public FormTicketing(FormData formData)
        {
            InitializeComponent();
            this.formData = formData;
        }
    }
}
