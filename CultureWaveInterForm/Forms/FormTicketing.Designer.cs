namespace CultureWaveInterForm.Forms
{
    partial class FormTicketing
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
            this.dataGridViewTicketing = new System.Windows.Forms.DataGridView();
            this.labelTicket = new System.Windows.Forms.Label();
            this.roundedButtonCloseTicket = new CultureWave_Form.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketing)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTicketing
            // 
            this.dataGridViewTicketing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.dataGridViewTicketing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTicketing.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewTicketing.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewTicketing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTicketing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTicketing.ColumnHeadersHeight = 56;
            this.dataGridViewTicketing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTicketing.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTicketing.EnableHeadersVisualStyles = false;
            this.dataGridViewTicketing.Location = new System.Drawing.Point(12, 76);
            this.dataGridViewTicketing.MultiSelect = false;
            this.dataGridViewTicketing.Name = "dataGridViewTicketing";
            this.dataGridViewTicketing.RowHeadersVisible = false;
            this.dataGridViewTicketing.RowHeadersWidth = 51;
            this.dataGridViewTicketing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTicketing.Size = new System.Drawing.Size(992, 477);
            this.dataGridViewTicketing.TabIndex = 6;
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelTicket.Location = new System.Drawing.Point(12, 49);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(83, 24);
            this.labelTicket.TabIndex = 16;
            this.labelTicket.Text = "Soporte";
            // 
            // roundedButtonCloseTicket
            // 
            this.roundedButtonCloseTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonCloseTicket.FlatAppearance.BorderSize = 0;
            this.roundedButtonCloseTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonCloseTicket.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonCloseTicket.Location = new System.Drawing.Point(848, 12);
            this.roundedButtonCloseTicket.Name = "roundedButtonCloseTicket";
            this.roundedButtonCloseTicket.Size = new System.Drawing.Size(156, 58);
            this.roundedButtonCloseTicket.TabIndex = 17;
            this.roundedButtonCloseTicket.Text = "Cerrar Ticket";
            this.roundedButtonCloseTicket.UseVisualStyleBackColor = false;
            this.roundedButtonCloseTicket.Click += new System.EventHandler(this.roundedButtonCloseTicket_Click);
            // 
            // FormTicketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 565);
            this.Controls.Add(this.roundedButtonCloseTicket);
            this.Controls.Add(this.labelTicket);
            this.Controls.Add(this.dataGridViewTicketing);
            this.Name = "FormTicketing";
            this.Text = "FormTicketing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTicketing;
        private System.Windows.Forms.Label labelTicket;
        private CultureWave_Form.Controls.RoundedButton roundedButtonCloseTicket;
    }
}