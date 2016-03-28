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
            //textBox2.Multiline = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //State.Multiline = true;
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
        public void Locate()
        {
            refer.u.member = refer.Control.Speed(refer.BattleGroup);

            for (int i = 0; i < refer.u.member.Count; i++)
            {
                FightSequence.Text += "\n" + refer.u.member[i].Name + "\n";
            }

            foreach (Unit i in refer.u.member)
            {
                if (i.Type == "Player")
                {
                    Party.Add(i);
                }
                if(i.Type == "Enemy")
                {
                    Eparty.Add(i);
                }
            }

            E1.Text = Eparty[0].Name;
            E2.Text = Eparty[1].Name;
            E3.Text = Eparty[2].Name;

            
        }
        public void Initiate()
        {
            refer.Control.stats = "";
            refer.Control.Objectstats(refer.u.member);

            OStats.Text = refer.Control.stats;

            
        }
        private void CharIcons(List<Unit> units)
        {
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i].Name == P1.Text)
                {
                    switch (units[i].Name)
                    {
                        case "Jittery":
                            P1p.Image = Properties.Resources.Jittery;
                            break;
                        case "Ryyul":
                            P1p.Image = Properties.Resources.Ryyul;
                            break;
                        case "Rory":
                            P1p.Image = Properties.Resources.Rory;
                            break;
                        case "Yato":
                            P1p.Image = Properties.Resources.Yato;
                            break;
                        case "Meteos":
                            P1p.Image = Properties.Resources.Meteos;
                            break;
                        case "Sneaky":
                            P1p.Image = Properties.Resources.Sneaky;
                            break;
                        default:
                            break;
                    }
                }
                if (units[i].Name == P2.Text)
                {
                    switch (units[i].Name)
                    {
                        case "Jittery":
                            P2p.Image = Properties.Resources.Jittery;
                            break;
                        case "Ryyul":
                            P2p.Image = Properties.Resources.Ryyul;
                            break;
                        case "Rory":
                            P2p.Image = Properties.Resources.Rory;
                            break;
                        case "Yato":
                            P2p.Image = Properties.Resources.Yato;
                            break;
                        case "Meteos":
                            P2p.Image = Properties.Resources.Meteos;
                            break;
                        case "Sneaky":
                            P2p.Image = Properties.Resources.Sneaky;
                            break;
                        default:
                            break;
                    }
                }
                if (units[i].Name == P3.Text)
                {
                    switch (units[i].Name)
                    {
                        case "Jittery":
                            P3p.Image = Properties.Resources.Jittery;
                            break;
                        case "Ryyul":
                            P3p.Image = Properties.Resources.Ryyul;
                            break;
                        case "Rory":
                            P3p.Image = Properties.Resources.Rory;
                            break;
                        case "Yato":
                            P3p.Image = Properties.Resources.Yato;
                            break;
                        case "Meteos":
                            P3p.Image = Properties.Resources.Meteos;
                            break;
                        case "Sneaky":
                            P3p.Image = Properties.Resources.Sneaky;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            count = refer.u.member.Count - 1;
            index = 0;
            index = refer.UnitIndex;

            P1.Text = refer.p1name;
            P2.Text = refer.p2name;
            P3.Text = refer.p3name;

            //refer.Control.FSM.Feed



            //CState.Text = refer.Control.FSM.state.ToString();
        }
    }
}
