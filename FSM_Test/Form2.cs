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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Multiline = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //State.Multiline = true;
        }
        private void Attack1_Click(object sender, EventArgs e)
        {
            Unit a = refer.u.member[index];

            if(Eparty[0].Life == true)
            {
                a.Combat(Eparty[0]);
                CombatT.Text = a.stuff;

                if(index == count)
                {
                    index = 0;
                }
                else
                {
                    index += 1;
                }
            }
            if (refer.Control.Victorious(Party, Eparty) == true)
            {
                CombatT.Text += refer.Control.winText;

                Party party = new FSM_Test.Party();

                party.units = Party;

                foreach (Unit u in party.units)
                {
                    u.HP = u.MHP;

                    u.Life = true;
                }
                refer.Control.stats = "";
                refer.Control.Objectstats(refer.u.member);
                OStats.Text = refer.Control.stats;

                Attack1.Enabled = false;
                Attack2.Enabled = false;
                Attack3.Enabled = false;
                CState.Text = refer.Control.FSM.cState.name.ToString();
            }
            Engagement(index);

        }

        private void Attack2_Click(object sender, EventArgs e)
        {

        }

        private void Attack3_Click(object sender, EventArgs e)
        {

        }
    

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void Engagement(int num)
        {
            if (num == refer.u.member.Count)
            {
                num = 0;
                index = 0;
            }

            Enum state = i_STATES.FIGHT as Enum;

            if(refer.Control.FSM.cState.name != state)
            {
                refer.Control.FSM.Insert("fight");
            }

            if (refer.u.member[num].Type == "Player" && refer.u.member[num].Life == true)
            {
                CombatT.Text += refer.u.member[num].Name + "'s turn\n";

                refer.Control.FSM.Insert("SwitchPlayer");
            }
            else if (refer.u.member[num].Type == "Enemy" && refer.u.member[num].Life == true)
            {
                CombatT.Text += refer.u.member[num].Name + "'s turn\n";

                refer.Control.FSM.Insert("SwitchEnemy");
            }
            else
            {
                index += 1;
                Engagement(index);
            }
        }
        // First Blood
        private void FB(List<Unit> uList)
        {
            CombatT.Text += "It is " + uList[index].Name + "'s turn\n";

            if (refer.dState != null)
            {
                refer.Control.FSM.Insert(refer.dState);
            }
            else
            {
                if(uList[index].Type == "Enemy" && uList[index].Life == true)
                {
                    refer.Control.FSM.Insert("ETurn");
                }
                if(uList[index].Type == "Player" && uList[index].Life == true)
                {
                    refer.Control.FSM.Insert("PTurn");
                }
            }

            OStats.Text = refer.Control.stats;
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

            CharIcons(refer.u.member);

            refer.Control.Objectstats(refer.u.member);

            OStats.Text = refer.Control.stats;



            
        }
        public void PTurn()
        {
            Attack1.Enabled = true;
            Attack2.Enabled = true;
            Attack3.Enabled = true;

            CState.Text = refer.Control.FSM.cState.name.ToString();

        }
        public void ETurn()
        {
            Attack1.Enabled = false;
            Attack2.Enabled = false;
            Attack3.Enabled = false;

            CombatT.Text += refer.Control.FSM.cState.name.ToString() + "State \n";
            CState.Text = refer.Control.FSM.cState.name.ToString();

            if(refer.u.member[index].Type == "Enemy" && refer.u.member[index].Life == true)
            {
                Unit Fighter = refer.u.member[index];
                Unit Defender = Fighter.encounter(Party);

                Fighter.Combat(Defender);

                CombatT.Text += Fighter.stuff;
                if(index == count)
                {
                    index = 0;
                }
                else
                {
                    index += 1;
                }
            }
            if (refer.Control.Victorious(Party, Eparty) == true)
            {
                CombatT.Text += refer.Control.winText;

                refer.Control.stats = "";
                refer.Control.Objectstats(refer.u.member);
                OStats.Text = refer.Control.stats;

                Attack1.Enabled = false;
                Attack2.Enabled = false;
                Attack3.Enabled = false;

                CState.Text = refer.Control.FSM.cState.name.ToString();
            }
            Engagement(index);

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
            Attack1.Enabled = false;
            Attack2.Enabled = false;
            Attack3.Enabled = false;

            count = refer.u.member.Count - 1;
            index = 0;
            index = refer.UnitIndex;

            P1.Text = refer.p1name;
            P2.Text = refer.p2name;
            P3.Text = refer.p3name;

            refer.Control.FSM.Insert("locate");

            CState.Text = refer.Control.FSM.cState.name.ToString();



            //CState.Text = refer.Control.FSM.state.ToString();
        }

        public void DisplayG()
        {
            CState.Text = refer.dState.ToString();
            index = refer.UnitIndex;
        }
        public void ExitGame()
        {
            Application.Exit();
        }
      
    }
}
