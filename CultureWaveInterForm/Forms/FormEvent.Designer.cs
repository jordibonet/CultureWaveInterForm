using System.Drawing;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{
    partial class FormEvent
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
            this.labelNameEvents = new System.Windows.Forms.Label();
            this.labelEventDate = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.roundedTextBoxEvenDateStart = new CultureWave_Form.Controls.RoundedTextBox();
            this.roundedTextBoxUser = new CultureWave_Form.Controls.RoundedTextBox();
            this.roundedTextBoxDescription = new CultureWave_Form.Controls.RoundedTextBox();
            this.roundedTextBox1 = new CultureWave_Form.Controls.RoundedTextBox();
            this.roundedButtonGenerateIA = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonCreateEvent = new CultureWave_Form.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // labelNameEvents
            // 
            this.labelNameEvents.AutoSize = true;
            this.labelNameEvents.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelNameEvents.Location = new System.Drawing.Point(63, 87);
            this.labelNameEvents.Name = "labelNameEvents";
            this.labelNameEvents.Size = new System.Drawing.Size(146, 26);
            this.labelNameEvents.TabIndex = 8;
            this.labelNameEvents.Text = "Nombre evento";
            // 
            // labelEventDate
            // 
            this.labelEventDate.AutoSize = true;
            this.labelEventDate.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelEventDate.Location = new System.Drawing.Point(552, 87);
            this.labelEventDate.Name = "labelEventDate";
            this.labelEventDate.Size = new System.Drawing.Size(127, 26);
            this.labelEventDate.TabIndex = 9;
            this.labelEventDate.Text = "Fecha evento";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelDescription.Location = new System.Drawing.Point(63, 190);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(177, 26);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Descripción evento";
            // 
            // roundedTextBoxEvenDateStart
            // 
            this.roundedTextBoxEvenDateStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxEvenDateStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxEvenDateStart.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxEvenDateStart.BorderRadius = 20;
            this.roundedTextBoxEvenDateStart.BorderSize = 3;
            this.roundedTextBoxEvenDateStart.Font = new System.Drawing.Font("Nunito", 12F);
            this.roundedTextBoxEvenDateStart.Location = new System.Drawing.Point(552, 126);
            this.roundedTextBoxEvenDateStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxEvenDateStart.Multiline = false;
            this.roundedTextBoxEvenDateStart.Name = "roundedTextBoxEvenDateStart";
            this.roundedTextBoxEvenDateStart.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxEvenDateStart.PasswordChar = false;
            this.roundedTextBoxEvenDateStart.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxEvenDateStart.PlaceholderText = "YYYY:MM:DD hh:mm";
            this.roundedTextBoxEvenDateStart.Size = new System.Drawing.Size(258, 43);
            this.roundedTextBoxEvenDateStart.TabIndex = 13;
            this.roundedTextBoxEvenDateStart.Texts = "";
            this.roundedTextBoxEvenDateStart.UnderlinedStyle = false;
            // 
            // roundedTextBoxUser
            // 
            this.roundedTextBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxUser.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxUser.BorderRadius = 20;
            this.roundedTextBoxUser.BorderSize = 3;
            this.roundedTextBoxUser.Font = new System.Drawing.Font("Nunito", 12F);
            this.roundedTextBoxUser.Location = new System.Drawing.Point(64, 126);
            this.roundedTextBoxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxUser.Multiline = false;
            this.roundedTextBoxUser.Name = "roundedTextBoxUser";
            this.roundedTextBoxUser.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxUser.PasswordChar = false;
            this.roundedTextBoxUser.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxUser.PlaceholderText = "";
            this.roundedTextBoxUser.Size = new System.Drawing.Size(404, 43);
            this.roundedTextBoxUser.TabIndex = 14;
            this.roundedTextBoxUser.Texts = "";
            this.roundedTextBoxUser.UnderlinedStyle = false;
            // 
            // roundedTextBoxDescription
            // 
            this.roundedTextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxDescription.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxDescription.BorderRadius = 20;
            this.roundedTextBoxDescription.BorderSize = 3;
            this.roundedTextBoxDescription.Font = new System.Drawing.Font("Nunito", 12F);
            this.roundedTextBoxDescription.Location = new System.Drawing.Point(64, 222);
            this.roundedTextBoxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxDescription.Multiline = true;
            this.roundedTextBoxDescription.Name = "roundedTextBoxDescription";
            this.roundedTextBoxDescription.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxDescription.PasswordChar = false;
            this.roundedTextBoxDescription.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxDescription.PlaceholderText = "";
            this.roundedTextBoxDescription.Size = new System.Drawing.Size(404, 123);
            this.roundedTextBoxDescription.TabIndex = 15;
            this.roundedTextBoxDescription.Texts = "";
            this.roundedTextBoxDescription.UnderlinedStyle = false;
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBox1.BorderRadius = 20;
            this.roundedTextBox1.BorderSize = 3;
            this.roundedTextBox1.Font = new System.Drawing.Font("Nunito", 12F);
            this.roundedTextBox1.Location = new System.Drawing.Point(552, 183);
            this.roundedTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBox1.Multiline = false;
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBox1.PasswordChar = false;
            this.roundedTextBox1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBox1.PlaceholderText = "YYYY:MM:DD hh:mm";
            this.roundedTextBox1.Size = new System.Drawing.Size(258, 43);
            this.roundedTextBox1.TabIndex = 16;
            this.roundedTextBox1.Texts = "";
            this.roundedTextBox1.UnderlinedStyle = false;
            // 
            // roundedButtonGenerateIA
            // 
            this.roundedButtonGenerateIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonGenerateIA.FlatAppearance.BorderSize = 0;
            this.roundedButtonGenerateIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonGenerateIA.Font = new System.Drawing.Font("Nunito Medium", 10F);
            this.roundedButtonGenerateIA.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonGenerateIA.Location = new System.Drawing.Point(284, 7);
            this.roundedButtonGenerateIA.Name = "roundedButtonGenerateIA";
            this.roundedButtonGenerateIA.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonGenerateIA.TabIndex = 34;
            this.roundedButtonGenerateIA.Text = "Generar con IA";
            this.roundedButtonGenerateIA.UseVisualStyleBackColor = false;
            // 
            // roundedButtonCreateEvent
            // 
            this.roundedButtonCreateEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonCreateEvent.FlatAppearance.BorderSize = 0;
            this.roundedButtonCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonCreateEvent.Font = new System.Drawing.Font("Nunito Medium", 10F);
            this.roundedButtonCreateEvent.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonCreateEvent.Location = new System.Drawing.Point(519, 7);
            this.roundedButtonCreateEvent.Name = "roundedButtonCreateEvent";
            this.roundedButtonCreateEvent.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonCreateEvent.TabIndex = 35;
            this.roundedButtonCreateEvent.Text = "Crear evento";
            this.roundedButtonCreateEvent.UseVisualStyleBackColor = false;
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 565);
            this.Controls.Add(this.roundedButtonCreateEvent);
            this.Controls.Add(this.roundedButtonGenerateIA);
            this.Controls.Add(this.roundedTextBox1);
            this.Controls.Add(this.roundedTextBoxDescription);
            this.Controls.Add(this.roundedTextBoxUser);
            this.Controls.Add(this.roundedTextBoxEvenDateStart);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelEventDate);
            this.Controls.Add(this.labelNameEvents);
            this.Name = "FormEvent";
            this.Text = "FormEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button;
        private Button button1;
        private Label labelNameEvents;
        private Label labelEventDate;
        private Controls.RoundedTextBox roundedTextBox1;
        private Label labelDescription;
        private Controls.RoundedTextBox roundedTextBoxEvenDateStart;
        private Controls.RoundedTextBox roundedTextBoxUser;
        private Controls.RoundedTextBox roundedTextBoxDescription;
        private Controls.RoundedTextBox roundedTextBox2;
        private Controls.RoundedButton roundedButtonGenerateIA;
        private Controls.RoundedButton roundedButtonCreateEvent;
    }
}