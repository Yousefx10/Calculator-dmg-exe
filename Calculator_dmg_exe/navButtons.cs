﻿using Calculator_dmg_exe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_dmg_exe
{
    public partial class navButtons : UserControl
    {
        public navButtons()
        {
            InitializeComponent();
        }

        private void ico_red_MouseEnter(object sender, EventArgs e)
        {
            ico_red.Image       = Resources.R2;
            ico_yellow.Image    = Resources.Y2;
            ico_green.Image     = Resources.G2;
        }

        private void ico_red_MouseLeave(object sender, EventArgs e)
        {
            ico_red.Image       = Resources.R1;
            ico_yellow.Image    = Resources.Y1;
            ico_green.Image     = Resources.G1;
        }
    }
}
