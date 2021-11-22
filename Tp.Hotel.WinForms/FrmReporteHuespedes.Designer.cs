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
            this._btnLimpiar.Location = new System.Drawing.Point(729, 54);
            this._btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(83, 30);
            this._btnLimpiar.TabIndex = 20;
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
            this._txtBoxTotalHabitaciones.TabIndex = 19;
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(683, 469);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(153, 40);
            this._btnVolver.TabIndex = 18;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _lblTotalHabitaciones
            // 
            this._lblTotalHabitaciones.AutoSize = true;
            this._lblTotalHabitaciones.Location = new System.Drawing.Point(66, 474);
            this._lblTotalHabitaciones.Name = "_lblTotalHabitaciones";
            this._lblTotalHabitaciones.Size = new System.Drawing.Size(138, 20);
            this._lblTotalHabitaciones.TabIndex = 17;
            this._lblTotalHabitaciones.Text = "Total Huéspedes: ";
            // 
            // _lBoxHuespedesPorReserva
            // 
            this._lBoxHuespedesPorReserva.BackColor = System.Drawing.Color.MintCream;
            this._lBoxHuespedesPorReserva.FormattingEnabled = true;
            this._lBoxHuespedesPorReserva.ItemHeight = 20;
            this._lBoxHuespedesPorReserva.Location = new System.Drawing.Point(65, 135);
            this._lBoxHuespedesPorReserva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._lBoxHuespedesPorReserva.Name = "_lBoxHuespedesPorReserva";
            this._lBoxHuespedesPorReserva.Size = new System.Drawing.Size(771, 304);
            this._lBoxHuespedesPorReserva.TabIndex = 16;
            // 
            // _cBoxRepoSeleccioneReserva
            // 
            this._cBoxRepoSeleccioneReserva.FormattingEnabled = true;
            this._cBoxRepoSeleccioneReserva.Location = new System.Drawing.Point(244, 55);
            this._cBoxRepoSeleccioneReserva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cBoxRepoSeleccioneReserva.Name = "_cBoxRepoSeleccioneReserva";
            this._cBoxRepoSeleccioneReserva.Size = new System.Drawing.Size(454, 28);
            this._cBoxRepoSeleccioneReserva.TabIndex = 15;
            // 
            // _lblRepoSeleccioneReserva
            // 
            this._lblRepoSeleccioneReserva.AutoSize = true;
            this._lblRepoSeleccioneReserva.Location = new System.Drawing.Point(64, 60);
            this._lblRepoSeleccioneReserva.Name = "_lblRepoSeleccioneReserva";
            this._lblRepoSeleccioneReserva.Size = new System.Drawing.Size(150, 20);
            this._lblRepoSeleccioneReserva.TabIndex = 14;
            this._lblRepoSeleccioneReserva.Text = "Seleccione Reserva";
            // 
            // FrmReporteHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._txtBoxTotalHabitaciones);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._lblTotalHabitaciones);
            this.Controls.Add(this._lBoxHuespedesPorReserva);
            this.Controls.Add(this._cBoxRepoSeleccioneReserva);
            this.Controls.Add(this._lblRepoSeleccioneReserva);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReporteHuespedes";
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