﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FSM_Test
{
    public partial class Form2 : Form
    {
        int index;
        int count;

        List<Unit> Party = new List<Unit>();
        List<Unit> Eparty = new List<Unit>();

        public Form1 refer;
        public Form2(Form1 parent)
        {
            refer = parent;
            parent.Visible = false;

            InitializeComponent();

        }
        private void Start_Click(object sender, EventArgs e)
        {
            
        }
        private void LDash_Click(object sender, EventArgs e)
        {

        }
        private void Agony_Click(object sender, EventArgs e)
        {

        }
        private void GodW_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Multiline = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Multiline = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
