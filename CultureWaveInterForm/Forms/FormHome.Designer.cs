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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridViewEvents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.dataGridViewEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEvents.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEvents.ColumnHeadersHeight = 52;
            this.dataGridViewEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.description,
            this.startDate,
            this.endDate,
            this.SpaceName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEvents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEvents.EnableHeadersVisualStyles = false;
            this.dataGridViewEvents.Location = new System.Drawing.Point(16, 69);
            this.dataGridViewEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewEvents.MultiSelect = false;
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.RowHeadersVisible = false;
            this.dataGridViewEvents.RowHeadersWidth = 51;
            this.dataGridViewEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvents.Size = new System.Drawing.Size(1323, 277);
            this.dataGridViewEvents.TabIndex = 5;
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.dataGridViewBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewBookings.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReserve,
            this.idEvent,
            this.reserveDate,
            this.EventName,
            this.SpaceNameBooking,
            this.SeatInfo,
            this.Users});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBookings.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBookings.EnableHeadersVisualStyles = false;
            this.dataGridViewBookings.Location = new System.Drawing.Point(21, 405);
            this.dataGridViewBookings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewBookings.MultiSelect = false;
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.RowHeadersVisible = false;
            this.dataGridViewBookings.RowHeadersWidth = 51;
            this.dataGridViewBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookings.Size = new System.Drawing.Size(1323, 277);
            this.dataGridViewBookings.TabIndex = 5;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Nombre del Evento";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Descripción";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // startDate
            // 
            this.startDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDate.HeaderText = "Fecha Inicio";
            this.startDate.MinimumWidth = 6;
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // endDate
            // 
            this.endDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endDate.HeaderText = "Fecha Fin";
            this.endDate.MinimumWidth = 6;
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            this.endDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SpaceName
            // 
            this.SpaceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SpaceName.HeaderText = "Espacio";
            this.SpaceName.MinimumWidth = 6;
            this.SpaceName.Name = "SpaceName";
            this.SpaceName.ReadOnly = true;
            this.SpaceName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idReserve
            // 
            this.idReserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idReserve.HeaderText = "ID Reserva";
            this.idReserve.MinimumWidth = 6;
            this.idReserve.Name = "idReserve";
            this.idReserve.ReadOnly = true;
            this.idReserve.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idEvent
            // 
            this.idEvent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idEvent.HeaderText = "ID Evento";
            this.idEvent.MinimumWidth = 6;
            this.idEvent.Name = "idEvent";
            this.idEvent.ReadOnly = true;
            this.idEvent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // reserveDate
            // 
            this.reserveDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reserveDate.HeaderText = "Fecha Reserva";
            this.reserveDate.MinimumWidth = 6;
            this.reserveDate.Name = "reserveDate";
            this.reserveDate.ReadOnly = true;
            this.reserveDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EventName
            // 
            this.EventName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EventName.HeaderText = "Evento";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            this.EventName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SpaceNameBooking
            // 
            this.SpaceNameBooking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SpaceNameBooking.HeaderText = "Espacio";
            this.SpaceNameBooking.MinimumWidth = 6;
            this.SpaceNameBooking.Name = "SpaceNameBooking";
            this.SpaceNameBooking.ReadOnly = true;
            this.SpaceNameBooking.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SeatInfo
            // 
            this.SeatInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SeatInfo.HeaderText = "Ubicación Asiento";
            this.SeatInfo.MinimumWidth = 6;
            this.SeatInfo.Name = "SeatInfo";
            this.SeatInfo.ReadOnly = true;
            this.SeatInfo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Users
            // 
            this.Users.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Users.HeaderText = "Usuarios";
            this.Users.MinimumWidth = 6;
            this.Users.Name = "Users";
            this.Users.ReadOnly = true;
            this.Users.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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