using System.Drawing;
using System.Windows.Forms;

namespace CultureWave_Form.Forms
{
    partial class FormUser
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.labelUsers = new System.Windows.Forms.Label();
            this.roundedButtonDelete = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonCreate = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonEdit = new CultureWave_Form.Controls.RoundedButton();
            this.roundedTextBoxEmail = new CultureWave_Form.Controls.RoundedTextBox();
            this.roundedButtonSearch = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonReset = new CultureWave_Form.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewUsers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsers.ColumnHeadersHeight = 56;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 99);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(992, 454);
            this.dataGridViewUsers.TabIndex = 5;
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelUsers.Location = new System.Drawing.Point(12, 66);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(91, 24);
            this.labelUsers.TabIndex = 26;
            this.labelUsers.Text = "Usuarios";
            // 
            // roundedButtonDelete
            // 
            this.roundedButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonDelete.FlatAppearance.BorderSize = 0;
            this.roundedButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roundedButtonDelete.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonDelete.Location = new System.Drawing.Point(878, 12);
            this.roundedButtonDelete.Name = "roundedButtonDelete";
            this.roundedButtonDelete.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonDelete.TabIndex = 45;
            this.roundedButtonDelete.Text = "Eliminar";
            this.roundedButtonDelete.UseVisualStyleBackColor = false;
            this.roundedButtonDelete.Click += new System.EventHandler(this.roundedButtonDelete_Click);
            // 
            // roundedButtonCreate
            // 
            this.roundedButtonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonCreate.FlatAppearance.BorderSize = 0;
            this.roundedButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roundedButtonCreate.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonCreate.Location = new System.Drawing.Point(736, 12);
            this.roundedButtonCreate.Name = "roundedButtonCreate";
            this.roundedButtonCreate.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonCreate.TabIndex = 44;
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
            this.roundedButtonEdit.Location = new System.Drawing.Point(595, 12);
            this.roundedButtonEdit.Name = "roundedButtonEdit";
            this.roundedButtonEdit.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonEdit.TabIndex = 43;
            this.roundedButtonEdit.Text = "Modificar";
            this.roundedButtonEdit.UseVisualStyleBackColor = false;
            this.roundedButtonEdit.Click += new System.EventHandler(this.roundedButtonEdit_Click);
            // 
            // roundedTextBoxEmail
            // 
            this.roundedTextBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxEmail.BorderRadius = 15;
            this.roundedTextBoxEmail.BorderSize = 2;
            this.roundedTextBoxEmail.Location = new System.Drawing.Point(16, 26);
            this.roundedTextBoxEmail.MaxLength = 43;
            this.roundedTextBoxEmail.Multiline = false;
            this.roundedTextBoxEmail.Name = "roundedTextBoxEmail";
            this.roundedTextBoxEmail.Padding = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.roundedTextBoxEmail.PasswordChar = false;
            this.roundedTextBoxEmail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxEmail.PlaceholderText = "";
            this.roundedTextBoxEmail.Size = new System.Drawing.Size(283, 32);
            this.roundedTextBoxEmail.TabIndex = 46;
            this.roundedTextBoxEmail.Texts = "";
            this.roundedTextBoxEmail.UnderlinedStyle = false;
            // 
            // roundedButtonSearch
            // 
            this.roundedButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonSearch.FlatAppearance.BorderSize = 0;
            this.roundedButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roundedButtonSearch.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonSearch.Location = new System.Drawing.Point(314, 12);
            this.roundedButtonSearch.Name = "roundedButtonSearch";
            this.roundedButtonSearch.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonSearch.TabIndex = 47;
            this.roundedButtonSearch.Text = "Buscar";
            this.roundedButtonSearch.UseVisualStyleBackColor = false;
            this.roundedButtonSearch.Click += new System.EventHandler(this.roundedButtonBuscar_Click);
            // 
            // roundedButtonReset
            // 
            this.roundedButtonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonReset.FlatAppearance.BorderSize = 0;
            this.roundedButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roundedButtonReset.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonReset.Location = new System.Drawing.Point(456, 12);
            this.roundedButtonReset.Name = "roundedButtonReset";
            this.roundedButtonReset.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonReset.TabIndex = 48;
            this.roundedButtonReset.Text = "Reset";
            this.roundedButtonReset.UseVisualStyleBackColor = false;
            this.roundedButtonReset.Click += new System.EventHandler(this.roundedButtonReset_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 565);
            this.Controls.Add(this.roundedButtonReset);
            this.Controls.Add(this.roundedButtonSearch);
            this.Controls.Add(this.roundedTextBoxEmail);
            this.Controls.Add(this.roundedButtonDelete);
            this.Controls.Add(this.roundedButtonCreate);
            this.Controls.Add(this.roundedButtonEdit);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.labelUsers);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridViewUsers;
        private Label labelUsers;
        private Controls.RoundedButton roundedButtonDelete;
        private Controls.RoundedButton roundedButtonCreate;
        private Controls.RoundedButton roundedButtonEdit;
        private Controls.RoundedTextBox roundedTextBoxEmail;
        private Controls.RoundedButton roundedButtonSearch;
        private Controls.RoundedButton roundedButtonReset;
    }
}