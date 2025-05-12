using CultureWaveInterForm.Forms;
using CultureWaveInterForm.Models;
using CultureWaveInterForm.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{
    public partial class FormData : Form
    {
        public FormHome formHome;
        public FormEvent formEvent;
        public FormReserve formReserve;
        public FormSpace formSpace;
        public FormCreateSpace formCreateEditSpace;
        public FormUser formUser;
        public FormTicketing formTicketing;  // Asegúrate de que esta variable esté definida
        public FormExit formExit;

        private List<Form> allForms = new List<Form>();
        private List<Panel> allPanels = new List<Panel>();
        private user _usuarioAutenticado;

        public FormData(user usuario)
        {
            InitializeComponent();
            this.FormClosing += FormData_FormClosing;
            InitializeForms();
            InitializePanels();
            _usuarioAutenticado = usuario;
            loadLabelsUser();

            LanguageManager.LoadLanguage += UpdateLanguage;
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            labelHome.Text = LanguageManager.GetString("labelHome");
            labelEvents.Text = LanguageManager.GetString("labelEvents");
            labelReserves.Text = LanguageManager.GetString("labelReserves");
            labelSpace.Text = LanguageManager.GetString("labelSpace");
            labelUser.Text = LanguageManager.GetString("labelUser");
            labelTicket.Text = LanguageManager.GetString("labelTicket");
            labelExit.Text = LanguageManager.GetString("labelExit");
        }

        /// <summary>
        /// Inicializa los formularios y los guarda en allForms.
        /// </summary>
        private void InitializeForms()
        {
            var formTypes = new List<Type>
            {
                typeof(FormHome),
                typeof(FormEvent),
                typeof(FormReserve),
                typeof(FormSpace),
                typeof(FormCreateSpace),
                typeof(FormUser),
                typeof(FormTicketing),  // Asegúrate de que FormTicketing esté en la lista
                typeof(FormExit)
            };

            foreach (var formType in formTypes)
            {
                var formInstance = (Form)Activator.CreateInstance(formType, this);
                allForms.Add(formInstance);
            }
        }

        /// <summary>
        /// Inicializa los paneles y los agrega a la lista allPanels.
        /// </summary>
        private void InitializePanels()
        {
            allPanels.Add(panelHome);
            allPanels.Add(panelEvent);
            allPanels.Add(panelReserve);
            allPanels.Add(panelSpace);
            allPanels.Add(panelUser);
            allPanels.Add(panelTicketing);  // Asegúrate de que 'panelTicketing' esté en la lista
            allPanels.Add(panelExit);
        }

        /// <summary>
        /// Carga el nombre del usuario y su rol.
        /// </summary>
        private void loadLabelsUser()
        {
            if (labelUsername != null)
            {
                labelUsername.Text = _usuarioAutenticado.name ?? "Desconocido";
            }

            if (labelRolUser != null)
            {
                switch (_usuarioAutenticado.rol)
                {
                    case 1:
                        labelRolUser.Text = "Superadministrador";
                        break;
                    case 2:
                        labelRolUser.Text = "Organizador de eventos";
                        DisableUserAccess();
                        break;
                    default:
                        labelRolUser.Text = "Desconocido";
                        break;
                }
            }
        }

        /// <summary>
        /// Deshabilita el acceso al panel de usuarios.
        /// </summary>
        private void DisableUserAccess()
        {
            pictureBoxUser.Enabled = false;
            labelUser.Enabled = false;
        }

        /// <summary>
        /// Cambia el color de fondo de todos los paneles.
        /// </summary>
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

        /// <summary>
        /// Resalta el panel de destino.
        /// </summary>
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

        /// <summary>
        /// Carga el formulario dentro del panel correspondiente.
        /// </summary>
        public void LoadFormIntoPanel(string formName)
        {
            Form childForm = allForms.FirstOrDefault(f => f.GetType().Name == formName); // Busca el formulario por su tipo.

            if (childForm != null)
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
                MessageBox.Show("Form no encontrado");
            }
        }

        /// <summary>
        /// Cuando se cierra el formulario, cierra la aplicación.
        /// </summary>
        private void FormData_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Abre el formulario y resalta el panel correspondiente.
        /// </summary>
        private void OpenPanel(string formName)
        {
            LoadFormIntoPanel("Form" + formName); // Carga el formulario
            ChangePanelBackgroudColor(); // Cambia el color de fondo de los paneles

            // Busca el panel correspondiente y lo resalta
            Panel targetPanel = allPanels.FirstOrDefault(p => p.Name == "panel" + formName);

            if (targetPanel != null)
            {
                HighlightPanel(targetPanel);
            }
            else
            {
                MessageBox.Show("Panel no encontrado: " + "panel" + formName);  // Muestra un mensaje si el panel no se encuentra
            }
        }

        /// <summary>
        /// Si se da click en la imagen de 'Home', abre el panel 'Home'.
        /// </summary>
        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            OpenPanel("Home");
        }

        /// <summary>
        /// Si se da click en el label de 'Home', abre el panel 'Home'.
        /// </summary>
        private void labelHome_Click(object sender, EventArgs e)
        {
            OpenPanel("Home");
        }

        /// <summary>
        /// Si se da click en la imagen de 'Event', abre el panel 'Event'.
        /// </summary>
        private void pictureBoxEvent_Click(object sender, EventArgs e)
        {
            OpenPanel("Event");
        }

        /// <summary>
        /// Si se da click en el label de 'Event', abre el panel 'Event'.
        /// </summary>
        private void labelEvents_Click(object sender, EventArgs e)
        {
            OpenPanel("Event");
        }

        /// <summary>
        /// Si se da click en la imagen de 'Reserve', abre el panel 'Reserve'.
        /// </summary>
        private void pictureBoxReserve_Click(object sender, EventArgs e)
        {
            OpenPanel("Reserve");
        }

        /// <summary>
        /// Si se da click en el label de 'Reserve', abre el panel 'Reserve'.
        /// </summary>
        private void labelReserve_Click(object sender, EventArgs e)
        {
            OpenPanel("Reserve");
        }

        /// <summary>
        /// Si se da click en la imagen de 'Space', abre el panel 'Space'.
        /// </summary>
        private void pictureBoxSpace_Click(object sender, EventArgs e)
        {
            OpenPanel("Space");
        }

        /// <summary>
        /// Si se da click en el label de 'Space', abre el panel 'Space'.
        /// </summary>
        private void labelSpace_Click(object sender, EventArgs e)
        {
            OpenPanel("Space");
        }

        /// <summary>
        /// Si se da click en la imagen de 'User', abre el panel 'User'.
        /// </summary>
        private void pictureBoxUser_Click(object sender, EventArgs e)
        {
            OpenPanel("User");
        }

        /// <summary>
        /// Si se da click en el label de 'User', abre el panel 'User'.
        /// </summary>
        private void labelUser_Click(object sender, EventArgs e)
        {
            OpenPanel("User");
        }

        /// <summary>
        /// Si se da click en la imagen de 'Exit', abre el panel 'Exit'.
        /// </summary>
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            OpenPanel("Exit");
        }

        /// <summary>
        /// Si se da click en el label de 'Exit', abre el panel 'Exit'.
        /// </summary>
        private void labelExit_Click(object sender, EventArgs e)
        {
            OpenPanel("Exit");
        }

        /// <summary>
        /// Si se da click en el label de 'Ticket', abre el panel 'Ticket'.
        /// </summary>
        private void labelTicket_Click(object sender, EventArgs e)
        {
            OpenPanel("Ticketing");
        }

        /// <summary>
        /// Si se da click en la imagen de 'Ticket', abre el panel 'Ticket'.
        /// </summary>
        private void pictureBoxTicket_Click(object sender, EventArgs e)
        {
            OpenPanel("Ticketing");
        }
    }
}
