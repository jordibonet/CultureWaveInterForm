using System.Drawing;
using System.Windows.Forms;

namespace CultureWave_Form
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCultureWave = new System.Windows.Forms.Label();
            this.roundedTextBoxUser = new CultureWave_Form.Controls.RoundedTextBox();
            this.roundedTextBoxPassword = new CultureWave_Form.Controls.RoundedTextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCultureWave
            // 
            this.labelCultureWave.AutoSize = true;
            this.labelCultureWave.Font = new System.Drawing.Font("Nunito", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCultureWave.Location = new System.Drawing.Point(510, 232);
            this.labelCultureWave.Name = "labelCultureWave";
            this.labelCultureWave.Size = new System.Drawing.Size(262, 44);
            this.labelCultureWave.TabIndex = 0;
            this.labelCultureWave.Text = "CULTUREWAVE";
            // 
            // roundedTextBoxUser
            // 
            this.roundedTextBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxUser.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxUser.BorderRadius = 10;
            this.roundedTextBoxUser.BorderSize = 3;
            this.roundedTextBoxUser.Font = new System.Drawing.Font("Nunito Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.roundedTextBoxUser.Location = new System.Drawing.Point(394, 344);
            this.roundedTextBoxUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roundedTextBoxUser.Multiline = false;
            this.roundedTextBoxUser.Name = "roundedTextBoxUser";
            this.roundedTextBoxUser.Padding = new System.Windows.Forms.Padding(8, 14, 8, 14);
            this.roundedTextBoxUser.PasswordChar = false;
            this.roundedTextBoxUser.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxUser.PlaceholderText = "";
            this.roundedTextBoxUser.Size = new System.Drawing.Size(492, 51);
            this.roundedTextBoxUser.TabIndex = 1;
            this.roundedTextBoxUser.Texts = "";
            this.roundedTextBoxUser.UnderlinedStyle = false;
            // 
            // roundedTextBoxPassword
            // 
            this.roundedTextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxPassword.BorderRadius = 10;
            this.roundedTextBoxPassword.BorderSize = 3;
            this.roundedTextBoxPassword.Font = new System.Drawing.Font("Nunito Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedTextBoxPassword.Location = new System.Drawing.Point(394, 447);
            this.roundedTextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roundedTextBoxPassword.Multiline = false;
            this.roundedTextBoxPassword.Name = "roundedTextBoxPassword";
            this.roundedTextBoxPassword.Padding = new System.Windows.Forms.Padding(8, 14, 8, 14);
            this.roundedTextBoxPassword.PasswordChar = false;
            this.roundedTextBoxPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxPassword.PlaceholderText = "";
            this.roundedTextBoxPassword.Size = new System.Drawing.Size(492, 51);
            this.roundedTextBoxPassword.TabIndex = 2;
            this.roundedTextBoxPassword.Texts = "";
            this.roundedTextBoxPassword.UnderlinedStyle = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Nunito Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(394, 318);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(67, 22);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "Usuario";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Nunito Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(394, 421);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(94, 22);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Contraseña";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.buttonLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogIn.FlatAppearance.BorderSize = 0;
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("Nunito Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(572, 559);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(140, 60);
            this.buttonLogIn.TabIndex = 5;
            this.buttonLogIn.Text = "Iniciar Sesión";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(544, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 192);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.roundedTextBoxPassword);
            this.Controls.Add(this.roundedTextBoxUser);
            this.Controls.Add(this.labelCultureWave);
            this.Name = "FormLogin";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelCultureWave;
        private Controls.RoundedTextBox roundedTextBoxUser;
        private Controls.RoundedTextBox roundedTextBoxPassword;
        private Label labelUser;
        private Label labelPassword;
        private Button buttonLogIn;
        private PictureBox pictureBox1;
    }
}
