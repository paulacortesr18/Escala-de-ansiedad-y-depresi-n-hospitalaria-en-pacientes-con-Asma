﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion
{
    public partial class Escala_Ansiedad_Depresión_Hospitalaria : Form
    {
        public Escala_Ansiedad_Depresión_Hospitalaria()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            var frm = new Escala_Ansiedad_Depresión_Hospitalaria2();
            frm.Show();
            this.Hide();
        }
    }
}
