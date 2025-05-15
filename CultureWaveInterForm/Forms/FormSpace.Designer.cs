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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSpaces = new System.Windows.Forms.DataGridView();
            this.labelSpaces = new System.Windows.Forms.Label();
            this.roundedButtonCreate = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonEdit = new CultureWave_Form.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaces)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSpaces
            // 
            this.dataGridViewSpaces.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.dataGridViewSpaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSpaces.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSpaces.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewSpaces.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSpaces.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSpaces.ColumnHeadersHeight = 56;
            this.dataGridViewSpaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSpaces.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSpaces.EnableHeadersVisualStyles = false;
            this.dataGridViewSpaces.Location = new System.Drawing.Point(12, 76);
            this.dataGridViewSpaces.MultiSelect = false;
            this.dataGridViewSpaces.Name = "dataGridViewSpaces";
            this.dataGridViewSpaces.RowHeadersVisible = false;
            this.dataGridViewSpaces.RowHeadersWidth = 51;
            this.dataGridViewSpaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSpaces.Size = new System.Drawing.Size(992, 477);
            this.dataGridViewSpaces.TabIndex = 5;
            this.dataGridViewSpaces.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewSpaces_CellFormatting);
            // 
            // labelSpaces
            // 
            this.labelSpaces.AutoSize = true;
            this.labelSpaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelSpaces.Location = new System.Drawing.Point(12, 47);
            this.labelSpaces.Name = "labelSpaces";
            this.labelSpaces.Size = new System.Drawing.Size(95, 24);
            this.labelSpaces.TabIndex = 15;
            this.labelSpaces.Text = "Espacios";
            // 
            // roundedButtonCreate
            // 
            this.roundedButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonCreate.FlatAppearance.BorderSize = 0;
            this.roundedButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roundedButtonCreate.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonCreate.Location = new System.Drawing.Point(878, 10);
            this.roundedButtonCreate.Name = "roundedButtonCreate";
            this.roundedButtonCreate.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonCreate.TabIndex = 41;
            this.roundedButtonCreate.Text = "Crear";
            this.roundedButtonCreate.UseVisualStyleBackColor = false;
            this.roundedButtonCreate.Click += new System.EventHandler(this.roundedButtonCreate_Click);
            // 
            // roundedButtonEdit
            // 
            this.roundedButtonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonEdit.FlatAppearance.BorderSize = 0;
            this.roundedButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roundedButtonEdit.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonEdit.Location = new System.Drawing.Point(730, 11);
            this.roundedButtonEdit.Name = "roundedButtonEdit";
            this.roundedButtonEdit.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonEdit.TabIndex = 40;
            this.roundedButtonEdit.Text = "Modificar";
            this.roundedButtonEdit.UseVisualStyleBackColor = false;
            this.roundedButtonEdit.Click += new System.EventHandler(this.roundedButtonEdit_Click);
            // 
            // FormSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 565);
            this.Controls.Add(this.roundedButtonCreate);
            this.Controls.Add(this.roundedButtonEdit);
            this.Controls.Add(this.labelSpaces);
            this.Controls.Add(this.dataGridViewSpaces);
            this.Name = "FormSpace";
            this.Text = "FormSpace";
            this.Load += new System.EventHandler(this.FormSpace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewSpaces;
        private Label labelSpaces;
        private Controls.RoundedButton roundedButtonEdit;
        private Controls.RoundedButton roundedButtonCreate;
    }
}