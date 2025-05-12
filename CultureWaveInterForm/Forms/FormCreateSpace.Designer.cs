using System.Drawing;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{
    partial class FormCreateSpace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateSpace));
            this.labelNameSpace = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelFixedSeats = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.groupBoxSeats = new System.Windows.Forms.GroupBox();
            this.roundedRadioButtonYesSeats = new CultureWave_Form.Controls.RoundedRadioButton();
            this.roundedRadioButtonNoSeats = new CultureWave_Form.Controls.RoundedRadioButton();
            this.roundedButtonCreate = new CultureWave_Form.Controls.RoundedButton();
            this.roundedRadioButtonNoAvailable = new CultureWave_Form.Controls.RoundedRadioButton();
            this.roundedRadioButtonYesAvailable = new CultureWave_Form.Controls.RoundedRadioButton();
            this.roundedTextBoxCapacity = new CultureWave_Form.Controls.RoundedTextBox();
            this.roundedTextBoxNameSpace = new CultureWave_Form.Controls.RoundedTextBox();
            this.groupBoxAvailable = new System.Windows.Forms.GroupBox();
            this.groupBoxSeats.SuspendLayout();
            this.groupBoxAvailable.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNameSpace
            // 
            this.labelNameSpace.AutoSize = true;
            this.labelNameSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelNameSpace.Location = new System.Drawing.Point(12, 13);
            this.labelNameSpace.Name = "labelNameSpace";
            this.labelNameSpace.Size = new System.Drawing.Size(164, 24);
            this.labelNameSpace.TabIndex = 15;
            this.labelNameSpace.Text = "Nombre espacio";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelCapacity.Location = new System.Drawing.Point(12, 111);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(109, 24);
            this.labelCapacity.TabIndex = 17;
            this.labelCapacity.Text = "Capacidad";
            // 
            // labelFixedSeats
            // 
            this.labelFixedSeats.AutoSize = true;
            this.labelFixedSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelFixedSeats.Location = new System.Drawing.Point(8, 16);
            this.labelFixedSeats.Name = "labelFixedSeats";
            this.labelFixedSeats.Size = new System.Drawing.Size(101, 24);
            this.labelFixedSeats.TabIndex = 22;
            this.labelFixedSeats.Text = "Sillas fijas";
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelAvailable.Location = new System.Drawing.Point(6, 16);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(109, 24);
            this.labelAvailable.TabIndex = 25;
            this.labelAvailable.Text = "Disponible";
            // 
            // groupBoxSeats
            // 
            this.groupBoxSeats.Controls.Add(this.roundedRadioButtonYesSeats);
            this.groupBoxSeats.Controls.Add(this.roundedRadioButtonNoSeats);
            this.groupBoxSeats.Controls.Add(this.labelFixedSeats);
            this.groupBoxSeats.Location = new System.Drawing.Point(464, 9);
            this.groupBoxSeats.Name = "groupBoxSeats";
            this.groupBoxSeats.Size = new System.Drawing.Size(200, 96);
            this.groupBoxSeats.TabIndex = 27;
            this.groupBoxSeats.TabStop = false;
            this.groupBoxSeats.Text = "Asientos";
            // 
            // roundedRadioButtonYesSeats
            // 
            this.roundedRadioButtonYesSeats.AutoSize = true;
            this.roundedRadioButtonYesSeats.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedRadioButtonYesSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.roundedRadioButtonYesSeats.Location = new System.Drawing.Point(12, 52);
            this.roundedRadioButtonYesSeats.MinimumSize = new System.Drawing.Size(0, 18);
            this.roundedRadioButtonYesSeats.Name = "roundedRadioButtonYesSeats";
            this.roundedRadioButtonYesSeats.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.roundedRadioButtonYesSeats.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.roundedRadioButtonYesSeats.Size = new System.Drawing.Size(55, 28);
            this.roundedRadioButtonYesSeats.TabIndex = 20;
            this.roundedRadioButtonYesSeats.TabStop = true;
            this.roundedRadioButtonYesSeats.Text = "Si";
            this.roundedRadioButtonYesSeats.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedRadioButtonYesSeats.UseVisualStyleBackColor = true;
            // 
            // roundedRadioButtonNoSeats
            // 
            this.roundedRadioButtonNoSeats.AutoSize = true;
            this.roundedRadioButtonNoSeats.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedRadioButtonNoSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.roundedRadioButtonNoSeats.Location = new System.Drawing.Point(114, 52);
            this.roundedRadioButtonNoSeats.MinimumSize = new System.Drawing.Size(0, 18);
            this.roundedRadioButtonNoSeats.Name = "roundedRadioButtonNoSeats";
            this.roundedRadioButtonNoSeats.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.roundedRadioButtonNoSeats.Size = new System.Drawing.Size(64, 28);
            this.roundedRadioButtonNoSeats.TabIndex = 21;
            this.roundedRadioButtonNoSeats.TabStop = true;
            this.roundedRadioButtonNoSeats.Text = "No";
            this.roundedRadioButtonNoSeats.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedRadioButtonNoSeats.UseVisualStyleBackColor = true;
            // 
            // roundedButtonCreate
            // 
            this.roundedButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonCreate.FlatAppearance.BorderSize = 0;
            this.roundedButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonCreate.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonCreate.Location = new System.Drawing.Point(285, 235);
            this.roundedButtonCreate.Name = "roundedButtonCreate";
            this.roundedButtonCreate.Size = new System.Drawing.Size(150, 40);
            this.roundedButtonCreate.TabIndex = 26;
            this.roundedButtonCreate.Text = "Crear";
            this.roundedButtonCreate.UseVisualStyleBackColor = false;
            this.roundedButtonCreate.Click += new System.EventHandler(this.roundedButtonCreate_Click);
            // 
            // roundedRadioButtonNoAvailable
            // 
            this.roundedRadioButtonNoAvailable.AutoSize = true;
            this.roundedRadioButtonNoAvailable.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedRadioButtonNoAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.roundedRadioButtonNoAvailable.Location = new System.Drawing.Point(114, 52);
            this.roundedRadioButtonNoAvailable.MinimumSize = new System.Drawing.Size(0, 18);
            this.roundedRadioButtonNoAvailable.Name = "roundedRadioButtonNoAvailable";
            this.roundedRadioButtonNoAvailable.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.roundedRadioButtonNoAvailable.Size = new System.Drawing.Size(64, 28);
            this.roundedRadioButtonNoAvailable.TabIndex = 24;
            this.roundedRadioButtonNoAvailable.TabStop = true;
            this.roundedRadioButtonNoAvailable.Text = "No";
            this.roundedRadioButtonNoAvailable.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedRadioButtonNoAvailable.UseVisualStyleBackColor = true;
            // 
            // roundedRadioButtonYesAvailable
            // 
            this.roundedRadioButtonYesAvailable.AutoSize = true;
            this.roundedRadioButtonYesAvailable.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedRadioButtonYesAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.roundedRadioButtonYesAvailable.Location = new System.Drawing.Point(12, 52);
            this.roundedRadioButtonYesAvailable.MinimumSize = new System.Drawing.Size(0, 18);
            this.roundedRadioButtonYesAvailable.Name = "roundedRadioButtonYesAvailable";
            this.roundedRadioButtonYesAvailable.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.roundedRadioButtonYesAvailable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.roundedRadioButtonYesAvailable.Size = new System.Drawing.Size(55, 28);
            this.roundedRadioButtonYesAvailable.TabIndex = 23;
            this.roundedRadioButtonYesAvailable.TabStop = true;
            this.roundedRadioButtonYesAvailable.Text = "Si";
            this.roundedRadioButtonYesAvailable.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedRadioButtonYesAvailable.UseVisualStyleBackColor = true;
            // 
            // roundedTextBoxCapacity
            // 
            this.roundedTextBoxCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxCapacity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxCapacity.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxCapacity.BorderRadius = 20;
            this.roundedTextBoxCapacity.BorderSize = 3;
            this.roundedTextBoxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roundedTextBoxCapacity.Location = new System.Drawing.Point(13, 150);
            this.roundedTextBoxCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxCapacity.MaxLength = 43;
            this.roundedTextBoxCapacity.Multiline = false;
            this.roundedTextBoxCapacity.Name = "roundedTextBoxCapacity";
            this.roundedTextBoxCapacity.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxCapacity.PasswordChar = false;
            this.roundedTextBoxCapacity.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxCapacity.PlaceholderText = "";
            this.roundedTextBoxCapacity.Size = new System.Drawing.Size(404, 41);
            this.roundedTextBoxCapacity.TabIndex = 18;
            this.roundedTextBoxCapacity.Texts = "";
            this.roundedTextBoxCapacity.UnderlinedStyle = false;
            // 
            // roundedTextBoxNameSpace
            // 
            this.roundedTextBoxNameSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxNameSpace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxNameSpace.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxNameSpace.BorderRadius = 20;
            this.roundedTextBoxNameSpace.BorderSize = 3;
            this.roundedTextBoxNameSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roundedTextBoxNameSpace.Location = new System.Drawing.Point(13, 48);
            this.roundedTextBoxNameSpace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxNameSpace.MaxLength = 43;
            this.roundedTextBoxNameSpace.Multiline = false;
            this.roundedTextBoxNameSpace.Name = "roundedTextBoxNameSpace";
            this.roundedTextBoxNameSpace.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxNameSpace.PasswordChar = false;
            this.roundedTextBoxNameSpace.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxNameSpace.PlaceholderText = "";
            this.roundedTextBoxNameSpace.Size = new System.Drawing.Size(404, 41);
            this.roundedTextBoxNameSpace.TabIndex = 16;
            this.roundedTextBoxNameSpace.Texts = "";
            this.roundedTextBoxNameSpace.UnderlinedStyle = false;
            // 
            // groupBoxAvailable
            // 
            this.groupBoxAvailable.Controls.Add(this.labelAvailable);
            this.groupBoxAvailable.Controls.Add(this.roundedRadioButtonYesAvailable);
            this.groupBoxAvailable.Controls.Add(this.roundedRadioButtonNoAvailable);
            this.groupBoxAvailable.Location = new System.Drawing.Point(464, 111);
            this.groupBoxAvailable.Name = "groupBoxAvailable";
            this.groupBoxAvailable.Size = new System.Drawing.Size(200, 100);
            this.groupBoxAvailable.TabIndex = 28;
            this.groupBoxAvailable.TabStop = false;
            this.groupBoxAvailable.Text = "Disponibilidad";
            // 
            // FormCreateSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 304);
            this.Controls.Add(this.groupBoxAvailable);
            this.Controls.Add(this.groupBoxSeats);
            this.Controls.Add(this.roundedButtonCreate);
            this.Controls.Add(this.roundedTextBoxCapacity);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.roundedTextBoxNameSpace);
            this.Controls.Add(this.labelNameSpace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espacio";
            this.groupBoxSeats.ResumeLayout(false);
            this.groupBoxSeats.PerformLayout();
            this.groupBoxAvailable.ResumeLayout(false);
            this.groupBoxAvailable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.RoundedTextBox roundedTextBoxNameSpace;
        private Label labelNameSpace;
        private Controls.RoundedTextBox roundedTextBoxCapacity;
        private Label labelCapacity;
        private Controls.RoundedRadioButton roundedRadioButtonYesSeats;
        private Controls.RoundedRadioButton roundedRadioButtonNoSeats;
        private Label labelFixedSeats;
        private Label labelAvailable;
        private Controls.RoundedRadioButton roundedRadioButtonNoAvailable;
        private Controls.RoundedRadioButton roundedRadioButtonYesAvailable;
        private Controls.RoundedButton roundedButtonCreate;
        private GroupBox groupBoxSeats;
        private GroupBox groupBoxAvailable;
    }
}