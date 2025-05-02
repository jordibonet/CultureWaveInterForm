using System.Drawing;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{
    partial class FormHome
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
            this.labelActiveEvents = new System.Windows.Forms.Label();
            this.labelRecentReservations = new System.Windows.Forms.Label();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpaceNameBooking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Users = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // labelActiveEvents
            // 
            this.labelActiveEvents.AutoSize = true;
            this.labelActiveEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelActiveEvents.Location = new System.Drawing.Point(16, 22);
            this.labelActiveEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActiveEvents.Name = "labelActiveEvents";
            this.labelActiveEvents.Size = new System.Drawing.Size(343, 29);
            this.labelActiveEvents.TabIndex = 2;
            this.labelActiveEvents.Text = "EVENTOS PROGRAMADOS";
            // 
            // labelRecentReservations
            // 
            this.labelRecentReservations.AutoSize = true;
            this.labelRecentReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelRecentReservations.Location = new System.Drawing.Point(16, 362);
            this.labelRecentReservations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecentReservations.Name = "labelRecentReservations";
            this.labelRecentReservations.Size = new System.Drawing.Size(149, 29);
            this.labelRecentReservations.TabIndex = 3;
            this.labelRecentReservations.Text = "RESERVAS";
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.description,
            this.startDate,
            this.endDate,
            this.SpaceName});
            this.dataGridViewEvents.Location = new System.Drawing.Point(16, 69);
            this.dataGridViewEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.RowHeadersWidth = 51;
            this.dataGridViewEvents.Size = new System.Drawing.Size(1323, 277);
            this.dataGridViewEvents.TabIndex = 4;
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.dataGridViewBookings.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReserve,
            this.idEvent,
            this.reserveDate,
            this.EventName,
            this.SpaceNameBooking,
            this.SeatInfo,
            this.Users});
            this.dataGridViewBookings.Location = new System.Drawing.Point(16, 404);
            this.dataGridViewBookings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.RowHeadersWidth = 51;
            this.dataGridViewBookings.Size = new System.Drawing.Size(1323, 277);
            this.dataGridViewBookings.TabIndex = 5;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre del Evento";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // description
            // 
            this.description.HeaderText = "Descripción";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 125;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "Fecha Inicio";
            this.startDate.MinimumWidth = 6;
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Width = 125;
            // 
            // endDate
            // 
            this.endDate.HeaderText = "Fecha Fin";
            this.endDate.MinimumWidth = 6;
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            this.endDate.Width = 125;
            // 
            // SpaceName
            // 
            this.SpaceName.HeaderText = "Espacio";
            this.SpaceName.MinimumWidth = 6;
            this.SpaceName.Name = "SpaceName";
            this.SpaceName.ReadOnly = true;
            this.SpaceName.Width = 125;
            // 
            // idReserve
            // 
            this.idReserve.HeaderText = "ID Reserva";
            this.idReserve.MinimumWidth = 6;
            this.idReserve.Name = "idReserve";
            this.idReserve.ReadOnly = true;
            this.idReserve.Width = 125;
            // 
            // idEvent
            // 
            this.idEvent.HeaderText = "ID Evento";
            this.idEvent.MinimumWidth = 6;
            this.idEvent.Name = "idEvent";
            this.idEvent.ReadOnly = true;
            this.idEvent.Width = 125;
            // 
            // reserveDate
            // 
            this.reserveDate.HeaderText = "Fecha Reserva";
            this.reserveDate.MinimumWidth = 6;
            this.reserveDate.Name = "reserveDate";
            this.reserveDate.ReadOnly = true;
            this.reserveDate.Width = 125;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Evento";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            this.EventName.Width = 125;
            // 
            // SpaceNameBooking
            // 
            this.SpaceNameBooking.HeaderText = "Espacio";
            this.SpaceNameBooking.MinimumWidth = 6;
            this.SpaceNameBooking.Name = "SpaceNameBooking";
            this.SpaceNameBooking.ReadOnly = true;
            this.SpaceNameBooking.Width = 125;
            // 
            // SeatInfo
            // 
            this.SeatInfo.HeaderText = "Ubicación Asiento";
            this.SeatInfo.MinimumWidth = 6;
            this.SeatInfo.Name = "SeatInfo";
            this.SeatInfo.ReadOnly = true;
            this.SeatInfo.Width = 125;
            // 
            // Users
            // 
            this.Users.HeaderText = "Usuarios";
            this.Users.MinimumWidth = 6;
            this.Users.Name = "Users";
            this.Users.ReadOnly = true;
            this.Users.Width = 125;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1355, 695);
            this.Controls.Add(this.dataGridViewBookings);
            this.Controls.Add(this.dataGridViewEvents);
            this.Controls.Add(this.labelRecentReservations);
            this.Controls.Add(this.labelActiveEvents);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelActiveEvents;
        private Label labelRecentReservations;
        private DataGridView dataGridViewEvents;
        private DataGridView dataGridViewBookings;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn startDate;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewTextBoxColumn SpaceName;
        private DataGridViewTextBoxColumn idReserve;
        private DataGridViewTextBoxColumn idEvent;
        private DataGridViewTextBoxColumn reserveDate;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn SpaceNameBooking;
        private DataGridViewTextBoxColumn SeatInfo;
        private DataGridViewTextBoxColumn Users;
    }
}