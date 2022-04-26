﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningSpace
{
    public partial class MenuForm : Form
    {
        Thread th;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonNodes_Click(object sender, EventArgs e)
        {
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Close();

        }
        private void openNewForm()
        {
            Application.Run(new Nodes());
        }
    }
}
