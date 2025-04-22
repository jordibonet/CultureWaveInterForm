using System.Drawing;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{
    partial class FormCreateEditUser
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
            this.roundedTextBoxUser = new CultureWave_Form.Controls.RoundedTextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.roundedTextBoxEmail = new CultureWave_Form.Controls.RoundedTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.roundedTextBoxRol = new CultureWave_Form.Controls.RoundedTextBox();
            this.labelRol = new System.Windows.Forms.Label();
            this.roundedTextBoxPassword = new CultureWave_Form.Controls.RoundedTextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.roundedButtonAccept = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonCancel = new CultureWave_Form.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // roundedTextBoxUser
            // 
            this.roundedTextBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxUser.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxUser.BorderRadius = 20;
            this.roundedTextBoxUser.BorderSize = 3;
            this.roundedTextBoxUser.Font = new System.Drawing.Font("Nunito", 12F);
            this.roundedTextBoxUser.Location = new System.Drawing.Point(92, 57);
            this.roundedTextBoxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxUser.Multiline = false;
            this.roundedTextBoxUser.Name = "roundedTextBoxUser";
            this.roundedTextBoxUser.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxUser.PasswordChar = false;
            this.roundedTextBoxUser.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxUser.PlaceholderText = "";
            this.roundedTextBoxUser.Size = new System.Drawing.Size(334, 43);
            this.roundedTextBoxUser.TabIndex = 23;
            this.roundedTextBoxUser.Texts = "";
            this.roundedTextBoxUser.UnderlinedStyle = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelUser.Location = new System.Drawing.Point(91, 25);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(79, 26);
            this.labelUser.TabIndex = 22;
            this.labelUser.Text = "Usuario";
            // 
            // roundedTextBoxEmail
            // 
            this.roundedTextBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxEmail.BorderRadius = 20;
            this.roundedTextBoxEmail.BorderSize = 3;
            this.roundedTextBoxEmail.Font = new System.Drawing.Font("Nunito", 12F);
            this.roundedTextBoxEmail.Location = new System.Drawing.Point(92, 150);
            this.roundedTextBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxEmail.Multiline = false;
            this.roundedTextBoxEmail.Name = "roundedTextBoxEmail";
            this.roundedTextBoxEmail.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxEmail.PasswordChar = false;
            this.roundedTextBoxEmail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxEmail.PlaceholderText = "";
            this.roundedTextBoxEmail.Size = new System.Drawing.Size(334, 43);
            this.roundedTextBoxEmail.TabIndex = 26;
            this.roundedTextBoxEmail.Texts = "";
            this.roundedTextBoxEmail.UnderlinedStyle = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelEmail.Location = new System.Drawing.Point(91, 118);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(171, 26);
            this.labelEmail.TabIndex = 25;
            this.labelEmail.Text = "Correo electrónico";
            // 
            // roundedTextBoxRol
            // 
            this.roundedTextBoxRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxRol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxRol.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxRol.BorderRadius = 20;
            this.roundedTextBoxRol.BorderSize = 3;
            this.roundedTextBoxRol.Font = new System.Drawing.Font("Nunito", 12F);
            this.roundedTextBoxRol.Location = new System.Drawing.Point(93, 338);
            this.roundedTextBoxRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxRol.Multiline = false;
            this.roundedTextBoxRol.Name = "roundedTextBoxRol";
            this.roundedTextBoxRol.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxRol.PasswordChar = false;
            this.roundedTextBoxRol.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxRol.PlaceholderText = "";
            this.roundedTextBoxRol.Size = new System.Drawing.Size(334, 43);
            this.roundedTextBoxRol.TabIndex = 31;
            this.roundedTextBoxRol.Texts = "";
            this.roundedTextBoxRol.UnderlinedStyle = false;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelRol.Location = new System.Drawing.Point(92, 306);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(42, 26);
            this.labelRol.TabIndex = 30;
            this.labelRol.Text = "Rol";
            // 
            // roundedTextBoxPassword
            // 
            this.roundedTextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxPassword.BorderRadius = 20;
            this.roundedTextBoxPassword.BorderSize = 3;
            this.roundedTextBoxPassword.Font = new System.Drawing.Font("Nunito", 12F);
            this.roundedTextBoxPassword.Location = new System.Drawing.Point(93, 245);
            this.roundedTextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxPassword.Multiline = false;
            this.roundedTextBoxPassword.Name = "roundedTextBoxPassword";
            this.roundedTextBoxPassword.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxPassword.PasswordChar = false;
            this.roundedTextBoxPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxPassword.PlaceholderText = "";
            this.roundedTextBoxPassword.Size = new System.Drawing.Size(334, 43);
            this.roundedTextBoxPassword.TabIndex = 29;
            this.roundedTextBoxPassword.Texts = "";
            this.roundedTextBoxPassword.UnderlinedStyle = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelPassword.Location = new System.Drawing.Point(92, 213);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(110, 26);
            this.labelPassword.TabIndex = 28;
            this.labelPassword.Text = "Contraseña";
            // 
            // roundedButtonAccept
            // 
            this.roundedButtonAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonAccept.FlatAppearance.BorderSize = 0;
            this.roundedButtonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonAccept.Font = new System.Drawing.Font("Nunito Medium", 10F);
            this.roundedButtonAccept.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonAccept.Location = new System.Drawing.Point(103, 429);
            this.roundedButtonAccept.Name = "roundedButtonAccept";
            this.roundedButtonAccept.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonAccept.TabIndex = 33;
            this.roundedButtonAccept.Text = "Aceptar";
            this.roundedButtonAccept.UseVisualStyleBackColor = false;
            // 
            // roundedButtonCancel
            // 
            this.roundedButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonCancel.FlatAppearance.BorderSize = 0;
            this.roundedButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonCancel.Font = new System.Drawing.Font("Nunito Medium", 10F);
            this.roundedButtonCancel.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonCancel.Location = new System.Drawing.Point(290, 429);
            this.roundedButtonCancel.Name = "roundedButtonCancel";
            this.roundedButtonCancel.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonCancel.TabIndex = 34;
            this.roundedButtonCancel.Text = "Cancelar";
            this.roundedButtonCancel.UseVisualStyleBackColor = false;
            this.roundedButtonCancel.Click += new System.EventHandler(this.roundedButtonCancel_Click);
            // 
            // FormCreateEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 542);
            this.ControlBox = false;
            this.Controls.Add(this.roundedButtonCancel);
            this.Controls.Add(this.roundedButtonAccept);
            this.Controls.Add(this.roundedTextBoxRol);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.roundedTextBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.roundedTextBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.roundedTextBoxUser);
            this.Controls.Add(this.labelUser);
            this.Name = "FormCreateEditUser";
            this.Text = "FormCreateEditUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.RoundedTextBox roundedTextBoxUser;
        private Label labelUser;
        private Controls.RoundedTextBox roundedTextBoxEmail;
        private Label labelEmail;
        private Controls.RoundedTextBox roundedTextBoxRol;
        private Label labelRol;
        private Controls.RoundedTextBox roundedTextBoxPassword;
        private Label labelPassword;
        private Controls.RoundedButton roundedButtonAccept;
        private Controls.RoundedButton roundedButtonCancel;
    }
}