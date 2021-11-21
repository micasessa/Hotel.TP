namespace Tp.Hotel.WinForms
{
    partial class ReporteReservas
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
            this._btnLimpiar.Location = new System.Drawing.Point(648, 43);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(74, 24);
            this._btnLimpiar.TabIndex = 13;
            this._btnLimpiar.Text = "Limpiar";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // _txtBoxTotalHabitaciones
            // 
            this._txtBoxTotalHabitaciones.Enabled = false;
            this._txtBoxTotalHabitaciones.Location = new System.Drawing.Point(202, 376);
            this._txtBoxTotalHabitaciones.Name = "_txtBoxTotalHabitaciones";
            this._txtBoxTotalHabitaciones.Size = new System.Drawing.Size(102, 22);
            this._txtBoxTotalHabitaciones.TabIndex = 12;
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(607, 375);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(136, 32);
            this._btnVolver.TabIndex = 11;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            // 
            // _lblTotalHabitaciones
            // 
            this._lblTotalHabitaciones.AutoSize = true;
            this._lblTotalHabitaciones.Location = new System.Drawing.Point(59, 379);
            this._lblTotalHabitaciones.Name = "_lblTotalHabitaciones";
            this._lblTotalHabitaciones.Size = new System.Drawing.Size(106, 16);
            this._lblTotalHabitaciones.TabIndex = 10;
            this._lblTotalHabitaciones.Text = "Total Reservas: ";
            // 
            // _lBoxReservasPorCliente
            // 
            this._lBoxReservasPorCliente.FormattingEnabled = true;
            this._lBoxReservasPorCliente.ItemHeight = 16;
            this._lBoxReservasPorCliente.Location = new System.Drawing.Point(58, 108);
            this._lBoxReservasPorCliente.Name = "_lBoxReservasPorCliente";
            this._lBoxReservasPorCliente.Size = new System.Drawing.Size(686, 244);
            this._lBoxReservasPorCliente.TabIndex = 9;
            // 
            // _cBoxRepoSeleccioneCliente
            // 
            this._cBoxRepoSeleccioneCliente.FormattingEnabled = true;
            this._cBoxRepoSeleccioneCliente.Location = new System.Drawing.Point(217, 44);
            this._cBoxRepoSeleccioneCliente.Name = "_cBoxRepoSeleccioneCliente";
            this._cBoxRepoSeleccioneCliente.Size = new System.Drawing.Size(404, 24);
            this._cBoxRepoSeleccioneCliente.TabIndex = 8;
            // 
            // _lblRepoSeleccioneCliente
            // 
            this._lblRepoSeleccioneCliente.AutoSize = true;
            this._lblRepoSeleccioneCliente.Location = new System.Drawing.Point(57, 48);
            this._lblRepoSeleccioneCliente.Name = "_lblRepoSeleccioneCliente";
            this._lblRepoSeleccioneCliente.Size = new System.Drawing.Size(119, 16);
            this._lblRepoSeleccioneCliente.TabIndex = 7;
            this._lblRepoSeleccioneCliente.Text = "Seleccione Cliente";
            // 
            // ReporteReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._txtBoxTotalHabitaciones);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._lblTotalHabitaciones);
            this.Controls.Add(this._lBoxReservasPorCliente);
            this.Controls.Add(this._cBoxRepoSeleccioneCliente);
            this.Controls.Add(this._lblRepoSeleccioneCliente);
            this.Name = "ReporteReservas";
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