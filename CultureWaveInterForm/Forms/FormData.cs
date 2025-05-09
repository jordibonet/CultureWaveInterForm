using CultureWaveInterForm.Models;
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
        public FormCreateSpace formCreateEditSpace;
        public FormUser formUser;
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
        }

        /// <summary>
        /// Creamos instancias de los formularios dentro de formTypes y lo guardamos en allForms.
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
                typeof(FormExit)
            };

            foreach (var formType in formTypes)
            {
                var formInstance = (Form)Activator.CreateInstance(formType, this);
                allForms.Add(formInstance);
            }
        }

        /// <summary>
        /// Agregamos los paneles del diseño a una lista de paneles.
        /// </summary>
        private void InitializePanels()
        {
            allPanels.Add(panelHome);
            allPanels.Add(panelEvent);
            allPanels.Add(panelReserve);
            allPanels.Add(panelSpace);
            allPanels.Add(panelUser);
            allPanels.Add(panelExit);
        }

        /// <summary>
        /// Agregamos el nombre del usuario y su rol para mostrar arriba a la derecha.
        /// </summary>
        private void loadLabelsUser()
        {
            // Asignar el nombre del usuario
            if (labelUsername != null)
            {
                labelUsername.Text = _usuarioAutenticado.name ?? "Desconocido";
            }

            // Asignar el nombre del rol según el valor numérico
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
        /// Deshabilitar acceso a gestión de usuarios a usuarios que no pueden gestionar datos de usuarios.
        /// </summary>
        private void DisableUserAccess()
        {
            // Deshabilitar el acceso al panel de usuarios
            pictureBoxUser.Enabled = false;
            labelUser.Enabled = false;
        }

        /// <summary>
        /// Recorre todos los paneles de la lista y establece el color de fondo para cada uno de ellos.
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
        /// Cambia de color del fondo de los paneles.
        /// </summary>
        /// <param name="panel"></param>
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
        /// Metodo para cargar los formularios dentro del panel
        /// </summary>
        /// <param name="childFormName">Le pasamos el nombre del panel que queremos agregar</param>
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

        /// <summary>
        /// Cuando se cierre la aplicación que se cierre la APP.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormData_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Abrir el form dentro del panel.
        /// </summary>
        /// <param name="formName">Pasamos el nombre del panel que queremos abrir</param>
        private void OpenPanel(String formName)
        {
            LoadFormIntoPanel("Form" + formName);
            ChangePanelBackgroudColor();
            Panel targetPanel = allPanels.FirstOrDefault(p => p.Name == "panel" + formName);
            HighlightPanel(targetPanel);
        }

        /// <summary>
        /// Si le da click a la imagen de Home abre el panel "Home"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            OpenPanel("Home");
        }

        /// <summary>
        /// Si le da click al label de Home abre el panel "Home"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelHome_Click(object sender, EventArgs e)
        {
            OpenPanel("Home");
        }

        /// <summary>
        /// Si le da click a la imagen de Event abre el panel "Event"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxEvent_Click(object sender, EventArgs e)
        {
            OpenPanel("Event");
        }

        /// <summary>
        /// Si le da click al label de Eventabre el panel "Event"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelEvents_Click(object sender, EventArgs e)
        {
            OpenPanel("Event");
        }

        /// <summary>
        /// Si le da click a la imagen de Reserve abre el panel "Reserve"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxReserve_Click(object sender, EventArgs e)
        {
            OpenPanel("Reserve");
        }

        /// <summary>
        /// Si le da click al label de Reserve abre el panel "Reserve"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelReserve_Click(object sender, EventArgs e)
        {
            OpenPanel("Reserve");
        }

        /// <summary>
        /// Si le da click a la imagen de Space abre el panel "Space"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxSpace_Click(object sender, EventArgs e)
        {
            OpenPanel("Space");
        }

        /// <summary>
        /// Si le da click al label de Space abre el panel "Space"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelSpace_Click(object sender, EventArgs e)
        {
            OpenPanel("Space");
        }

        /// <summary>
        /// Si le da click a la imagen de User abre el panel "User"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxUser_Click(object sender, EventArgs e)
        {
            OpenPanel("User");
        }

        /// <summary>
        /// Si le da click al label de User abre el panel "User"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelUser_Click(object sender, EventArgs e)
        {
            OpenPanel("User");
        }

        /// <summary>
        /// Si le da click a la imagen de Exit abre el panel "Exit"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            OpenPanel("Exit");
        }

        /// <summary>
        /// Si le da click al label de Exit abre el panel "Exit"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelExit_Click(object sender, EventArgs e)
        {
            OpenPanel("Exit");
        }
    }
}
