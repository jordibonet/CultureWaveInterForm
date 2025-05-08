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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelNameReserves = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.dataGridViewReserves = new System.Windows.Forms.DataGridView();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.roundedButtonSearch = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonDeleteReserve = new CultureWave_Form.Controls.RoundedButton();
            this.roundedButtonReserve = new CultureWave_Form.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserves)).BeginInit();
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
            // dataGridViewReserves
            // 
            this.dataGridViewReserves.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.dataGridViewReserves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReserves.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewReserves.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewReserves.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(93)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReserves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReserves.ColumnHeadersHeight = 56;
            this.dataGridViewReserves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReserves.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReserves.EnableHeadersVisualStyles = false;
            this.dataGridViewReserves.Location = new System.Drawing.Point(12, 159);
            this.dataGridViewReserves.MultiSelect = false;
            this.dataGridViewReserves.Name = "dataGridViewReserves";
            this.dataGridViewReserves.RowHeadersVisible = false;
            this.dataGridViewReserves.RowHeadersWidth = 51;
            this.dataGridViewReserves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReserves.Size = new System.Drawing.Size(992, 394);
            this.dataGridViewReserves.TabIndex = 5;
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(16, 49);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(295, 28);
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
            this.roundedButtonDeleteReserve.Location = new System.Drawing.Point(878, 31);
            this.roundedButtonDeleteReserve.Name = "roundedButtonDeleteReserve";
            this.roundedButtonDeleteReserve.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonDeleteReserve.TabIndex = 40;
            this.roundedButtonDeleteReserve.Text = "Eliminar Reserva";
            this.roundedButtonDeleteReserve.UseVisualStyleBackColor = false;
            this.roundedButtonDeleteReserve.Click += new System.EventHandler(this.roundedButtonDeleteReserve_Click);
            // 
            // roundedButtonReserve
            // 
            this.roundedButtonReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(99)))));
            this.roundedButtonReserve.FlatAppearance.BorderSize = 0;
            this.roundedButtonReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roundedButtonReserve.ForeColor = System.Drawing.Color.Black;
            this.roundedButtonReserve.Location = new System.Drawing.Point(723, 31);
            this.roundedButtonReserve.Name = "roundedButtonReserve";
            this.roundedButtonReserve.Size = new System.Drawing.Size(126, 60);
            this.roundedButtonReserve.TabIndex = 39;
            this.roundedButtonReserve.Text = "Reservar";
            this.roundedButtonReserve.UseVisualStyleBackColor = false;
            this.roundedButtonReserve.Click += new System.EventHandler(this.roundedButtonReserve_Click);
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
            this.Controls.Add(this.dataGridViewReserves);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelNameReserves);
            this.Name = "FormReserve";
            this.Text = "FormReserve";
            this.Load += new System.EventHandler(this.FormReserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNameReserves;
        private Label labelUser;
        private DataGridView dataGridViewReserves;
        private Controls.RoundedButton roundedButtonReserve;
        private Controls.RoundedButton roundedButtonDeleteReserve;
        private Controls.RoundedButton roundedButtonSearch;
        private ComboBox comboBoxUsers;
    }
}