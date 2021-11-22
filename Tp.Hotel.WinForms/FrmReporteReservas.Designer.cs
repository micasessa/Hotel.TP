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
            this._lBoxReservasPorCliente = new System.Windows.Forms.ListBox();
            this._cBoxRepoSeleccioneCliente = new System.Windows.Forms.ComboBox();
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
            // _lBoxReservasPorCliente
            // 
            this._lBoxReservasPorCliente.FormattingEnabled = true;
            this._lBoxReservasPorCliente.ItemHeight = 20;
            this._lBoxReservasPorCliente.Location = new System.Drawing.Point(65, 135);
            this._lBoxReservasPorCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._lBoxReservasPorCliente.Name = "_lBoxReservasPorCliente";
            this._lBoxReservasPorCliente.Size = new System.Drawing.Size(771, 304);
            this._lBoxReservasPorCliente.TabIndex = 9;
            // 
            // _cBoxRepoSeleccioneCliente
            // 
            this._cBoxRepoSeleccioneCliente.FormattingEnabled = true;
            this._cBoxRepoSeleccioneCliente.Location = new System.Drawing.Point(244, 55);
            this._cBoxRepoSeleccioneCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cBoxRepoSeleccioneCliente.Name = "_cBoxRepoSeleccioneCliente";
            this._cBoxRepoSeleccioneCliente.Size = new System.Drawing.Size(454, 28);
            this._cBoxRepoSeleccioneCliente.TabIndex = 8;
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
            this.Controls.Add(this._lBoxReservasPorCliente);
            this.Controls.Add(this._cBoxRepoSeleccioneCliente);
            this.Controls.Add(this._lblRepoSeleccioneCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReporteReservas";
            this.Text = "Reporte Reservas por Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.TextBox _txtBoxTotalHabitaciones;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Label _lblTotalHabitaciones;
        private System.Windows.Forms.ListBox _lBoxReservasPorCliente;
        private System.Windows.Forms.ComboBox _cBoxRepoSeleccioneCliente;
        private System.Windows.Forms.Label _lblRepoSeleccioneCliente;
    }
}