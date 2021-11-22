namespace Tp.Hotel.WinForms
{
    partial class FrmReporteHuespedes
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
            this._lBoxHuespedesPorReserva = new System.Windows.Forms.ListBox();
            this._cBoxRepoSeleccioneReserva = new System.Windows.Forms.ComboBox();
            this._lblRepoSeleccioneReserva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Location = new System.Drawing.Point(648, 43);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(74, 24);
            this._btnLimpiar.TabIndex = 20;
            this._btnLimpiar.Text = "Limpiar";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // _txtBoxTotalHabitaciones
            // 
            this._txtBoxTotalHabitaciones.Enabled = false;
            this._txtBoxTotalHabitaciones.Location = new System.Drawing.Point(202, 376);
            this._txtBoxTotalHabitaciones.Name = "_txtBoxTotalHabitaciones";
            this._txtBoxTotalHabitaciones.Size = new System.Drawing.Size(102, 22);
            this._txtBoxTotalHabitaciones.TabIndex = 19;
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(607, 375);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(136, 32);
            this._btnVolver.TabIndex = 18;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            // 
            // _lblTotalHabitaciones
            // 
            this._lblTotalHabitaciones.AutoSize = true;
            this._lblTotalHabitaciones.Location = new System.Drawing.Point(59, 379);
            this._lblTotalHabitaciones.Name = "_lblTotalHabitaciones";
            this._lblTotalHabitaciones.Size = new System.Drawing.Size(118, 16);
            this._lblTotalHabitaciones.TabIndex = 17;
            this._lblTotalHabitaciones.Text = "Total Huéspedes: ";
            // 
            // _lBoxHuespedesPorReserva
            // 
            this._lBoxHuespedesPorReserva.BackColor = System.Drawing.Color.MintCream;
            this._lBoxHuespedesPorReserva.FormattingEnabled = true;
            this._lBoxHuespedesPorReserva.ItemHeight = 16;
            this._lBoxHuespedesPorReserva.Location = new System.Drawing.Point(58, 108);
            this._lBoxHuespedesPorReserva.Name = "_lBoxHuespedesPorReserva";
            this._lBoxHuespedesPorReserva.Size = new System.Drawing.Size(686, 244);
            this._lBoxHuespedesPorReserva.TabIndex = 16;
            // 
            // _cBoxRepoSeleccioneReserva
            // 
            this._cBoxRepoSeleccioneReserva.FormattingEnabled = true;
            this._cBoxRepoSeleccioneReserva.Location = new System.Drawing.Point(217, 44);
            this._cBoxRepoSeleccioneReserva.Name = "_cBoxRepoSeleccioneReserva";
            this._cBoxRepoSeleccioneReserva.Size = new System.Drawing.Size(404, 24);
            this._cBoxRepoSeleccioneReserva.TabIndex = 15;
            // 
            // _lblRepoSeleccioneReserva
            // 
            this._lblRepoSeleccioneReserva.AutoSize = true;
            this._lblRepoSeleccioneReserva.Location = new System.Drawing.Point(57, 48);
            this._lblRepoSeleccioneReserva.Name = "_lblRepoSeleccioneReserva";
            this._lblRepoSeleccioneReserva.Size = new System.Drawing.Size(130, 16);
            this._lblRepoSeleccioneReserva.TabIndex = 14;
            this._lblRepoSeleccioneReserva.Text = "Seleccione Reserva";
            // 
            // ReporteHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._txtBoxTotalHabitaciones);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._lblTotalHabitaciones);
            this.Controls.Add(this._lBoxHuespedesPorReserva);
            this.Controls.Add(this._cBoxRepoSeleccioneReserva);
            this.Controls.Add(this._lblRepoSeleccioneReserva);
            this.Name = "ReporteHuespedes";
            this.Text = "Reporte Huespedes por Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.TextBox _txtBoxTotalHabitaciones;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Label _lblTotalHabitaciones;
        private System.Windows.Forms.ListBox _lBoxHuespedesPorReserva;
        private System.Windows.Forms.ComboBox _cBoxRepoSeleccioneReserva;
        private System.Windows.Forms.Label _lblRepoSeleccioneReserva;
    }
}