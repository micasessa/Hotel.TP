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
            this._lblRepoSeleccioneHotel.Location = new System.Drawing.Point(63, 60);
            this._lblRepoSeleccioneHotel.Name = "_lblRepoSeleccioneHotel";
            this._lblRepoSeleccioneHotel.Size = new System.Drawing.Size(129, 20);
            this._lblRepoSeleccioneHotel.TabIndex = 0;
            this._lblRepoSeleccioneHotel.Text = "Seleccione Hotel";
            // 
            // _cbxSelecHotel
            // 
            this._cbxSelecHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxSelecHotel.FormattingEnabled = true;
            this._cbxSelecHotel.Location = new System.Drawing.Point(243, 55);
            this._cbxSelecHotel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cbxSelecHotel.Name = "_cbxSelecHotel";
            this._cbxSelecHotel.Size = new System.Drawing.Size(454, 28);
            this._cbxSelecHotel.TabIndex = 1;
            this._cbxSelecHotel.DropDownClosed += new System.EventHandler(this.CargaHotelesxid);
            // 
            // _lstHabitaciones
            // 
            this._lstHabitaciones.FormattingEnabled = true;
            this._lstHabitaciones.ItemHeight = 20;
            this._lstHabitaciones.Location = new System.Drawing.Point(64, 135);
            this._lstHabitaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._lstHabitaciones.Name = "_lstHabitaciones";
            this._lstHabitaciones.Size = new System.Drawing.Size(771, 304);
            this._lstHabitaciones.TabIndex = 2;
            // 
            // _lblTotalHabitaciones
            // 
            this._lblTotalHabitaciones.AutoSize = true;
            this._lblTotalHabitaciones.Location = new System.Drawing.Point(65, 474);
            this._lblTotalHabitaciones.Name = "_lblTotalHabitaciones";
            this._lblTotalHabitaciones.Size = new System.Drawing.Size(149, 20);
            this._lblTotalHabitaciones.TabIndex = 3;
            this._lblTotalHabitaciones.Text = "Total Habitaciones: ";
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(682, 469);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(153, 40);
            this._btnVolver.TabIndex = 4;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _txtBoxTotalHabitaciones
            // 
            this._txtBoxTotalHabitaciones.Enabled = false;
            this._txtBoxTotalHabitaciones.Location = new System.Drawing.Point(226, 470);
            this._txtBoxTotalHabitaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._txtBoxTotalHabitaciones.Name = "_txtBoxTotalHabitaciones";
            this._txtBoxTotalHabitaciones.Size = new System.Drawing.Size(114, 26);
            this._txtBoxTotalHabitaciones.TabIndex = 5;
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Location = new System.Drawing.Point(728, 54);
            this._btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(83, 30);
            this._btnLimpiar.TabIndex = 6;
            this._btnLimpiar.Text = "Limpiar";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            this._btnLimpiar.Click += new System.EventHandler(this._btnLimpiar_Click);
            // 
            // FrmReporteHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._txtBoxTotalHabitaciones);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._lblTotalHabitaciones);
            this.Controls.Add(this._lstHabitaciones);
            this.Controls.Add(this._cbxSelecHotel);
            this.Controls.Add(this._lblRepoSeleccioneHotel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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