﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void Splashtimer_Tick(object sender, EventArgs e)
        {
            Program.generateNameForm.Show();
            this.Hide();
            Splashtimer.Enabled = false;
        }
    }
}
