using System.Drawing;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{
    partial class FormExit
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
            this.labeLExit = new System.Windows.Forms.Label();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.roundedButtonExit = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonLogOut = new CultureWave_Form.Controls.RoundedButton();
            this.SuspendLayout();
            // 
            // labeLExit
            // 
            this.labeLExit.AutoSize = true;
            this.labeLExit.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labeLExit.Location = new System.Drawing.Point(413, 294);
            this.labeLExit.Name = "labeLExit";
            this.labeLExit.Size = new System.Drawing.Size(52, 26);
            this.labeLExit.TabIndex = 36;
            this.labeLExit.Text = "Salir";
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelLogOut.Location = new System.Drawing.Point(413, 122);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(128, 26);
            this.labelLogOut.TabIndex = 35;
            this.labelLogOut.Text = "Cerrar Sesión";
            // 
            // roundedButtonExit
            // 
            this.roundedButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonExit.FlatAppearance.BorderSize = 0;
            this.roundedButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonExit.Font = new System.Drawing.Font("Nunito Medium", 10F);
            this.roundedButtonExit.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonExit.Location = new System.Drawing.Point(413, 337);
            this.roundedButtonExit.Name = "roundedButtonExit";
            this.roundedButtonExit.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonExit.TabIndex = 37;
            this.roundedButtonExit.Text = "Salir";
            this.roundedButtonExit.UseVisualStyleBackColor = false;
            this.roundedButtonExit.Click += new System.EventHandler(this.roundedButtonExit_Click);
            // 
            // roundedButtonLogOut
            // 
            this.roundedButtonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonLogOut.FlatAppearance.BorderSize = 0;
            this.roundedButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonLogOut.Font = new System.Drawing.Font("Nunito Medium", 10F);
            this.roundedButtonLogOut.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonLogOut.Location = new System.Drawing.Point(413, 166);
            this.roundedButtonLogOut.Name = "roundedButtonLogOut";
            this.roundedButtonLogOut.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonLogOut.TabIndex = 38;
            this.roundedButtonLogOut.Text = "Cerrar Sesión";
            this.roundedButtonLogOut.UseVisualStyleBackColor = false;
            // 
            // FormExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 565);
            this.Controls.Add(this.roundedButtonLogOut);
            this.Controls.Add(this.roundedButtonExit);
            this.Controls.Add(this.labeLExit);
            this.Controls.Add(this.labelLogOut);
            this.Name = "FormExit";
            this.Text = "FormExit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labeLExit;
        private Label labelLogOut;
        private Controls.RoundedButton roundedButtonExit;
        private Controls.RoundedButton roundedButtonLogOut;
    }
}