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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labeLExit
            // 
            this.labeLExit.AutoSize = true;
            this.labeLExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labeLExit.Location = new System.Drawing.Point(478, 245);
            this.labeLExit.Name = "labeLExit";
            this.labeLExit.Size = new System.Drawing.Size(51, 24);
            this.labeLExit.TabIndex = 36;
            this.labeLExit.Text = "Salir";
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelLogOut.Location = new System.Drawing.Point(478, 73);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(138, 24);
            this.labelLogOut.TabIndex = 35;
            this.labelLogOut.Text = "Cerrar Sesión";
            // 
            // roundedButtonExit
            // 
            this.roundedButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonExit.FlatAppearance.BorderSize = 0;
            this.roundedButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roundedButtonExit.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonExit.Location = new System.Drawing.Point(478, 288);
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
            this.roundedButtonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roundedButtonLogOut.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonLogOut.Location = new System.Drawing.Point(478, 117);
            this.roundedButtonLogOut.Name = "roundedButtonLogOut";
            this.roundedButtonLogOut.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonLogOut.TabIndex = 38;
            this.roundedButtonLogOut.Text = "Cerrar Sesión";
            this.roundedButtonLogOut.UseVisualStyleBackColor = false;
            this.roundedButtonLogOut.Click += new System.EventHandler(this.roundedButtonLogOut_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CultureWaveInterForm.Properties.Resources.ing;
            this.pictureBox3.Location = new System.Drawing.Point(658, 420);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CultureWaveInterForm.Properties.Resources.cat;
            this.pictureBox2.Location = new System.Drawing.Point(495, 420);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CultureWaveInterForm.Properties.Resources.esp;
            this.pictureBox1.Location = new System.Drawing.Point(323, 420);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // FormExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 565);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roundedButtonLogOut);
            this.Controls.Add(this.roundedButtonExit);
            this.Controls.Add(this.labeLExit);
            this.Controls.Add(this.labelLogOut);
            this.Name = "FormExit";
            this.Text = "FormExit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labeLExit;
        private Label labelLogOut;
        private Controls.RoundedButton roundedButtonExit;
        private Controls.RoundedButton roundedButtonLogOut;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}