﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin"&& textBox2.Text == "admin")
            {
                Form1.ActiveForm.Hide();
                Form2 fr2 = new Form2();
                fr2.Show();
            }
            else
            {
                MessageBox.Show("Username ve ya Password Duzgun Deyl!!!");
            }
        }
    }
}
