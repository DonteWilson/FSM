using System;
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
        IO _Save = new IO();
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

            //if (refer.Control.FSM.state == i_STATES.PTURN)
            //{
            //    index = refer.currentUnitIndex;

            //    //Battle party sorted by speed to produce attack order 
            //    refer.u.member = refer.Control.Speed(refer.BattleGroup);

            //    for (int i = 0; i < refer.u.member.Count; i++)
            //    {
            //        BattleOrderTextBox.Text += "\n" + refer.u.member[i].Name + "\n";
            //    }

            //    setCharIcon(refer.u.member);

            //   Start.Enabled = false;

            //    refer.Control.Statsofobjects(refer.u.member);

            //    StatsBox.Text = refer.Control.statsText;

            //    foreach (Unit i in refer.u.member)
            //    {
            //        if (i.Type == "Player")
            //        {
            //            Party.Add(i);

            //        }
            //        if (i.Type == "Enemy")
            //        {
            //            Eparty.Add(i);

            //        }
            //    }
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
            State.Multiline = true;
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

        private void Form2_Load(object sender, EventArgs e)
        {
            count = refer.u.member.Count - 1;
            index = 0;

            State.Text = refer.Control.FSM.state.ToString();
        }
    }
}
