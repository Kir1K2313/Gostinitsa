﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gostinitsa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void filtrpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void filtrbutton_Click(object sender, EventArgs e)
        {
            if (filtrpanel.Height < 416)
            {
                filtrpanel.Height = 416;
            }

            else
            {
                filtrpanel.Height = 40;
            }

        
    }
}
