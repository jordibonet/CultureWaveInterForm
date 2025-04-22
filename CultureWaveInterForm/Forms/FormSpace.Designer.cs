using System.Drawing;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{
    partial class FormSpace
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
            this.dataGridViewSpaces = new System.Windows.Forms.DataGridView();
            this.labelNameSpaces = new System.Windows.Forms.Label();
            this.roundedButtonEdit = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonCreate = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonReserve = new CultureWave_Form.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaces)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSpaces
            // 
            this.dataGridViewSpaces.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.dataGridViewSpaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpaces.Location = new System.Drawing.Point(12, 76);
            this.dataGridViewSpaces.Name = "dataGridViewSpaces";
            this.dataGridViewSpaces.Size = new System.Drawing.Size(992, 477);
            this.dataGridViewSpaces.TabIndex = 14;
            // 
            // labelNameSpaces
            // 
            this.labelNameSpaces.AutoSize = true;
            this.labelNameSpaces.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.labelNameSpaces.Location = new System.Drawing.Point(12, 47);
            this.labelNameSpaces.Name = "labelNameSpaces";
            this.labelNameSpaces.Size = new System.Drawing.Size(87, 26);
            this.labelNameSpaces.TabIndex = 15;
            this.labelNameSpaces.Text = "Espacios";
            // 
            // roundedButtonEdit
            // 
            this.roundedButtonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonEdit.FlatAppearance.BorderSize = 0;
            this.roundedButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonEdit.Font = new System.Drawing.Font("Nunito Medium", 10F);
            this.roundedButtonEdit.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonEdit.Location = new System.Drawing.Point(417, 8);
            this.roundedButtonEdit.Name = "roundedButtonEdit";
            this.roundedButtonEdit.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonEdit.TabIndex = 40;
            this.roundedButtonEdit.Text = "Modificar";
            this.roundedButtonEdit.UseVisualStyleBackColor = false;
            // 
            // roundedButtonCreate
            // 
            this.roundedButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonCreate.FlatAppearance.BorderSize = 0;
            this.roundedButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonCreate.Font = new System.Drawing.Font("Nunito Medium", 10F);
            this.roundedButtonCreate.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonCreate.Location = new System.Drawing.Point(600, 8);
            this.roundedButtonCreate.Name = "roundedButtonCreate";
            this.roundedButtonCreate.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonCreate.TabIndex = 41;
            this.roundedButtonCreate.Text = "Crear";
            this.roundedButtonCreate.UseVisualStyleBackColor = false;
            // 
            // roundedButtonReserve
            // 
            this.roundedButtonReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonReserve.FlatAppearance.BorderSize = 0;
            this.roundedButtonReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonReserve.Font = new System.Drawing.Font("Nunito Medium", 10F);
            this.roundedButtonReserve.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonReserve.Location = new System.Drawing.Point(782, 8);
            this.roundedButtonReserve.Name = "roundedButtonReserve";
            this.roundedButtonReserve.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonReserve.TabIndex = 42;
            this.roundedButtonReserve.Text = "Reservar";
            this.roundedButtonReserve.UseVisualStyleBackColor = false;
            // 
            // FormSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 565);
            this.Controls.Add(this.roundedButtonReserve);
            this.Controls.Add(this.roundedButtonCreate);
            this.Controls.Add(this.roundedButtonEdit);
            this.Controls.Add(this.labelNameSpaces);
            this.Controls.Add(this.dataGridViewSpaces);
            this.Name = "FormSpace";
            this.Text = "FormSpace";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewSpaces;
        private Label labelNameSpaces;
        private Controls.RoundedButton roundedButtonEdit;
        private Controls.RoundedButton roundedButtonCreate;
        private Controls.RoundedButton roundedButtonReserve;
    }
}