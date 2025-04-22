using System.Drawing;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{
    partial class FormReserve
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
            this.labelNameReserves = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.dataGridViewSpaces = new System.Windows.Forms.DataGridView();
            this.roundedTextBoxUser = new CultureWave_Form.Controls.RoundedTextBox();
            this.roundedButtonReserve = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonDeleteReserve = new CultureWave_Form.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaces)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameReserves
            // 
            this.labelNameReserves.AutoSize = true;
            this.labelNameReserves.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelNameReserves.Location = new System.Drawing.Point(12, 126);
            this.labelNameReserves.Name = "labelNameReserves";
            this.labelNameReserves.Size = new System.Drawing.Size(91, 26);
            this.labelNameReserves.TabIndex = 16;
            this.labelNameReserves.Text = "Reservas";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelUser.Location = new System.Drawing.Point(12, 18);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(79, 26);
            this.labelUser.TabIndex = 17;
            this.labelUser.Text = "Usuario";
            // 
            // dataGridViewSpaces
            // 
            this.dataGridViewSpaces.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.dataGridViewSpaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpaces.Location = new System.Drawing.Point(12, 159);
            this.dataGridViewSpaces.Name = "dataGridViewSpaces";
            this.dataGridViewSpaces.Size = new System.Drawing.Size(992, 394);
            this.dataGridViewSpaces.TabIndex = 18;
            // 
            // roundedTextBoxUser
            // 
            this.roundedTextBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxUser.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxUser.BorderRadius = 20;
            this.roundedTextBoxUser.BorderSize = 3;
            this.roundedTextBoxUser.Font = new System.Drawing.Font("Nunito", 12F);
            this.roundedTextBoxUser.Location = new System.Drawing.Point(13, 50);
            this.roundedTextBoxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxUser.Multiline = false;
            this.roundedTextBoxUser.Name = "roundedTextBoxUser";
            this.roundedTextBoxUser.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxUser.PasswordChar = false;
            this.roundedTextBoxUser.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxUser.PlaceholderText = "";
            this.roundedTextBoxUser.Size = new System.Drawing.Size(298, 43);
            this.roundedTextBoxUser.TabIndex = 20;
            this.roundedTextBoxUser.Texts = "";
            this.roundedTextBoxUser.UnderlinedStyle = false;
            // 
            // roundedButtonReserve
            // 
            this.roundedButtonReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonReserve.FlatAppearance.BorderSize = 0;
            this.roundedButtonReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonReserve.Font = new System.Drawing.Font("Nunito Medium", 10F);
            this.roundedButtonReserve.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonReserve.Location = new System.Drawing.Point(555, 34);
            this.roundedButtonReserve.Name = "roundedButtonReserve";
            this.roundedButtonReserve.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonReserve.TabIndex = 39;
            this.roundedButtonReserve.Text = "Reservar";
            this.roundedButtonReserve.UseVisualStyleBackColor = false;
            // 
            // roundedButtonDeleteReserve
            // 
            this.roundedButtonDeleteReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonDeleteReserve.FlatAppearance.BorderSize = 0;
            this.roundedButtonDeleteReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonDeleteReserve.Font = new System.Drawing.Font("Nunito Medium", 10F);
            this.roundedButtonDeleteReserve.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonDeleteReserve.Location = new System.Drawing.Point(789, 35);
            this.roundedButtonDeleteReserve.Name = "roundedButtonDeleteReserve";
            this.roundedButtonDeleteReserve.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonDeleteReserve.TabIndex = 40;
            this.roundedButtonDeleteReserve.Text = "Eliminar Reserva";
            this.roundedButtonDeleteReserve.UseVisualStyleBackColor = false;
            // 
            // FormReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 565);
            this.Controls.Add(this.roundedButtonDeleteReserve);
            this.Controls.Add(this.roundedButtonReserve);
            this.Controls.Add(this.roundedTextBoxUser);
            this.Controls.Add(this.dataGridViewSpaces);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelNameReserves);
            this.Name = "FormReserve";
            this.Text = "FormReserve";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNameReserves;
        private Label labelUser;
        private DataGridView dataGridViewSpaces;
        private Controls.RoundedTextBox roundedTextBoxUser;
        private Controls.RoundedButton roundedButtonReserve;
        private Controls.RoundedButton roundedButtonDeleteReserve;
    }
}