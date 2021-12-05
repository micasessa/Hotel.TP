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
            this._lstHuespedes = new System.Windows.Forms.ListBox();
            this.cboxSelecReserva = new System.Windows.Forms.ComboBox();
            this._lblRepoSeleccioneReserva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Location = new System.Drawing.Point(669, 78);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(74, 24);
            this._btnLimpiar.TabIndex = 1;
            this._btnLimpiar.Text = "Limpiar";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            this._btnLimpiar.Click += new System.EventHandler(this._btnLimpiar_Click);
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
            this._btnVolver.Location = new System.Drawing.Point(607, 365);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(136, 32);
            this._btnVolver.TabIndex = 3;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
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
            // _lstHuespedes
            // 
            this._lstHuespedes.BackColor = System.Drawing.Color.MintCream;
            this._lstHuespedes.FormattingEnabled = true;
            this._lstHuespedes.ItemHeight = 16;
            this._lstHuespedes.Location = new System.Drawing.Point(58, 108);
            this._lstHuespedes.Name = "_lstHuespedes";
            this._lstHuespedes.Size = new System.Drawing.Size(686, 244);
            this._lstHuespedes.TabIndex = 2;
            // 
            // cboxSelecReserva
            // 
            this.cboxSelecReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSelecReserva.FormattingEnabled = true;
            this.cboxSelecReserva.Location = new System.Drawing.Point(196, 44);
            this.cboxSelecReserva.Name = "cboxSelecReserva";
            this.cboxSelecReserva.Size = new System.Drawing.Size(548, 24);
            this.cboxSelecReserva.TabIndex = 0;
            this.cboxSelecReserva.DropDownClosed += new System.EventHandler(this.HuespedesxRerserva);
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
            // FrmReporteHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._txtBoxTotalHabitaciones);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._lblTotalHabitaciones);
            this.Controls.Add(this._lstHuespedes);
            this.Controls.Add(this.cboxSelecReserva);
            this.Controls.Add(this._lblRepoSeleccioneReserva);
            this.Name = "FrmReporteHuespedes";
            this.Text = "Reporte Huespedes por Reserva";
            this.Load += new System.EventHandler(this.FrmLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.TextBox _txtBoxTotalHabitaciones;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Label _lblTotalHabitaciones;
        private System.Windows.Forms.ListBox _lstHuespedes;
        private System.Windows.Forms.ComboBox cboxSelecReserva;
        private System.Windows.Forms.Label _lblRepoSeleccioneReserva;
    }
}