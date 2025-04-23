using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CultureWave_Form.Forms
{
    public partial class FormData : Form
    {
        public FormHome formHome;
        public FormEvent formEvent;
        public FormReserve formReserve;
        public FormSpace formSpace;
        public FormCreateEditSpace formCreateEditSpace;
        public FormUser formUser;
        public FormExit formExit;



        private List<Form> allForms = new List<Form>();
        private List<Panel> allPanels = new List<Panel>();



        public FormData()
        {
            InitializeComponent();
            this.FormClosing += FormData_FormClosing;
            InitializeForms();
            InitializePanels();
        }

        private void InitializeForms()
        {
            var formTypes = new List<Type>
            {
                typeof(FormHome),
                typeof(FormEvent),
                typeof(FormReserve),
                typeof(FormSpace),
                typeof(FormCreateEditSpace),
                typeof(FormUser),
                typeof(FormExit)
            };

            foreach (var formType in formTypes)
            {
                var formInstance = (Form)Activator.CreateInstance(formType, this);
                allForms.Add(formInstance);
            }

        }

        private void InitializePanels()
        {
            allPanels.Add(panelHome);
            allPanels.Add(panelEvent);
            allPanels.Add(panelReserve);
            allPanels.Add(panelSpace);
            allPanels.Add(panelUser);
            allPanels.Add(panelExit);
        }

        private void ChangePanelBackgroudColor()
        {
            foreach (Panel panel in allPanels)
            {
                panel.BackColor = Color.FromArgb(255, 248, 241);

                foreach (Control control in panel.Controls)
                {
                    if (control is Label)
                    {
                        control.BackColor = Color.FromArgb(255, 248, 241);
                    }
                    else if (control is PictureBox)
                    {
                        control.BackColor = Color.FromArgb(255, 248, 241);
                    }
                }

            }

        }

        private void HighlightPanel(Panel panel)
        {
            panel.BackColor = Color.FromArgb(228, 179, 99);

            foreach (Control control in panel.Controls)
            {
                if (control is Label)
                {
                    control.BackColor = Color.FromArgb(228, 179, 99);
                }
                else if (control is PictureBox)
                {
                    control.BackColor = Color.FromArgb(228, 179, 99);
                }
            }
        }


        public void LoadFormIntoPanel(String childFormName)
        {
            bool foundForm = false;
            Form childForm = null;

            foreach (Form form in allForms)
            {
                if (form.Name == childFormName)
                {
                    childForm = form;
                    foundForm = true;
                }

            }

            if (foundForm)
            {
                panelData.Controls.Clear();

                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                panelData.Controls.Add(childForm);
                childForm.Show();
            }
            else
            {
                MessageBox.Show("Form not found");
            }
        }

        private void FormData_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OpenPanel(String formName)
        {
            LoadFormIntoPanel("Form" + formName);
            ChangePanelBackgroudColor();
            Panel targetPanel = allPanels.FirstOrDefault(p => p.Name == "panel" + formName);
            HighlightPanel(targetPanel);
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            OpenPanel("Home");
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            OpenPanel("Home");
        }

        private void pictureBoxEvent_Click(object sender, EventArgs e)
        {
            OpenPanel("Event");
        }

        private void labelEvents_Click(object sender, EventArgs e)
        {
            OpenPanel("Event");
        }

        private void pictureBoxReserve_Click(object sender, EventArgs e)
        {
            OpenPanel("Reserve");
        }

        private void labelReserve_Click(object sender, EventArgs e)
        {
            OpenPanel("Reserve");
        }

        private void pictureBoxSpace_Click(object sender, EventArgs e)
        {
            OpenPanel("Space");
        }

        private void labelSpace_Click(object sender, EventArgs e)
        {
            OpenPanel("Space");
        }

        private void pictureBoxUser_Click(object sender, EventArgs e)
        {
            OpenPanel("User");
        }

        private void labelUser_Click(object sender, EventArgs e)
        {
            OpenPanel("User");
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            OpenPanel("Exit");
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            OpenPanel("Exit");
        }
    }
}
