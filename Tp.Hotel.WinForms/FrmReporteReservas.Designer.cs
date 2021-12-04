namespace Tp.Hotel.WinForms
{
    partial class FrmReporteReservas
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
            this._btnLimpiar = new System.Windows.Forms.Button();
            this._txtBoxTotalHabitaciones = new System.Windows.Forms.TextBox();
            this._btnVolver = new System.Windows.Forms.Button();
            this._lblTotalHabitaciones = new System.Windows.Forms.Label();
            this._lstReservaxCliente = new System.Windows.Forms.ListBox();
            this._cBoxSelCliente = new System.Windows.Forms.ComboBox();
            this._lblRepoSeleccioneCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Location = new System.Drawing.Point(729, 54);
            this._btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(83, 30);
            this._btnLimpiar.TabIndex = 13;
            this._btnLimpiar.Text = "Limpiar";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            this._btnLimpiar.Click += new System.EventHandler(this._btnLimpiar_Click);
            // 
            // _txtBoxTotalHabitaciones
            // 
            this._txtBoxTotalHabitaciones.Enabled = false;
            this._txtBoxTotalHabitaciones.Location = new System.Drawing.Point(227, 470);
            this._txtBoxTotalHabitaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtBoxTotalHabitaciones.Name = "_txtBoxTotalHabitaciones";
            this._txtBoxTotalHabitaciones.Size = new System.Drawing.Size(114, 26);
            this._txtBoxTotalHabitaciones.TabIndex = 12;
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(683, 469);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(153, 40);
            this._btnVolver.TabIndex = 11;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _lblTotalHabitaciones
            // 
            this._lblTotalHabitaciones.AutoSize = true;
            this._lblTotalHabitaciones.Location = new System.Drawing.Point(66, 474);
            this._lblTotalHabitaciones.Name = "_lblTotalHabitaciones";
            this._lblTotalHabitaciones.Size = new System.Drawing.Size(123, 20);
            this._lblTotalHabitaciones.TabIndex = 10;
            this._lblTotalHabitaciones.Text = "Total Reservas: ";
            // 
            // _lstReservaxCliente
            // 
            this._lstReservaxCliente.FormattingEnabled = true;
            this._lstReservaxCliente.ItemHeight = 20;
            this._lstReservaxCliente.Location = new System.Drawing.Point(65, 135);
            this._lstReservaxCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._lstReservaxCliente.Name = "_lstReservaxCliente";
            this._lstReservaxCliente.Size = new System.Drawing.Size(771, 304);
            this._lstReservaxCliente.TabIndex = 9;
            // 
            // _cBoxSelCliente
            // 
            this._cBoxSelCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cBoxSelCliente.FormattingEnabled = true;
            this._cBoxSelCliente.Location = new System.Drawing.Point(244, 55);
            this._cBoxSelCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cBoxSelCliente.Name = "_cBoxSelCliente";
            this._cBoxSelCliente.Size = new System.Drawing.Size(454, 28);
            this._cBoxSelCliente.TabIndex = 8;
            this._cBoxSelCliente.DropDownClosed += new System.EventHandler(this.cmbClientes_Click);
            // 
            // _lblRepoSeleccioneCliente
            // 
            this._lblRepoSeleccioneCliente.AutoSize = true;
            this._lblRepoSeleccioneCliente.Location = new System.Drawing.Point(64, 60);
            this._lblRepoSeleccioneCliente.Name = "_lblRepoSeleccioneCliente";
            this._lblRepoSeleccioneCliente.Size = new System.Drawing.Size(140, 20);
            this._lblRepoSeleccioneCliente.TabIndex = 7;
            this._lblRepoSeleccioneCliente.Text = "Seleccione Cliente";
            // 
            // FrmReporteReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._txtBoxTotalHabitaciones);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._lblTotalHabitaciones);
            this.Controls.Add(this._lstReservaxCliente);
            this.Controls.Add(this._cBoxSelCliente);
            this.Controls.Add(this._lblRepoSeleccioneCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReporteReservas";
            this.Text = "Reporte Reservas por Clientes";
            this.Load += new System.EventHandler(this.FrmLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.TextBox _txtBoxTotalHabitaciones;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Label _lblTotalHabitaciones;
        private System.Windows.Forms.ListBox _lstReservaxCliente;
        private System.Windows.Forms.ComboBox _cBoxSelCliente;
        private System.Windows.Forms.Label _lblRepoSeleccioneCliente;
    }
}