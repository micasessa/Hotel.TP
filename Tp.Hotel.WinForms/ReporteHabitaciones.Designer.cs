namespace Tp.Hotel.WinForms
{
    partial class FrmReporteHabitaciones
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
            this._lblRepoSeleccioneHotel = new System.Windows.Forms.Label();
            this._cBoxRepoSeleccioneHotel = new System.Windows.Forms.ComboBox();
            this._lBoxHabitacionesPorHotel = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _lblRepoSeleccioneHotel
            // 
            this._lblRepoSeleccioneHotel.AutoSize = true;
            this._lblRepoSeleccioneHotel.Location = new System.Drawing.Point(59, 65);
            this._lblRepoSeleccioneHotel.Name = "_lblRepoSeleccioneHotel";
            this._lblRepoSeleccioneHotel.Size = new System.Drawing.Size(110, 16);
            this._lblRepoSeleccioneHotel.TabIndex = 0;
            this._lblRepoSeleccioneHotel.Text = "Seleccione Hotel";
            // 
            // _cBoxRepoSeleccioneHotel
            // 
            this._cBoxRepoSeleccioneHotel.FormattingEnabled = true;
            this._cBoxRepoSeleccioneHotel.Location = new System.Drawing.Point(219, 61);
            this._cBoxRepoSeleccioneHotel.Name = "_cBoxRepoSeleccioneHotel";
            this._cBoxRepoSeleccioneHotel.Size = new System.Drawing.Size(528, 24);
            this._cBoxRepoSeleccioneHotel.TabIndex = 1;
            // 
            // _lBoxHabitacionesPorHotel
            // 
            this._lBoxHabitacionesPorHotel.FormattingEnabled = true;
            this._lBoxHabitacionesPorHotel.ItemHeight = 16;
            this._lBoxHabitacionesPorHotel.Location = new System.Drawing.Point(60, 125);
            this._lBoxHabitacionesPorHotel.Name = "_lBoxHabitacionesPorHotel";
            this._lBoxHabitacionesPorHotel.Size = new System.Drawing.Size(686, 276);
            this._lBoxHabitacionesPorHotel.TabIndex = 2;
            // 
            // FrmReporteHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lBoxHabitacionesPorHotel);
            this.Controls.Add(this._cBoxRepoSeleccioneHotel);
            this.Controls.Add(this._lblRepoSeleccioneHotel);
            this.Name = "FrmReporteHabitaciones";
            this.Text = "Reporte Habitaciones Por Hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblRepoSeleccioneHotel;
        private System.Windows.Forms.ComboBox _cBoxRepoSeleccioneHotel;
        private System.Windows.Forms.ListBox _lBoxHabitacionesPorHotel;
    }
}