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
        //Int to show the current index of a list
        int index;
        //Compare the index to
        int count;

        List<Unit> Party = new List<Unit>();
        List<Unit> Eparty = new List<Unit>();
        //Constructor for Form1
        public Form1 refer;
        public Form2(Form1 parent)
        {
            refer = parent;
            //set the form it was passed into to be false
            parent.Visible = false;
            //initializes current form.
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
            //changes current members in party to variables
            if (index > 0)
            {
                Unit a = refer.u.member[index];
              

                if (Eparty[0].Life == true)
                {
                    a.Combat(Eparty[0]);
                    CombatT.Text = a.stuff;
                    //checks to see what index count equals
                    if (index == count)
                    {
                        index = 0;
                    }
                    // increase index by 1
                    else
                    {
                        index += 1;
                    }
                }
                if (refer.Control.Victorious(Party, Eparty) == true)
                {
                    //cahnges combat text to equal victorious text
                    CombatT.Text += refer.Control.winText;

                    Party party = new FSM_Test.Party();

                    party.units = Party;

                    foreach (Unit u in party.units)
                    {
                        //sets units life to true
                        u.Life = true;
                    }
                    refer.Control.stats = "";
                    refer.Control.Objectstats(refer.u.member);
                    OStats.Text = refer.Control.stats;
                    //disables Attack enemy 1 button 
                    Attack1.Enabled = false;
                    //disables Attack enemy 2 button
                    Attack2.Enabled = false;
                    //disables Attack enemy 3 button
                    Attack3.Enabled = false;
                    //Changes current state text to equal current fsm state
                    CState.Text = refer.Control.FSM.cState.name.ToString();
                }
                //Calls the engagement function
                Engagement(index);
            }

        }

        private void Attack2_Click(object sender, EventArgs e)
        {
            //changes current members of a party to varibles
            Unit a = refer.u.member[index];

            if (Eparty[1].Life == true)
            {
                a.Combat(Eparty[1]);
                //sets combat text to stuff data
                CombatT.Text = a.stuff;

                if (index == count)
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

                    u.Life = true;
                }
                refer.Control.stats = "";
                refer.Control.Objectstats(refer.u.member);
                OStats.Text = refer.Control.stats;
                //Disables Attack Enemy 1 button
                Attack1.Enabled = false;
                //Disables Attack enemy 2 button
                Attack2.Enabled = false;
                //Disables Attack enemy 3 button
                Attack3.Enabled = false;
                //Changes state to current fsm state
                CState.Text = refer.Control.FSM.cState.name.ToString();
            }
            //Calls the engagement function
            Engagement(index);
        }

        private void Attack3_Click(object sender, EventArgs e)
        {
            Unit a = refer.u.member[index];

            if (Eparty[2].Life == true)
            {
                a.Combat(Eparty[2]);
                //sets combat text to the text data in stuff.
                CombatT.Text = a.stuff;

                if (index == count)
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
                //Changes combat text status to win text
                CombatT.Text += refer.Control.winText;

                Party party = new FSM_Test.Party();

                party.units = Party;

                foreach (Unit u in party.units)
                {
                    //sets units life to true
                    u.Life = true;
                }
                refer.Control.stats = "";
                refer.Control.Objectstats(refer.u.member);
                OStats.Text = refer.Control.stats;
                //disables Attack Enemy 1 button
                Attack1.Enabled = false;
                //disables Attack Enemy 2 button
                Attack2.Enabled = false;
                //disables Attack Enemy 3 button
                Attack3.Enabled = false;
                //Changes current state text to current state
                CState.Text = refer.Control.FSM.cState.name.ToString();
            }
            //Calls the engagement function
            Engagement(index);
        }
    

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void Engagement(int num)
        {
            if (num == refer.u.member.Count)
            {
                //sets number to 0
                num = 0;
                //sets index to 0
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
                //changes fsm state to player turn
                refer.Control.FSM.Insert("SwitchPlayer");
            }
            else if (refer.u.member[num].Type == "Enemy" && refer.u.member[num].Life == true)
            {
                CombatT.Text += refer.u.member[num].Name + "'s turn\n";
                //changes fsm state to enemy turn
                refer.Control.FSM.Insert("SwitchEnemy");
            }
            else
            {
                //increaes index by 1
                index += 1;
                Engagement(index);
            }
        }
        // First Blood
        private void FB(List<Unit> uList)
        {
            CombatT.Text += "It is " + uList[index].Name + "'s turn\n";
            //checks to see if deserialized state equals null
            if (refer.dState != null)
            {
                //if it does then it adds a state
                refer.Control.FSM.Insert(refer.dState);
            }
            else
            {
                //checks to see if string enemy is alive
                if(uList[index].Type == "Enemy" && uList[index].Life == true)
                {
                    //changes fsm to Enemy turn
                    refer.Control.FSM.Insert("ETurn");
                }
                if(uList[index].Type == "Player" && uList[index].Life == true)
                {   //changes fsm state to Player Turn
                    refer.Control.FSM.Insert("PTurn");
                }
            }

            OStats.Text = refer.Control.stats;
        }
        public void Locate()
        {
            //Checks each memebers speed to see who attacks first.
            refer.u.member = refer.Control.Speed(refer.BattleGroup);

            for (int i = 0; i < refer.u.member.Count; i++)
            {
                //Shows whos turn it is to fight
                FightSequence.Text += "\n" + refer.u.member[i].Name + "\n";
            }

            foreach (Unit i in refer.u.member)
            {
                //If type equals Player then add Player to party
                if (i.Type == "Player")
                {
                    //Adds onto Player Party
                    Party.Add(i);
                }
                //If type equals Enemy then add Enemy to party
                if(i.Type == "Enemy")
                {
                    //Adds onto Enemy Party
                    Eparty.Add(i);
                }
            }
            //Sets E1 text to Enemy 1 name
            E1.Text = Eparty[0].Name;
            //Sets E2 text to Enemy 2 name
            E2.Text = Eparty[1].Name;
            //Sets E3 text to Enemy 3 name
            E3.Text = Eparty[2].Name;

            CharIcons(refer.u.member);
            //checks current objects stats for a certain member
            refer.Control.Objectstats(refer.u.member);
            //Changes Object Stats text to equal stats data
            OStats.Text = refer.Control.stats;



            
        }
        //function for player turn
        public void PTurn()
        {
            //Enables Attack Enemy 1
            Attack1.Enabled = true;
            //Enables Attack Enemy 2
            Attack2.Enabled = true;
            //Enables Attack Enemy 3
            Attack3.Enabled = true;
            Unit a = refer.u.member[index];

            if (Eparty[1].Life == true)
            {
                a.Combat(Eparty[1]);
                CombatT.Text = a.stuff;

                if (index == count)
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
                    u.Life = true;
                }
                refer.Control.stats = "";
                refer.Control.Objectstats(refer.u.member);
                OStats.Text = refer.Control.stats;
                //Disables Attack Enemy 1
                Attack1.Enabled = false;
                //Disables Attack Enemy 2
                Attack2.Enabled = false;
                //Disables Attack Enemy 3
                Attack3.Enabled = false;
                //Changes Current State Text to current FSM state
                CState.Text = refer.Control.FSM.cState.name.ToString();
            }
            Engagement(index);
            
            CState.Text = refer.Control.FSM.cState.name.ToString();

        }
        //function for enemy turn
        public void ETurn()
        {
            Attack1.Enabled = false;
            Attack2.Enabled = false;
            Attack3.Enabled = false;
            //Changes combat text to equal current fsm state
            CombatT.Text += refer.Control.FSM.cState.name.ToString() + "State \n";
            //changes fsm state text to equal current fsm state
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
                //disables Attack Enemy 1 button
                Attack1.Enabled = false;
                //disables Attack Enemy 1 button
                Attack2.Enabled = false;
                //disables Attack Enemy 1 button
                Attack3.Enabled = false;
                //changes Current State text to current fsm state
                CState.Text = refer.Control.FSM.cState.name.ToString();
            }
            Engagement(index);

        }
        //
        public void Initiate()
        {
            refer.Control.stats = "";
            refer.Control.Objectstats(refer.u.member);
            //displays current object states.
            OStats.Text = refer.Control.stats;

            
        }
        //Sets character icons to each picture box
        private void CharIcons(List<Unit> units)
        {
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i].Name == P1.Text)
                {
                    switch (units[i].Name)
                    {//Picture box 1 cases
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
                    {//Picture box 2 cases
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
                {//Picture box 3 cases
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
                if (units[i].Name == E1.Text)
                {
                    switch (units[i].Name)
                    {//Enemy 1 Picture box cases
                        case "Savor":
                            E1p.Image = Properties.Resources.Savor;
                            break;
                        case "Atoli":
                            E1p.Image = Properties.Resources.Atoli;
                            break;
                        case "Muur":
                            E1p.Image = Properties.Resources.Muur;
                            break;
                        case "Friv":
                            E1p.Image = Properties.Resources.Friv;
                            break;
                        case "Violet":
                            E1p.Image = Properties.Resources.Violet;
                            break;
                        case "Loki":
                            E1p.Image = Properties.Resources.Loki;
                            break;
                        default:
                            break;
                    }
                }
                if (units[i].Name == E2.Text)
                {
                    switch (units[i].Name)
                    {//Enemy 2 picture box cases
                        case "Savor":
                            E2p.Image = Properties.Resources.Savor;
                            break;
                        case "Atoli":
                            E2p.Image = Properties.Resources.Atoli;
                            break;
                        case "Muur":
                            E2p.Image = Properties.Resources.Muur;
                            break;
                        case "Friv":
                            E2p.Image = Properties.Resources.Friv;
                            break;
                        case "Violet":
                            E2p.Image = Properties.Resources.Violet;
                            break;
                        case "Loki":
                            E2p.Image = Properties.Resources.Loki;
                            break;
                        default:
                            break;
                    }
                }
                if (units[i].Name == E3.Text)
                {//Enemy 3 picture box cases
                    switch (units[i].Name)
                    {
                        case "Savor":
                            E3p.Image = Properties.Resources.Savor;
                            break;
                        case "Atoli":
                            E3p.Image = Properties.Resources.Atoli;
                            break;
                        case "Muur":
                            E3p.Image = Properties.Resources.Muur;
                            break;
                        case "Friv":
                            E3p.Image = Properties.Resources.Friv;
                            break;
                        case "Violet":
                            E3p.Image = Properties.Resources.Violet;
                            break;
                        case "Loki":
                            E3p.Image = Properties.Resources.Loki;
                            break;
                        default:
                            break;
                    }
                }

            }
        }
        //called when form 2 is loaded
        private void Form2_Load(object sender, EventArgs e)
        {
            //disable attack 1 button
            Attack1.Enabled = false;
            //disable attack 2 button
            Attack2.Enabled = false;
            //disable attack 3 button
            Attack3.Enabled = false;

            count = refer.u.member.Count - 1;
            //sets index to 0
            index = 0;
            //takes data from save if there is a save
            index = refer.UnitIndex;
            //sets p1.text to player 1 name
            P1.Text = refer.p1name;
            //sets p2.text to player 2 name
            P2.Text = refer.p2name;
            //sets p3.text to player 3 name
            P3.Text = refer.p3name;

            CombatT.Text = "";
            //FSM to Locate Enemy State
            refer.Control.FSM.Insert("locate");
            //Sets current state text to current state
            CState.Text = refer.Control.FSM.cState.name.ToString();



            //CState.Text = refer.Control.FSM.state.ToString();
        }

        public void DisplayG()
        {
            //Changes current state text to deseralized state
            CState.Text = refer.dState.ToString();
            //refers to current unit index if loaded from save.
            index = refer.UnitIndex;
        }
        public void ExitGame()
        {
            //Exits application
            Application.Exit();
        }

        private void SB_Click(object sender, EventArgs e)
        {
            //creates a new party object
            Party w = new Party();
            //creates a new party object
            Party p = new Party();
            //Sets E to an Enum variable.
            Enum E;

            List<Party> pList = new List<Party>();

            int number = index;

            w.units = Party;

            p.units = Eparty;

            E = refer.Control.FSM.cState.name;
        }
    }
}
