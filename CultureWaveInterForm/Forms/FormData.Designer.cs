using System.Drawing;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{
    partial class FormData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCultureWave = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelReserve = new System.Windows.Forms.Label();
            this.labelSpace = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelRolUser = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.panelEvent = new System.Windows.Forms.Panel();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.panelSpace = new System.Windows.Forms.Panel();
            this.pictureBoxSpace = new System.Windows.Forms.PictureBox();
            this.panelReserve = new System.Windows.Forms.Panel();
            this.pictureBoxReserve = new System.Windows.Forms.PictureBox();
            this.panelExit = new System.Windows.Forms.Panel();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.panelEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.panelSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpace)).BeginInit();
            this.panelReserve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReserve)).BeginInit();
            this.panelExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCultureWave
            // 
            this.labelCultureWave.AutoSize = true;
            this.labelCultureWave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelCultureWave.Location = new System.Drawing.Point(73, 31);
            this.labelCultureWave.Name = "labelCultureWave";
            this.labelCultureWave.Size = new System.Drawing.Size(144, 20);
            this.labelCultureWave.TabIndex = 1;
            this.labelCultureWave.Text = "CULTUREWAVE";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelHome.Location = new System.Drawing.Point(112, 27);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(66, 24);
            this.labelHome.TabIndex = 3;
            this.labelHome.Text = "Home";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.labelEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelEvents.Location = new System.Drawing.Point(112, 27);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(85, 24);
            this.labelEvents.TabIndex = 4;
            this.labelEvents.Text = "Eventos";
            this.labelEvents.Click += new System.EventHandler(this.labelEvents_Click);
            // 
            // labelReserve
            // 
            this.labelReserve.AutoSize = true;
            this.labelReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.labelReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelReserve.Location = new System.Drawing.Point(112, 27);
            this.labelReserve.Name = "labelReserve";
            this.labelReserve.Size = new System.Drawing.Size(96, 24);
            this.labelReserve.TabIndex = 5;
            this.labelReserve.Text = "Reservas";
            this.labelReserve.Click += new System.EventHandler(this.labelReserve_Click);
            // 
            // labelSpace
            // 
            this.labelSpace.AutoSize = true;
            this.labelSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.labelSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelSpace.Location = new System.Drawing.Point(112, 26);
            this.labelSpace.Name = "labelSpace";
            this.labelSpace.Size = new System.Drawing.Size(95, 24);
            this.labelSpace.TabIndex = 6;
            this.labelSpace.Text = "Espacios";
            this.labelSpace.Click += new System.EventHandler(this.labelSpace_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelUser.Location = new System.Drawing.Point(110, 27);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(91, 24);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "Usuarios";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelExit.Location = new System.Drawing.Point(110, 29);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(51, 24);
            this.labelExit.TabIndex = 8;
            this.labelExit.Text = "Salir";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // panelData
            // 
            this.panelData.Location = new System.Drawing.Point(227, 79);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1032, 604);
            this.panelData.TabIndex = 9;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelUsername.Location = new System.Drawing.Point(1023, 14);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(91, 20);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "Username";
            // 
            // labelRolUser
            // 
            this.labelRolUser.AutoSize = true;
            this.labelRolUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelRolUser.Location = new System.Drawing.Point(1023, 44);
            this.labelRolUser.Name = "labelRolUser";
            this.labelRolUser.Size = new System.Drawing.Size(79, 20);
            this.labelRolUser.TabIndex = 11;
            this.labelRolUser.Text = "Rol User";
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.panelHome.Controls.Add(this.pictureBoxHome);
            this.panelHome.Controls.Add(this.labelHome);
            this.panelHome.Location = new System.Drawing.Point(1, 114);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(220, 80);
            this.panelHome.TabIndex = 13;
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.pictureBoxHome.BackgroundImage = global::CultureWaveInterForm.Properties.Resources.home;
            this.pictureBoxHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHome.InitialImage = null;
            this.pictureBoxHome.Location = new System.Drawing.Point(33, 14);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxHome.TabIndex = 12;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            // 
            // panelEvent
            // 
            this.panelEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.panelEvent.Controls.Add(this.pictureBoxEvent);
            this.panelEvent.Controls.Add(this.labelEvents);
            this.panelEvent.Location = new System.Drawing.Point(1, 207);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(220, 80);
            this.panelEvent.TabIndex = 14;
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.pictureBoxEvent.BackgroundImage = global::CultureWaveInterForm.Properties.Resources.calendar;
            this.pictureBoxEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEvent.InitialImage = null;
            this.pictureBoxEvent.Location = new System.Drawing.Point(33, 16);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxEvent.TabIndex = 13;
            this.pictureBoxEvent.TabStop = false;
            this.pictureBoxEvent.Click += new System.EventHandler(this.pictureBoxEvent_Click);
            // 
            // panelSpace
            // 
            this.panelSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.panelSpace.Controls.Add(this.pictureBoxSpace);
            this.panelSpace.Controls.Add(this.labelSpace);
            this.panelSpace.Location = new System.Drawing.Point(1, 397);
            this.panelSpace.Name = "panelSpace";
            this.panelSpace.Size = new System.Drawing.Size(220, 80);
            this.panelSpace.TabIndex = 16;
            // 
            // pictureBoxSpace
            // 
            this.pictureBoxSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.pictureBoxSpace.BackgroundImage = global::CultureWaveInterForm.Properties.Resources.space;
            this.pictureBoxSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSpace.InitialImage = null;
            this.pictureBoxSpace.Location = new System.Drawing.Point(33, 17);
            this.pictureBoxSpace.Name = "pictureBoxSpace";
            this.pictureBoxSpace.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxSpace.TabIndex = 15;
            this.pictureBoxSpace.TabStop = false;
            this.pictureBoxSpace.Click += new System.EventHandler(this.pictureBoxSpace_Click);
            // 
            // panelReserve
            // 
            this.panelReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.panelReserve.Controls.Add(this.pictureBoxReserve);
            this.panelReserve.Controls.Add(this.labelReserve);
            this.panelReserve.Location = new System.Drawing.Point(1, 300);
            this.panelReserve.Name = "panelReserve";
            this.panelReserve.Size = new System.Drawing.Size(220, 80);
            this.panelReserve.TabIndex = 15;
            // 
            // pictureBoxReserve
            // 
            this.pictureBoxReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.pictureBoxReserve.BackgroundImage = global::CultureWaveInterForm.Properties.Resources.reserved;
            this.pictureBoxReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxReserve.InitialImage = null;
            this.pictureBoxReserve.Location = new System.Drawing.Point(33, 17);
            this.pictureBoxReserve.Name = "pictureBoxReserve";
            this.pictureBoxReserve.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxReserve.TabIndex = 14;
            this.pictureBoxReserve.TabStop = false;
            this.pictureBoxReserve.Click += new System.EventHandler(this.pictureBoxReserve_Click);
            // 
            // panelExit
            // 
            this.panelExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.panelExit.Controls.Add(this.labelExit);
            this.panelExit.Controls.Add(this.pictureBoxExit);
            this.panelExit.Location = new System.Drawing.Point(3, 587);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(220, 80);
            this.panelExit.TabIndex = 18;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.pictureBoxExit.BackgroundImage = global::CultureWaveInterForm.Properties.Resources.exit;
            this.pictureBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxExit.InitialImage = null;
            this.pictureBoxExit.Location = new System.Drawing.Point(31, 19);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxExit.TabIndex = 15;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.panelUser.Controls.Add(this.pictureBoxUser);
            this.panelUser.Controls.Add(this.labelUser);
            this.panelUser.Location = new System.Drawing.Point(3, 494);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(220, 80);
            this.panelUser.TabIndex = 17;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.pictureBoxUser.BackgroundImage = global::CultureWaveInterForm.Properties.Resources.user;
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUser.InitialImage = null;
            this.pictureBoxUser.Location = new System.Drawing.Point(31, 15);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxUser.TabIndex = 14;
            this.pictureBoxUser.TabStop = false;
            this.pictureBoxUser.Click += new System.EventHandler(this.pictureBoxUser_Click);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.pictureBoxBackground.Location = new System.Drawing.Point(-4, 79);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(227, 603);
            this.pictureBoxBackground.TabIndex = 2;
            this.pictureBoxBackground.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.panelEvent);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panelSpace);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.labelRolUser);
            this.Controls.Add(this.panelReserve);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.pictureBoxBackground);
            this.Controls.Add(this.labelCultureWave);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormData";
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.panelEvent.ResumeLayout(false);
            this.panelEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.panelSpace.ResumeLayout(false);
            this.panelSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpace)).EndInit();
            this.panelReserve.ResumeLayout(false);
            this.panelReserve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReserve)).EndInit();
            this.panelExit.ResumeLayout(false);
            this.panelExit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelCultureWave;
        private PictureBox pictureBoxBackground;
        private Label labelHome;
        private Label labelEvents;
        private Label labelReservations;
        private Label labelSpaces;
        private Label labelUsers;
        private Label labelExits;
        private Panel panelEvent;
        private Label labelUsername;
        private Label labelRolUser;
        private Panel panelData;
        private PictureBox pictureBoxHome;
        private PictureBox pictureBoxEvent;
        private PictureBox pictureBoxSpace;
        private PictureBox pictureBoxReserve;
        private PictureBox pictureBoxExit;
        private PictureBox pictureBoxUser;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label labelReserve;
        private Label labelSpace;
        private Label labelUser;
        private Label labelExit;
        private Panel panelHome;
        private Panel panelSpace;
        private Panel panelReserve;
        private Panel panelExit;
        private Panel panelUser;
    }
}