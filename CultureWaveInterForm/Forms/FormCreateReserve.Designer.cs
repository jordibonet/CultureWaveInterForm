namespace CultureWaveInterForm.Forms
{
    partial class FormCreateReserve
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
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.comboBoxEvents = new System.Windows.Forms.ComboBox();
            this.comboBoxRow = new System.Windows.Forms.ComboBox();
            this.labelSeats = new System.Windows.Forms.Label();
            this.comboBoxNumSeat = new System.Windows.Forms.ComboBox();
            this.roundedButtonCreate = new CultureWave_Form.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelEvents.Location = new System.Drawing.Point(50, 143);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(85, 24);
            this.labelEvents.TabIndex = 29;
            this.labelEvents.Text = "Eventos";
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelNameUser.Location = new System.Drawing.Point(50, 41);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(160, 24);
            this.labelNameUser.TabIndex = 27;
            this.labelNameUser.Text = "Nombre usuario";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(54, 93);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(401, 28);
            this.comboBoxUsers.TabIndex = 31;
            // 
            // comboBoxEvents
            // 
            this.comboBoxEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxEvents.FormattingEnabled = true;
            this.comboBoxEvents.Location = new System.Drawing.Point(54, 186);
            this.comboBoxEvents.Name = "comboBoxEvents";
            this.comboBoxEvents.Size = new System.Drawing.Size(398, 28);
            this.comboBoxEvents.TabIndex = 32;
            this.comboBoxEvents.SelectedIndexChanged += new System.EventHandler(this.comboBoxEvents_SelectedIndexChanged);
            // 
            // comboBoxRow
            // 
            this.comboBoxRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxRow.FormattingEnabled = true;
            this.comboBoxRow.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBoxRow.Location = new System.Drawing.Point(54, 288);
            this.comboBoxRow.Name = "comboBoxRow";
            this.comboBoxRow.Size = new System.Drawing.Size(196, 28);
            this.comboBoxRow.TabIndex = 34;
            // 
            // labelSeats
            // 
            this.labelSeats.AutoSize = true;
            this.labelSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelSeats.Location = new System.Drawing.Point(50, 245);
            this.labelSeats.Name = "labelSeats";
            this.labelSeats.Size = new System.Drawing.Size(90, 24);
            this.labelSeats.TabIndex = 33;
            this.labelSeats.Text = "Asientos";
            // 
            // comboBoxNumSeat
            // 
            this.comboBoxNumSeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxNumSeat.FormattingEnabled = true;
            this.comboBoxNumSeat.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.comboBoxNumSeat.Location = new System.Drawing.Point(256, 288);
            this.comboBoxNumSeat.Name = "comboBoxNumSeat";
            this.comboBoxNumSeat.Size = new System.Drawing.Size(196, 28);
            this.comboBoxNumSeat.TabIndex = 35;
            // 
            // roundedButtonCreate
            // 
            this.roundedButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonCreate.FlatAppearance.BorderSize = 0;
            this.roundedButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonCreate.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonCreate.Location = new System.Drawing.Point(178, 362);
            this.roundedButtonCreate.Name = "roundedButtonCreate";
            this.roundedButtonCreate.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonCreate.TabIndex = 36;
            this.roundedButtonCreate.Text = "Reservar";
            this.roundedButtonCreate.UseVisualStyleBackColor = false;
            this.roundedButtonCreate.Click += new System.EventHandler(this.roundedButtonCreate_Click);
            // 
            // FormCreateReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 441);
            this.Controls.Add(this.roundedButtonCreate);
            this.Controls.Add(this.comboBoxNumSeat);
            this.Controls.Add(this.comboBoxRow);
            this.Controls.Add(this.labelSeats);
            this.Controls.Add(this.comboBoxEvents);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.labelNameUser);
            this.Name = "FormCreateReserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateReserve";
            this.Load += new System.EventHandler(this.FormCreateReserve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.ComboBox comboBoxEvents;
        private System.Windows.Forms.ComboBox comboBoxRow;
        private System.Windows.Forms.Label labelSeats;
        private System.Windows.Forms.ComboBox comboBoxNumSeat;
        private CultureWave_Form.Controls.RoundedButton roundedButtonCreate;
    }
}