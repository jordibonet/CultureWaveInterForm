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
            this.labelExit = new System.Windows.Forms.Label();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.roundedButtonExit = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonLogOut = new CultureWave_Form.Controls.RoundedButton();
            this.pictureBoxEnglish = new System.Windows.Forms.PictureBox();
            this.pictureBoxCatalan = new System.Windows.Forms.PictureBox();
            this.pictureBoxSpanish = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpanish)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelExit.Location = new System.Drawing.Point(478, 245);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(51, 24);
            this.labelExit.TabIndex = 36;
            this.labelExit.Text = "Salir";
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
            // pictureBoxEnglish
            // 
            this.pictureBoxEnglish.Image = global::CultureWaveInterForm.Properties.Resources.ing;
            this.pictureBoxEnglish.Location = new System.Drawing.Point(658, 420);
            this.pictureBoxEnglish.Name = "pictureBoxEnglish";
            this.pictureBoxEnglish.Size = new System.Drawing.Size(84, 67);
            this.pictureBoxEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnglish.TabIndex = 41;
            this.pictureBoxEnglish.TabStop = false;
            this.pictureBoxEnglish.Click += new System.EventHandler(this.pictureBoxEnglish_Click);
            // 
            // pictureBoxCatalan
            // 
            this.pictureBoxCatalan.Image = global::CultureWaveInterForm.Properties.Resources.cat;
            this.pictureBoxCatalan.Location = new System.Drawing.Point(495, 420);
            this.pictureBoxCatalan.Name = "pictureBoxCatalan";
            this.pictureBoxCatalan.Size = new System.Drawing.Size(84, 67);
            this.pictureBoxCatalan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCatalan.TabIndex = 40;
            this.pictureBoxCatalan.TabStop = false;
            this.pictureBoxCatalan.Click += new System.EventHandler(this.pictureBoxCatalan_Click);
            // 
            // pictureBoxSpanish
            // 
            this.pictureBoxSpanish.Image = global::CultureWaveInterForm.Properties.Resources.esp;
            this.pictureBoxSpanish.Location = new System.Drawing.Point(323, 420);
            this.pictureBoxSpanish.Name = "pictureBoxSpanish";
            this.pictureBoxSpanish.Size = new System.Drawing.Size(84, 67);
            this.pictureBoxSpanish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSpanish.TabIndex = 39;
            this.pictureBoxSpanish.TabStop = false;
            this.pictureBoxSpanish.Click += new System.EventHandler(this.pictureBoxSpanish_Click);
            // 
            // FormExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 565);
            this.Controls.Add(this.pictureBoxEnglish);
            this.Controls.Add(this.pictureBoxCatalan);
            this.Controls.Add(this.pictureBoxSpanish);
            this.Controls.Add(this.roundedButtonLogOut);
            this.Controls.Add(this.roundedButtonExit);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelLogOut);
            this.Name = "FormExit";
            this.Text = "FormExit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpanish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelExit;
        private Label labelLogOut;
        private Controls.RoundedButton roundedButtonExit;
        private Controls.RoundedButton roundedButtonLogOut;
        private PictureBox pictureBoxSpanish;
        private PictureBox pictureBoxCatalan;
        private PictureBox pictureBoxEnglish;
    }
}