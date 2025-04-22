using System.Drawing;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{
    partial class FormCreateEditSpace
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
            this.roundedTextBoxNameEvent = new CultureWave_Form.Controls.RoundedTextBox();
            this.labelNameSpace = new System.Windows.Forms.Label();
            this.roundedTextBoxMeters = new CultureWave_Form.Controls.RoundedTextBox();
            this.labelMeters = new System.Windows.Forms.Label();
            this.roundedRadioButtonYes = new CultureWave_Form.Controls.RoundedRadioButton();
            this.roundedRadioButtonNo = new CultureWave_Form.Controls.RoundedRadioButton();
            this.labelFixedSeats = new System.Windows.Forms.Label();
            this.roundedTextBoxNumSeatsRow = new CultureWave_Form.Controls.RoundedTextBox();
            this.labelNumSeatsRow = new System.Windows.Forms.Label();
            this.roundedTextBoxNumRow = new CultureWave_Form.Controls.RoundedTextBox();
            this.labelNumRow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roundedTextBoxNameEvent
            // 
            this.roundedTextBoxNameEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxNameEvent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxNameEvent.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxNameEvent.BorderRadius = 20;
            this.roundedTextBoxNameEvent.BorderSize = 3;
            this.roundedTextBoxNameEvent.Font = new System.Drawing.Font("Nunito", 12F);
            this.roundedTextBoxNameEvent.Location = new System.Drawing.Point(47, 218);
            this.roundedTextBoxNameEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxNameEvent.Multiline = false;
            this.roundedTextBoxNameEvent.Name = "roundedTextBoxNameEvent";
            this.roundedTextBoxNameEvent.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxNameEvent.PasswordChar = false;
            this.roundedTextBoxNameEvent.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxNameEvent.PlaceholderText = "";
            this.roundedTextBoxNameEvent.Size = new System.Drawing.Size(404, 43);
            this.roundedTextBoxNameEvent.TabIndex = 16;
            this.roundedTextBoxNameEvent.Texts = "";
            this.roundedTextBoxNameEvent.UnderlinedStyle = false;
            // 
            // labelNameSpace
            // 
            this.labelNameSpace.AutoSize = true;
            this.labelNameSpace.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelNameSpace.Location = new System.Drawing.Point(46, 179);
            this.labelNameSpace.Name = "labelNameSpace";
            this.labelNameSpace.Size = new System.Drawing.Size(146, 26);
            this.labelNameSpace.TabIndex = 15;
            this.labelNameSpace.Text = "Nombre evento";
            // 
            // roundedTextBoxMeters
            // 
            this.roundedTextBoxMeters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxMeters.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxMeters.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxMeters.BorderRadius = 20;
            this.roundedTextBoxMeters.BorderSize = 3;
            this.roundedTextBoxMeters.Font = new System.Drawing.Font("Nunito", 12F);
            this.roundedTextBoxMeters.Location = new System.Drawing.Point(47, 320);
            this.roundedTextBoxMeters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxMeters.Multiline = false;
            this.roundedTextBoxMeters.Name = "roundedTextBoxMeters";
            this.roundedTextBoxMeters.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxMeters.PasswordChar = false;
            this.roundedTextBoxMeters.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxMeters.PlaceholderText = "";
            this.roundedTextBoxMeters.Size = new System.Drawing.Size(404, 43);
            this.roundedTextBoxMeters.TabIndex = 18;
            this.roundedTextBoxMeters.Texts = "";
            this.roundedTextBoxMeters.UnderlinedStyle = false;
            // 
            // labelMeters
            // 
            this.labelMeters.AutoSize = true;
            this.labelMeters.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelMeters.Location = new System.Drawing.Point(46, 281);
            this.labelMeters.Name = "labelMeters";
            this.labelMeters.Size = new System.Drawing.Size(166, 26);
            this.labelMeters.TabIndex = 17;
            this.labelMeters.Text = "Metros cuadrados";
            // 
            // roundedRadioButtonYes
            // 
            this.roundedRadioButtonYes.AutoSize = true;
            this.roundedRadioButtonYes.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedRadioButtonYes.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.roundedRadioButtonYes.Location = new System.Drawing.Point(544, 166);
            this.roundedRadioButtonYes.MinimumSize = new System.Drawing.Size(0, 18);
            this.roundedRadioButtonYes.Name = "roundedRadioButtonYes";
            this.roundedRadioButtonYes.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.roundedRadioButtonYes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.roundedRadioButtonYes.Size = new System.Drawing.Size(69, 30);
            this.roundedRadioButtonYes.TabIndex = 20;
            this.roundedRadioButtonYes.TabStop = true;
            this.roundedRadioButtonYes.Text = "Yes";
            this.roundedRadioButtonYes.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedRadioButtonYes.UseVisualStyleBackColor = true;
            // 
            // roundedRadioButtonNo
            // 
            this.roundedRadioButtonNo.AutoSize = true;
            this.roundedRadioButtonNo.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedRadioButtonNo.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.roundedRadioButtonNo.Location = new System.Drawing.Point(646, 166);
            this.roundedRadioButtonNo.MinimumSize = new System.Drawing.Size(0, 18);
            this.roundedRadioButtonNo.Name = "roundedRadioButtonNo";
            this.roundedRadioButtonNo.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.roundedRadioButtonNo.Size = new System.Drawing.Size(64, 30);
            this.roundedRadioButtonNo.TabIndex = 21;
            this.roundedRadioButtonNo.TabStop = true;
            this.roundedRadioButtonNo.Text = "No";
            this.roundedRadioButtonNo.UnCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedRadioButtonNo.UseVisualStyleBackColor = true;
            // 
            // labelFixedSeats
            // 
            this.labelFixedSeats.AutoSize = true;
            this.labelFixedSeats.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelFixedSeats.Location = new System.Drawing.Point(545, 120);
            this.labelFixedSeats.Name = "labelFixedSeats";
            this.labelFixedSeats.Size = new System.Drawing.Size(146, 26);
            this.labelFixedSeats.TabIndex = 22;
            this.labelFixedSeats.Text = "Nombre evento";
            // 
            // roundedTextBoxNumSeatsRow
            // 
            this.roundedTextBoxNumSeatsRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxNumSeatsRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxNumSeatsRow.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxNumSeatsRow.BorderRadius = 20;
            this.roundedTextBoxNumSeatsRow.BorderSize = 3;
            this.roundedTextBoxNumSeatsRow.Font = new System.Drawing.Font("Nunito", 12F);
            this.roundedTextBoxNumSeatsRow.Location = new System.Drawing.Point(545, 372);
            this.roundedTextBoxNumSeatsRow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxNumSeatsRow.Multiline = false;
            this.roundedTextBoxNumSeatsRow.Name = "roundedTextBoxNumSeatsRow";
            this.roundedTextBoxNumSeatsRow.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxNumSeatsRow.PasswordChar = false;
            this.roundedTextBoxNumSeatsRow.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxNumSeatsRow.PlaceholderText = "";
            this.roundedTextBoxNumSeatsRow.Size = new System.Drawing.Size(404, 43);
            this.roundedTextBoxNumSeatsRow.TabIndex = 26;
            this.roundedTextBoxNumSeatsRow.Texts = "";
            this.roundedTextBoxNumSeatsRow.UnderlinedStyle = false;
            // 
            // labelNumSeatsRow
            // 
            this.labelNumSeatsRow.AutoSize = true;
            this.labelNumSeatsRow.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelNumSeatsRow.Location = new System.Drawing.Point(544, 333);
            this.labelNumSeatsRow.Name = "labelNumSeatsRow";
            this.labelNumSeatsRow.Size = new System.Drawing.Size(225, 26);
            this.labelNumSeatsRow.TabIndex = 25;
            this.labelNumSeatsRow.Text = "Número de sillas por fila";
            // 
            // roundedTextBoxNumRow
            // 
            this.roundedTextBoxNumRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxNumRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxNumRow.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxNumRow.BorderRadius = 20;
            this.roundedTextBoxNumRow.BorderSize = 3;
            this.roundedTextBoxNumRow.Font = new System.Drawing.Font("Nunito", 12F);
            this.roundedTextBoxNumRow.Location = new System.Drawing.Point(545, 270);
            this.roundedTextBoxNumRow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxNumRow.Multiline = false;
            this.roundedTextBoxNumRow.Name = "roundedTextBoxNumRow";
            this.roundedTextBoxNumRow.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxNumRow.PasswordChar = false;
            this.roundedTextBoxNumRow.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxNumRow.PlaceholderText = "";
            this.roundedTextBoxNumRow.Size = new System.Drawing.Size(404, 43);
            this.roundedTextBoxNumRow.TabIndex = 24;
            this.roundedTextBoxNumRow.Texts = "";
            this.roundedTextBoxNumRow.UnderlinedStyle = false;
            // 
            // labelNumRow
            // 
            this.labelNumRow.AutoSize = true;
            this.labelNumRow.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelNumRow.Location = new System.Drawing.Point(544, 231);
            this.labelNumRow.Name = "labelNumRow";
            this.labelNumRow.Size = new System.Drawing.Size(226, 26);
            this.labelNumRow.TabIndex = 23;
            this.labelNumRow.Text = "Número de filas de sillas";
            // 
            // FormCreateEditSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 565);
            this.Controls.Add(this.roundedTextBoxNumSeatsRow);
            this.Controls.Add(this.labelNumSeatsRow);
            this.Controls.Add(this.roundedTextBoxNumRow);
            this.Controls.Add(this.labelNumRow);
            this.Controls.Add(this.labelFixedSeats);
            this.Controls.Add(this.roundedRadioButtonNo);
            this.Controls.Add(this.roundedRadioButtonYes);
            this.Controls.Add(this.roundedTextBoxMeters);
            this.Controls.Add(this.labelMeters);
            this.Controls.Add(this.roundedTextBoxNameEvent);
            this.Controls.Add(this.labelNameSpace);
            this.Name = "FormCreateEditSpace";
            this.Text = "FormCreateEditSpace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.RoundedTextBox roundedTextBoxNameEvent;
        private Label labelNameSpace;
        private Controls.RoundedTextBox roundedTextBoxMeters;
        private Label labelMeters;
        private Controls.RoundedRadioButton roundedRadioButtonYes;
        private Controls.RoundedRadioButton roundedRadioButtonNo;
        private Label labelFixedSeats;
        private Controls.RoundedTextBox roundedTextBoxNumSeatsRow;
        private Label labelNumSeatsRow;
        private Controls.RoundedTextBox roundedTextBoxNumRow;
        private Label labelNumRow;
    }
}