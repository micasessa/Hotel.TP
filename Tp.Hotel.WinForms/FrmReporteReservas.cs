﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Tp.Hotel.WinForms
{
    public partial class FrmReporteReservas : Form
    {
        public FrmReporteReservas(Form main)
        {
            InitializeComponent();
            this.Owner = main;
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
