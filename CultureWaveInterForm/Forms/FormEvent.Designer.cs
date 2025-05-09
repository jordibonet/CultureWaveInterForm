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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvent));
            this.labelNameEvents = new System.Windows.Forms.Label();
            this.labelEventDate = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.roundedTextBoxEvenDateStart = new CultureWave_Form.Controls.RoundedTextBox();
            this.roundedTextBoxNameEvent = new CultureWave_Form.Controls.RoundedTextBox();
            this.roundedTextBoxEndDate = new CultureWave_Form.Controls.RoundedTextBox();
            this.roundedButtonGenerateIA = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonCreateEvent = new CultureWave_Form.Controls.RoundedButton();
            this.labelSpaceEvents = new System.Windows.Forms.Label();
            this.comboBoxSpaceEvents = new System.Windows.Forms.ComboBox();
            this.labelStateEvent = new System.Windows.Forms.Label();
            this.comboBoxStateEvents = new System.Windows.Forms.ComboBox();
            this.roundedRichTextBoxDescription = new CultureWave_Form.Controls.RoundedRichTextBox();
            this.SuspendLayout();
            // 
            // labelNameEvents
            // 
            this.labelNameEvents.AutoSize = true;
            this.labelNameEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelNameEvents.Location = new System.Drawing.Point(63, 87);
            this.labelNameEvents.Name = "labelNameEvents";
            this.labelNameEvents.Size = new System.Drawing.Size(154, 24);
            this.labelNameEvents.TabIndex = 8;
            this.labelNameEvents.Text = "Nombre evento";
            // 
            // labelEventDate
            // 
            this.labelEventDate.AutoSize = true;
            this.labelEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelEventDate.Location = new System.Drawing.Point(552, 87);
            this.labelEventDate.Name = "labelEventDate";
            this.labelEventDate.Size = new System.Drawing.Size(138, 24);
            this.labelEventDate.TabIndex = 9;
            this.labelEventDate.Text = "Fecha evento";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelDescription.Location = new System.Drawing.Point(63, 190);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(190, 24);
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
            this.roundedTextBoxEvenDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roundedTextBoxEvenDateStart.Location = new System.Drawing.Point(552, 126);
            this.roundedTextBoxEvenDateStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxEvenDateStart.MaxLength = 43;
            this.roundedTextBoxEvenDateStart.Multiline = false;
            this.roundedTextBoxEvenDateStart.Name = "roundedTextBoxEvenDateStart";
            this.roundedTextBoxEvenDateStart.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxEvenDateStart.PasswordChar = false;
            this.roundedTextBoxEvenDateStart.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxEvenDateStart.PlaceholderText = "YYYY/MM/DD hh:mm";
            this.roundedTextBoxEvenDateStart.Size = new System.Drawing.Size(258, 41);
            this.roundedTextBoxEvenDateStart.TabIndex = 13;
            this.roundedTextBoxEvenDateStart.Texts = "";
            this.roundedTextBoxEvenDateStart.UnderlinedStyle = false;
            // 
            // roundedTextBoxNameEvent
            // 
            this.roundedTextBoxNameEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxNameEvent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxNameEvent.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxNameEvent.BorderRadius = 20;
            this.roundedTextBoxNameEvent.BorderSize = 3;
            this.roundedTextBoxNameEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roundedTextBoxNameEvent.Location = new System.Drawing.Point(64, 126);
            this.roundedTextBoxNameEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxNameEvent.MaxLength = 43;
            this.roundedTextBoxNameEvent.Multiline = false;
            this.roundedTextBoxNameEvent.Name = "roundedTextBoxNameEvent";
            this.roundedTextBoxNameEvent.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxNameEvent.PasswordChar = false;
            this.roundedTextBoxNameEvent.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxNameEvent.PlaceholderText = "";
            this.roundedTextBoxNameEvent.Size = new System.Drawing.Size(404, 41);
            this.roundedTextBoxNameEvent.TabIndex = 14;
            this.roundedTextBoxNameEvent.Texts = "";
            this.roundedTextBoxNameEvent.UnderlinedStyle = false;
            // 
            // roundedTextBoxEndDate
            // 
            this.roundedTextBoxEndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxEndDate.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxEndDate.BorderRadius = 20;
            this.roundedTextBoxEndDate.BorderSize = 3;
            this.roundedTextBoxEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roundedTextBoxEndDate.Location = new System.Drawing.Point(552, 183);
            this.roundedTextBoxEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxEndDate.MaxLength = 43;
            this.roundedTextBoxEndDate.Multiline = false;
            this.roundedTextBoxEndDate.Name = "roundedTextBoxEndDate";
            this.roundedTextBoxEndDate.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxEndDate.PasswordChar = false;
            this.roundedTextBoxEndDate.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxEndDate.PlaceholderText = "YYYY/MM/DD hh:mm";
            this.roundedTextBoxEndDate.Size = new System.Drawing.Size(258, 41);
            this.roundedTextBoxEndDate.TabIndex = 16;
            this.roundedTextBoxEndDate.Texts = "";
            this.roundedTextBoxEndDate.UnderlinedStyle = false;
            // 
            // roundedButtonGenerateIA
            // 
            this.roundedButtonGenerateIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonGenerateIA.FlatAppearance.BorderSize = 0;
            this.roundedButtonGenerateIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonGenerateIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roundedButtonGenerateIA.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonGenerateIA.Location = new System.Drawing.Point(284, 7);
            this.roundedButtonGenerateIA.Name = "roundedButtonGenerateIA";
            this.roundedButtonGenerateIA.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonGenerateIA.TabIndex = 34;
            this.roundedButtonGenerateIA.Text = "Generar con IA";
            this.roundedButtonGenerateIA.UseVisualStyleBackColor = false;
            this.roundedButtonGenerateIA.Click += new System.EventHandler(this.roundedButtonGenerateIA_Click);
            // 
            // roundedButtonCreateEvent
            // 
            this.roundedButtonCreateEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonCreateEvent.FlatAppearance.BorderSize = 0;
            this.roundedButtonCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonCreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roundedButtonCreateEvent.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonCreateEvent.Location = new System.Drawing.Point(519, 7);
            this.roundedButtonCreateEvent.Name = "roundedButtonCreateEvent";
            this.roundedButtonCreateEvent.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonCreateEvent.TabIndex = 35;
            this.roundedButtonCreateEvent.Text = "Crear evento";
            this.roundedButtonCreateEvent.UseVisualStyleBackColor = false;
            this.roundedButtonCreateEvent.Click += new System.EventHandler(this.roundedButtonCreateEvent_Click);
            // 
            // labelSpaceEvents
            // 
            this.labelSpaceEvents.AutoSize = true;
            this.labelSpaceEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelSpaceEvents.Location = new System.Drawing.Point(552, 248);
            this.labelSpaceEvents.Name = "labelSpaceEvents";
            this.labelSpaceEvents.Size = new System.Drawing.Size(95, 24);
            this.labelSpaceEvents.TabIndex = 36;
            this.labelSpaceEvents.Text = "Espacios";
            // 
            // comboBoxSpaceEvents
            // 
            this.comboBoxSpaceEvents.DisplayMember = "idSpace";
            this.comboBoxSpaceEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpaceEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxSpaceEvents.FormattingEnabled = true;
            this.comboBoxSpaceEvents.Location = new System.Drawing.Point(556, 295);
            this.comboBoxSpaceEvents.Name = "comboBoxSpaceEvents";
            this.comboBoxSpaceEvents.Size = new System.Drawing.Size(254, 28);
            this.comboBoxSpaceEvents.TabIndex = 37;
            this.comboBoxSpaceEvents.ValueMember = "idSpace";
            // 
            // labelStateEvent
            // 
            this.labelStateEvent.AutoSize = true;
            this.labelStateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelStateEvent.Location = new System.Drawing.Point(552, 339);
            this.labelStateEvent.Name = "labelStateEvent";
            this.labelStateEvent.Size = new System.Drawing.Size(74, 24);
            this.labelStateEvent.TabIndex = 38;
            this.labelStateEvent.Text = "Estado";
            // 
            // comboBoxStateEvents
            // 
            this.comboBoxStateEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStateEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxStateEvents.FormattingEnabled = true;
            this.comboBoxStateEvents.Items.AddRange(new object[] {
            "Programat",
            "Actiu",
            "Finalitzat"});
            this.comboBoxStateEvents.Location = new System.Drawing.Point(556, 379);
            this.comboBoxStateEvents.Name = "comboBoxStateEvents";
            this.comboBoxStateEvents.Size = new System.Drawing.Size(254, 28);
            this.comboBoxStateEvents.TabIndex = 39;
            // 
            // roundedRichTextBoxDescription
            // 
            this.roundedRichTextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedRichTextBoxDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedRichTextBoxDescription.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedRichTextBoxDescription.BorderRadius = 20;
            this.roundedRichTextBoxDescription.BorderSize = 3;
            this.roundedRichTextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roundedRichTextBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedRichTextBoxDescription.Location = new System.Drawing.Point(67, 216);
            this.roundedRichTextBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.roundedRichTextBoxDescription.Name = "roundedRichTextBoxDescription";
            this.roundedRichTextBoxDescription.Padding = new System.Windows.Forms.Padding(8);
            this.roundedRichTextBoxDescription.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedRichTextBoxDescription.PlaceholderText = "";
            this.roundedRichTextBoxDescription.Size = new System.Drawing.Size(401, 146);
            this.roundedRichTextBoxDescription.TabIndex = 42;
            this.roundedRichTextBoxDescription.Texts = "";
            this.roundedRichTextBoxDescription.UnderlinedStyle = false;
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 565);
            this.Controls.Add(this.roundedRichTextBoxDescription);
            this.Controls.Add(this.comboBoxStateEvents);
            this.Controls.Add(this.labelStateEvent);
            this.Controls.Add(this.comboBoxSpaceEvents);
            this.Controls.Add(this.labelSpaceEvents);
            this.Controls.Add(this.roundedButtonCreateEvent);
            this.Controls.Add(this.roundedButtonGenerateIA);
            this.Controls.Add(this.roundedTextBoxEndDate);
            this.Controls.Add(this.roundedTextBoxNameEvent);
            this.Controls.Add(this.roundedTextBoxEvenDateStart);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelEventDate);
            this.Controls.Add(this.labelNameEvents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEvent";
            this.Text = "Evento";
            this.Load += new System.EventHandler(this.FormEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button;
        private Button button1;
        private Label labelNameEvents;
        private Label labelEventDate;
        private Controls.RoundedTextBox roundedTextBoxEndDate;
        private Label labelDescription;
        private Controls.RoundedTextBox roundedTextBoxEvenDateStart;
        private Controls.RoundedTextBox roundedTextBoxNameEvent;
        private Controls.RoundedTextBox roundedTextBox2;
        private Controls.RoundedButton roundedButtonGenerateIA;
        private Controls.RoundedButton roundedButtonCreateEvent;
        private Label labelSpaceEvents;
        private ComboBox comboBoxSpaceEvents;
        private Label labelStateEvent;
        private ComboBox comboBoxStateEvents;
        private Controls.RoundedRichTextBox roundedRichTextBoxDescription;
    }
}