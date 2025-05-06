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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelNameReserves = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.dataGridViewSpaces = new System.Windows.Forms.DataGridView();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.roundedButtonSearch = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonDeleteReserve = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonReserve = new CultureWave_Form.Controls.RoundedButton();
            this.roundedTextBoxUser = new CultureWave_Form.Controls.RoundedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaces)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameReserves
            // 
            this.labelNameReserves.AutoSize = true;
            this.labelNameReserves.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelNameReserves.Location = new System.Drawing.Point(12, 126);
            this.labelNameReserves.Name = "labelNameReserves";
            this.labelNameReserves.Size = new System.Drawing.Size(96, 24);
            this.labelNameReserves.TabIndex = 16;
            this.labelNameReserves.Text = "Reservas";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelUser.Location = new System.Drawing.Point(12, 18);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(81, 24);
            this.labelUser.TabIndex = 17;
            this.labelUser.Text = "Usuario";
            // 
            // dataGridViewSpaces
            // 
            this.dataGridViewSpaces.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.dataGridViewSpaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSpaces.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSpaces.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewSpaces.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSpaces.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSpaces.ColumnHeadersHeight = 56;
            this.dataGridViewSpaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSpaces.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSpaces.EnableHeadersVisualStyles = false;
            this.dataGridViewSpaces.Location = new System.Drawing.Point(12, 159);
            this.dataGridViewSpaces.MultiSelect = false;
            this.dataGridViewSpaces.Name = "dataGridViewSpaces";
            this.dataGridViewSpaces.RowHeadersVisible = false;
            this.dataGridViewSpaces.RowHeadersWidth = 51;
            this.dataGridViewSpaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSpaces.Size = new System.Drawing.Size(992, 394);
            this.dataGridViewSpaces.TabIndex = 5;
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(16, 99);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(295, 21);
            this.comboBoxUsers.TabIndex = 42;
            // 
            // roundedButtonSearch
            // 
            this.roundedButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonSearch.FlatAppearance.BorderSize = 0;
            this.roundedButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roundedButtonSearch.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonSearch.Location = new System.Drawing.Point(327, 31);
            this.roundedButtonSearch.Name = "roundedButtonSearch";
            this.roundedButtonSearch.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonSearch.TabIndex = 41;
            this.roundedButtonSearch.Text = "Buscar";
            this.roundedButtonSearch.UseVisualStyleBackColor = false;
            this.roundedButtonSearch.Click += new System.EventHandler(this.roundedButtonSearch_Click);
            // 
            // roundedButtonDeleteReserve
            // 
            this.roundedButtonDeleteReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonDeleteReserve.FlatAppearance.BorderSize = 0;
            this.roundedButtonDeleteReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonDeleteReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roundedButtonDeleteReserve.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonDeleteReserve.Location = new System.Drawing.Point(832, 31);
            this.roundedButtonDeleteReserve.Name = "roundedButtonDeleteReserve";
            this.roundedButtonDeleteReserve.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonDeleteReserve.TabIndex = 40;
            this.roundedButtonDeleteReserve.Text = "Eliminar Reserva";
            this.roundedButtonDeleteReserve.UseVisualStyleBackColor = false;
            // 
            // roundedButtonReserve
            // 
            this.roundedButtonReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonReserve.FlatAppearance.BorderSize = 0;
            this.roundedButtonReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roundedButtonReserve.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonReserve.Location = new System.Drawing.Point(598, 30);
            this.roundedButtonReserve.Name = "roundedButtonReserve";
            this.roundedButtonReserve.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonReserve.TabIndex = 39;
            this.roundedButtonReserve.Text = "Reservar";
            this.roundedButtonReserve.UseVisualStyleBackColor = false;
            this.roundedButtonReserve.Click += new System.EventHandler(this.roundedButtonReserve_Click);
            // 
            // roundedTextBoxUser
            // 
            this.roundedTextBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.roundedTextBoxUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            this.roundedTextBoxUser.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedTextBoxUser.BorderRadius = 20;
            this.roundedTextBoxUser.BorderSize = 3;
            this.roundedTextBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roundedTextBoxUser.Location = new System.Drawing.Point(13, 50);
            this.roundedTextBoxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roundedTextBoxUser.MaxLength = 43;
            this.roundedTextBoxUser.Multiline = false;
            this.roundedTextBoxUser.Name = "roundedTextBoxUser";
            this.roundedTextBoxUser.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.roundedTextBoxUser.PasswordChar = false;
            this.roundedTextBoxUser.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedTextBoxUser.PlaceholderText = "";
            this.roundedTextBoxUser.Size = new System.Drawing.Size(298, 41);
            this.roundedTextBoxUser.TabIndex = 20;
            this.roundedTextBoxUser.Texts = "";
            this.roundedTextBoxUser.UnderlinedStyle = false;
            // 
            // FormReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 565);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.roundedButtonSearch);
            this.Controls.Add(this.roundedButtonDeleteReserve);
            this.Controls.Add(this.roundedButtonReserve);
            this.Controls.Add(this.roundedTextBoxUser);
            this.Controls.Add(this.dataGridViewSpaces);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelNameReserves);
            this.Name = "FormReserve";
            this.Text = "FormReserve";
            this.Load += new System.EventHandler(this.FormReserve_Load);
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
        private Controls.RoundedButton roundedButtonSearch;
        private ComboBox comboBoxUsers;
    }
}