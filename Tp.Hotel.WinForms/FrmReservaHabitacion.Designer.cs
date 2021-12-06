
namespace Tp.Hotel.WinForms
{
    partial class FrmReservaHabitacion
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
            this._lstHoteles = new System.Windows.Forms.ListBox();
            this.cmbHoteles = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this._btnVolver = new System.Windows.Forms.Button();
            this._btnLimpiar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lstHoteles
            // 
            this._lstHoteles.FormattingEnabled = true;
            this._lstHoteles.ItemHeight = 16;
            this._lstHoteles.Location = new System.Drawing.Point(29, 150);
            this._lstHoteles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lstHoteles.Name = "_lstHoteles";
            this._lstHoteles.Size = new System.Drawing.Size(432, 228);
            this._lstHoteles.TabIndex = 1;
            // 
            // cmbHoteles
            // 
            this.cmbHoteles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoteles.FormattingEnabled = true;
            this.cmbHoteles.Location = new System.Drawing.Point(35, 98);
            this.cmbHoteles.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHoteles.Name = "cmbHoteles";
            this.cmbHoteles.Size = new System.Drawing.Size(426, 24);
            this.cmbHoteles.TabIndex = 0;
            this.cmbHoteles.DropDownClosed += new System.EventHandler(this.cmbHabitaciones_Select);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFiltrar.Location = new System.Drawing.Point(69, 66);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(159, 20);
            this.lblFiltrar.TabIndex = 32;
            this.lblFiltrar.Text = "Seleccione el Hotel:";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.BackColor = System.Drawing.Color.MediumPurple;
            this.lblHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitaciones.Location = new System.Drawing.Point(67, 11);
            this.lblHabitaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(184, 31);
            this.lblHabitaciones.TabIndex = 31;
            this.lblHabitaciones.Text = "Habitaciones";
            // 
            // _btnVolver
            // 
            this._btnVolver.BackColor = System.Drawing.Color.BlueViolet;
            this._btnVolver.Location = new System.Drawing.Point(360, 398);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(141, 27);
            this._btnVolver.TabIndex = 4;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = false;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.BackColor = System.Drawing.Color.BlueViolet;
            this._btnLimpiar.Location = new System.Drawing.Point(197, 398);
            this._btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(141, 27);
            this._btnLimpiar.TabIndex = 3;
            this._btnLimpiar.Text = "Limpiar";
            this._btnLimpiar.UseVisualStyleBackColor = false;
            this._btnLimpiar.Click += new System.EventHandler(this._btnLimpiar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.BlueViolet;
            this.btnSeleccionar.Location = new System.Drawing.Point(5, 398);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(141, 27);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_click);
            // 
            // FrmReservaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(516, 554);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._lstHoteles);
            this.Controls.Add(this.cmbHoteles);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this._btnVolver);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReservaHabitacion";
            this.Text = "ReservaHabitacion";
            this.Load += new System.EventHandler(this.FrmReservaHabitacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _lstHoteles;
        private System.Windows.Forms.ComboBox cmbHoteles;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}