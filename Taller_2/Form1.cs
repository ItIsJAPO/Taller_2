﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Taller_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 test = new Form2();
            test.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
