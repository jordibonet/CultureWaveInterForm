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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // labelActiveEvents
            // 
            this.labelActiveEvents.AutoSize = true;
            this.labelActiveEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelActiveEvents.Location = new System.Drawing.Point(12, 18);
            this.labelActiveEvents.Name = "labelActiveEvents";
            this.labelActiveEvents.Size = new System.Drawing.Size(275, 24);
            this.labelActiveEvents.TabIndex = 2;
            this.labelActiveEvents.Text = "EVENTOS PROGRAMADOS";
            // 
            // labelRecentReservations
            // 
            this.labelRecentReservations.AutoSize = true;
            this.labelRecentReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelRecentReservations.Location = new System.Drawing.Point(12, 294);
            this.labelRecentReservations.Name = "labelRecentReservations";
            this.labelRecentReservations.Size = new System.Drawing.Size(242, 24);
            this.labelRecentReservations.TabIndex = 3;
            this.labelRecentReservations.Text = "RESERVAS RECIENTES";
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.Size = new System.Drawing.Size(992, 225);
            this.dataGridViewEvents.TabIndex = 4;
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.dataGridViewBookings.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(12, 328);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.Size = new System.Drawing.Size(992, 225);
            this.dataGridViewBookings.TabIndex = 5;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 565);
            this.Controls.Add(this.dataGridViewBookings);
            this.Controls.Add(this.dataGridViewEvents);
            this.Controls.Add(this.labelRecentReservations);
            this.Controls.Add(this.labelActiveEvents);
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
    }
}