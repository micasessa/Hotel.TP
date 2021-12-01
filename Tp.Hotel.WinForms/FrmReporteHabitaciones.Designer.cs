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
            this._cbxSelecHotel = new System.Windows.Forms.ComboBox();
            this._lstHabitaciones = new System.Windows.Forms.ListBox();
            this._lblTotalHabitaciones = new System.Windows.Forms.Label();
            this._btnVolver = new System.Windows.Forms.Button();
            this._txtBoxTotalHabitaciones = new System.Windows.Forms.TextBox();
            this._btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblRepoSeleccioneHotel
            // 
            this._lblRepoSeleccioneHotel.AutoSize = true;
            this._lblRepoSeleccioneHotel.Location = new System.Drawing.Point(56, 48);
            this._lblRepoSeleccioneHotel.Name = "_lblRepoSeleccioneHotel";
            this._lblRepoSeleccioneHotel.Size = new System.Drawing.Size(110, 16);
            this._lblRepoSeleccioneHotel.TabIndex = 0;
            this._lblRepoSeleccioneHotel.Text = "Seleccione Hotel";
            // 
            // _cbxSelecHotel
            // 
            this._cbxSelecHotel.FormattingEnabled = true;
            this._cbxSelecHotel.Location = new System.Drawing.Point(216, 44);
            this._cbxSelecHotel.Name = "_cbxSelecHotel";
            this._cbxSelecHotel.Size = new System.Drawing.Size(404, 24);
            this._cbxSelecHotel.TabIndex = 1;
            this._cbxSelecHotel.DropDownClosed += new System.EventHandler(this.CargaHotelesxid);
            // 
            // _lstHabitaciones
            // 
            this._lstHabitaciones.FormattingEnabled = true;
            this._lstHabitaciones.ItemHeight = 16;
            this._lstHabitaciones.Location = new System.Drawing.Point(57, 108);
            this._lstHabitaciones.Name = "_lstHabitaciones";
            this._lstHabitaciones.Size = new System.Drawing.Size(686, 244);
            this._lstHabitaciones.TabIndex = 2;
            // 
            // _lblTotalHabitaciones
            // 
            this._lblTotalHabitaciones.AutoSize = true;
            this._lblTotalHabitaciones.Location = new System.Drawing.Point(58, 379);
            this._lblTotalHabitaciones.Name = "_lblTotalHabitaciones";
            this._lblTotalHabitaciones.Size = new System.Drawing.Size(127, 16);
            this._lblTotalHabitaciones.TabIndex = 3;
            this._lblTotalHabitaciones.Text = "Total Habitaciones: ";
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(606, 375);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(136, 32);
            this._btnVolver.TabIndex = 4;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _txtBoxTotalHabitaciones
            // 
            this._txtBoxTotalHabitaciones.Enabled = false;
            this._txtBoxTotalHabitaciones.Location = new System.Drawing.Point(201, 376);
            this._txtBoxTotalHabitaciones.Name = "_txtBoxTotalHabitaciones";
            this._txtBoxTotalHabitaciones.Size = new System.Drawing.Size(102, 22);
            this._txtBoxTotalHabitaciones.TabIndex = 5;
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Location = new System.Drawing.Point(647, 43);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(74, 24);
            this._btnLimpiar.TabIndex = 6;
            this._btnLimpiar.Text = "Limpiar";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            this._btnLimpiar.Click += new System.EventHandler(this._btnLimpiar_Click);
            // 
            // FrmReporteHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._txtBoxTotalHabitaciones);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._lblTotalHabitaciones);
            this.Controls.Add(this._lstHabitaciones);
            this.Controls.Add(this._cbxSelecHotel);
            this.Controls.Add(this._lblRepoSeleccioneHotel);
            this.Name = "FrmReporteHabitaciones";
            this.Text = "Reporte Habitaciones Por Hotel";
            this.Load += new System.EventHandler(this.FrmLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblRepoSeleccioneHotel;
        private System.Windows.Forms.ComboBox _cbxSelecHotel;
        private System.Windows.Forms.ListBox _lstHabitaciones;
        private System.Windows.Forms.Label _lblTotalHabitaciones;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.TextBox _txtBoxTotalHabitaciones;
        private System.Windows.Forms.Button _btnLimpiar;
    }
}