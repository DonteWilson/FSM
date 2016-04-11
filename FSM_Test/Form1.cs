using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using FSM_Test;

namespace FSM_Test
{
    public partial class Form1 : Form
    {
        //Creates
       IO _Save = new IO();

        Form2 Arena;
        private PartyData PartySave;
        //Creates a singleton to the control panel as a public reference.
        public ControlPanel Control = ControlPanel.instance;
        public Unit u = new Unit();
        //creates a list of enemy units
        public List<Unit> Enemies = new List<Unit>();
        //creates a list of units in a battle group
        public List<Unit> BattleGroup = new List<Unit>();
        //public string for file name
        public string Fname;
        //public string for deserialized state
        public string dState;
        //stores the current unit index that was deserialized
        public int UnitIndex = 0;
        //player 1 name
        public string p1name;
        //player 2 name
        public string p2name;
        //player 3 name
        public string p3name;
        //enemy 1 name
        public string e1name;
        //enemy 2 name
        public string e2name;
        //enemy 3 name
        public string e3name;
        
        //SaveName = name;
        //        SaveHP = HP;
        //        SaveArmor = Armor;
        //        SaveDmg = dmg;
        //        SaveSpd = Spd;
        //        SaveXP = XP;
        //        SaveType = type;
        //public constructor for form1
        public Form1()
        {
            InitializeComponent();

            Arena = new Form2(this);
        }
        //Generates Player Party
        private void CreateParty_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;

            NewGame.Enabled = true;

            List<Unit> NewGroup = PlayerObjects();

            List<Unit> players = new List<Unit>();
           
            //loops through each enemy in the group
            foreach (Unit i in NewGroup)
            {//Looks to see if it is a player unit
                if(i.Type == "Player")
                {
                    //if true add player
                    players.Add(i);
                }
                //Looks to see if it is a enemy unit
                if(i.Type == "Enemy")
                {
                    //if true add enemy
                    Enemies.Add(i);
                }
            }
            //Call the generate party and passes the enemies and players in parameters.
            SetParties(players, Enemies);

        }
        //Creates player objects
        private List<Unit> PlayerObjects()
        {
            List<Unit> pObjects = new List<Unit>();

            Unit Jittery = new Unit("Jittery",100,15,25,5,0,"Player");
            Unit Ryyul = new Unit("Ryyul",100,9,25,4,0,"Player");
            Unit Sneaky = new Unit("Sneaky", 100, 25,10, 5, 0, "Player");
            Unit Rory = new Unit("Rory", 100, 8,25, 5, 0, "Player");
            Unit Yato = new Unit("Yato", 100, 10,25, 5, 0, "Player");
            Unit Meteos = new Unit("Meteos", 100, 9,25, 4, 0, "Player");
        

            Unit Savor = new Unit("Savor",100,5, 5,4,50,"Enemy");
            Unit Friv = new Unit("Friv",125,6,10,4,50,"Enemy");
            Unit Atoli = new Unit("Atoli",100,7,6,4,50,"Enemy");
            Unit Violet = new Unit("Violet",98,5,5,5,50,"Enemy");
            Unit Muur = new Unit("Savor", 100, 5,6, 4, 100, "Enemy");
            Unit Loki = new Unit("Friv", 100, 6,4, 4, 25, "Enemy");
           
            //Adds Player Unit Objects
            pObjects.Add(Jittery);
            pObjects.Add(Ryyul);
            pObjects.Add(Sneaky);
            pObjects.Add(Rory);
            pObjects.Add(Yato);
            pObjects.Add(Meteos);
           
            //Adds Enemy Unit Objects
            pObjects.Add(Savor);
            pObjects.Add(Friv);
            pObjects.Add(Atoli);
            pObjects.Add(Violet);
            pObjects.Add(Muur);
            pObjects.Add(Loki);
          
            //return pObjects value
            return pObjects;
            
        }
        //Checks to see if the user wants to use this party
        private void ConfirmParty_Check(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true )
            {
                //Confirms if the player wants to keep the selected party.
                DialogResult = MessageBox.Show("Are you sure about this party?\n", "Confirm", MessageBoxButtons.YesNo);
                //Checks to see if the yes button is checked.
                if(DialogResult == DialogResult.Yes)
                {//sets the current form invisible
                    this.Visible = false;
                    //show the arena
                    Arena.ShowDialog();
                }
                else
                {
                    checkBox1.Checked = false;
                }
                
            }
        }

        [Serializable]
        public class PartyData
        {
            public PartyData()
            {
                
            }

            public PartyData(string Name, string HP, string Armor, string dmg, string Spd,string lvl, string Name2, string HP2, string Armor2, string dmg2, string Spd2, string lvl2, string Name3, string HP3, string Armor3, string dmg3, string Spd3, string lvl3)
            {
                P1name = Name;
                P1HP = HP;
                P1Armor = Armor;
                P1Dmg = dmg;
                P1Spd = Spd;
                P1Lvl = lvl;
                P2name = Name2;
                P2HP = HP2;
                P2Armor = Armor2;
                P2Dmg = dmg2;
                P2Spd = Spd2;
                P2Lvl = lvl2;
                P3name = Name3;
                P3HP = HP3;
                P3Armor = Armor3;
                P3Dmg = dmg3;
                P3Spd = Spd3;
                P3Lvl = lvl3;

            }
            public string P1name;
            public string P1HP;
            public string P1Armor;
            public string P1Dmg;
            public string P1Spd;
            public string P1Lvl;
            public string P2name;
            public string P2HP;
            public string P2Armor;
            public string P2Dmg;
            public string P2Spd;
            public string P2Lvl;
            public string P3name;
            public string P3HP;
            public string P3Armor;
            public string P3Dmg;
            public string P3Spd;
            public string P3Lvl;


        }

        //Looks through players and generates a random party of 3.
        private void SetParties(List<Unit> p, List<Unit> e)
        {
            List<Unit> empty = new List<Unit>();
            BattleGroup.RemoveRange(0, BattleGroup.Count);
            //creates a random class out of 3 possibilities
            Random r = new Random();
            if (p.Count > 0)
            {
                //Calls the next function to grab a random group of 3 members
                int p1 = r.Next(0, p.Count - 1);
                int p2 = r.Next(0, p.Count - 1);
                int p3 = r.Next(0, p.Count - 1);
                //goes through different players
                while (p1 == p2)
                {
                    p2 = r.Next(0, p.Count - 1);
                }
                //goes through different players
                while (p1 == p3)
                {
                    p3 = r.Next(0, p.Count - 1);
                }

                if (p1 != p2 && p1 != p3)
                {
                    P1NBox.Text = p[p1].Name;
                    p1name = p[p1].Name;
                    P1hp.Text = p[p1].HP.ToString();
                    P1dmg.Text = p[p1].HP.ToString();
                    P1armor.Text = p[p1].Armor.ToString();
                    P1Spd.Text = p[p1].Spd.ToString();
                    P1lvl.Text = p[p1].Lvl.ToString();
                    BattleGroup.Add(p[p1]);                   
                }

                while (p2 == p1)
                {
                    p2 = r.Next(0, p.Count - 1);
                }

                while (p2 == p3)
                {
                    p3 = r.Next(0, p.Count - 1);
                }

                if (p2 != p3 && p2 != p1)
                {
                    P2NBox.Text = p[p2].Name;
                    p2name = p[p2].Name;
                    P2hp.Text = p[p2].HP.ToString();
                    P2dmg.Text = p[p2].Dmg.ToString();
                    P2armor.Text = p[p2].Armor.ToString();
                    P2Spd.Text = p[p1].Spd.ToString();
                    P2lvl.Text = p[p2].Lvl.ToString();
                    BattleGroup.Add(p[p2]);

                    
                }

                while (p3 == p1)
                {
                    p3 = r.Next(0, p.Count - 1);

                    while (p3 == p2)
                    {
                        p3 = r.Next(0, p.Count - 1);
                    }
                }

                if (p3 != p2 && p3 != p1)
                {
                    P3NBox.Text = p[p3].Name;
                    p3name = p[p3].Name;
                    P3hp.Text = p[p3].HP.ToString();
                    P3dmg.Text = p[p3].Dmg.ToString();
                    P3armor.Text = p[p3].Armor.ToString();
                    P3Spd.Text = p[p3].Spd.ToString();
                    P3lvl.Text = p[p3].Lvl.ToString();
                    BattleGroup.Add(p[p3]);

                    

                }
                PartyData save = new PartyData(P1NBox.Text, P1hp.Text, P1dmg.Text, P1armor.Text, P1Spd.Text, P1lvl.Text, P2NBox.Text, P2hp.Text, P2dmg.Text, P2armor.Text,P2Spd.Text,P2lvl.Text, P3NBox.Text,P3hp.Text, P3dmg.Text, P3armor.Text,P3Spd.Text,P3lvl.Text);
                
                PartySave = save;

                CharIcon(BattleGroup);

                Random a = new Random();

                int e1 = a.Next(0, e.Count);
                int e2 = a.Next(0, e.Count);
                int e3 = a.Next(0, e.Count);

                while (e1 == e2)
                {
                    e2 = a.Next(0, e.Count - 1);
                }
                while (e2 == e3)
                {
                    e3 = a.Next(0, e.Count - 1);
                }
                while (e3 == e1)
                {
                    e1 = a.Next(0, e.Count - 1);

                    while (e1 == e2)
                    {
                        e1 = a.Next(0, e.Count - 1);
                    }
                }

                BattleGroup.Add(e[e1]);
                BattleGroup.Add(e[e2]);
                BattleGroup.Add(e[e3]);


            }
        }
        //Loads form 1 FSM states, along with delegates.
        private void Form1_Load_1(object sender, EventArgs e)
        {
           

            Control.FSM.State(i_STATES.START);
            Control.FSM.State(i_STATES.LOCATE);
            Control.FSM.State(i_STATES.FIGHT);
            Control.FSM.State(i_STATES.PTURN);
            Control.FSM.State(i_STATES.ETURN);
            Control.FSM.State(i_STATES.EXIT);
            //Switches from Init to Start
            Control.FSM.AddTransition(i_STATES.INIT, i_STATES.START, "begin");
            //Switches from Start to Locate
            Control.FSM.AddTransition(i_STATES.START, i_STATES.LOCATE, "locate");
            //Switches from Locate to PTURN
            Control.FSM.AddTransition(i_STATES.LOCATE, i_STATES.PTURN, "PTurn ");
            //Switches from Locate to ETURN
            Control.FSM.AddTransition(i_STATES.LOCATE, i_STATES.ETURN, "ETurn");
            //Switches from PTURN to FIGHT
            Control.FSM.AddTransition(i_STATES.PTURN, i_STATES.FIGHT, "fight");
            //Switches from ETURN to FIGHT
            Control.FSM.AddTransition(i_STATES.ETURN, i_STATES.FIGHT, "fight");
            //Switches from FIGHT to PTURN
            Control.FSM.AddTransition(i_STATES.FIGHT, i_STATES.PTURN, "SwitchPlayer");
            //Switches from FIGHT to ETURN
            Control.FSM.AddTransition(i_STATES.FIGHT, i_STATES.ETURN, "SwitchEnemy");
            //Switches from PTURN to EXIT
            Control.FSM.AddTransition(i_STATES.PTURN, i_STATES.EXIT, "Pquit");
            //Switches from ETURN to EXIT
            Control.FSM.AddTransition(i_STATES.ETURN, i_STATES.EXIT, "Equit");

            //Returns to start
           // Control.FSM.Insert("begin");

            //Displays current state
            textBox1.Text = Control.FSM.cState.ToString();
        }
        //Saves current party.
        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            //Saves Current Game Data
            string path = Environment.CurrentDirectory + @"\PartySave\";
            IO.SerializeGameData<PartyData>("Party", PartySave, path);
            MessageBox.Show("Successfully Saved.\n");
        }
        //Load save from a file.
        private void LoadButton_Click(object sender, EventArgs e)
        {


            //Attempt to load from serialzied data.
            string path = @"..\Debug\PartySave\Party";
            IO.DeserializeGameData<PartyData>(path);
            PartyData party = IO.DeserializeGameData<PartyData>(path);
            //Loads Name
            P1NBox.Text = party.P1name;
            //Loads HP
            P1hp.Text = party.P1HP;
            //Loads Dmg
            P1dmg.Text = party.P1Dmg;
            //Loads Armor
            P1armor.Text = party.P1Armor;
            //Loads Speed
            P1Spd.Text = party.P1Spd;
            //Loads Level
            P1lvl.Text = party.P1Lvl;

            //Loads Player 2 name
            P2NBox.Text = party.P2name;
            //Loads Player 2 Hp
            P2hp.Text = party.P2HP;
            //Loads Player 2 Dmg
            P2dmg.Text = party.P2Dmg;
            //Loads Player 2 Armor
            P2armor.Text = party.P2Armor;
            //Loads Player 2 Speed
            P2Spd.Text = party.P2Spd;
            //Loads Player 2 Lvl
            P2lvl.Text = party.P2Lvl;

            //Loads Player 3 name
            P3NBox.Text = party.P3name;
            //Loads Player 3 Hp
            P3hp.Text = party.P3HP;
            //Loads Player 3 Dmg
            P3dmg.Text = party.P3Dmg;
            //Loads Player 3 Armor
            P3armor.Text = party.P3Armor;
            //Loads Player 3 Speed
            P3Spd.Text = party.P3Spd;
            //Loads Player 3 Level
            P3lvl.Text = party.P3Lvl;






        }
        public void Begin()
        {
            this.Visible = true;
            //Set the other form to be disabled
            Arena.Visible = false;
            //Uncheck the LockInPartyCheckBox
            checkBox1.Checked = false;
            //Disable the LockInPartyCheckBox
            //Enables the New Game Button
            NewGame.Enabled = true;
            //Disables checkbox 1 button
            checkBox1.Enabled = false;
            //Enable the Load Game Button
            button3.Enabled = true;
            //Remoave all elements of the BattleReadyParty list
            BattleGroup.RemoveRange(0, BattleGroup.Count);
            //Disable the load party button
            //LoadButton.Enabled = false;
            //Disable the save button
            SaveButton.Enabled = false;
            //Disable the Generate Party Button
            button1.Enabled = false;
            //Set the statsText to ""
            Control.stats = "";
            //Set the pictureBox1 Image to null
            pictureBox1.Image = null;
            //Set the pictureBox2 Image to null
            pictureBox2.Image = null;
            //Set the pictureBox3 Image to null
            pictureBox3.Image = null;

            //If the Enemies list Count is greater than or equal to 1
            if (Enemies.Count >= 1)
            {//Remove all elements in the Enemies List
                Enemies.RemoveRange(0, Enemies.Count);
            }

            //sets p1 name box
            P1NBox.Text = "";
            //Set p1 name to ""
            p1name = "";
            //Set the P1HealthBox.Text to ""
            P1hp.Text = "";
            //Set the P1StrengthBox.Text to ""
            P1dmg.Text = "";
            //Set armor.text to ""
            P1armor.Text = "";
            //Set the P1SpeedBox.Text to ""
            P1Spd.Text = "";
            //Set the P1LevelBox.Text to ""
            P1lvl.Text = "";

            //Set the P2NameBox.Text to ""
            P2NBox.Text = "";
            //Set the Player2name to ""
            p2name = "";
            //Set the P2HealthBox.Text to ""
            P2hp.Text = "";
            //Set the P2StrengthBox.Text to ""
            P2dmg.Text = "";
            //Set the P2DefenseBox.Text to ""
            P2armor.Text = "";
            //Set the P2SpeedBox.Text to ""
            P2Spd.Text = "";
            //Set the P2LevelBox.Text to ""
            P2lvl.Text = "";

            //Set the P3NameBox.Text to ""
            P3NBox.Text = "";
            //Set the player3name to ""
            p3name = "";
            //Set the P3HealthBox.Text to ""
            P3hp.Text = "";
            //Set the P3StrengthBox.Text to ""
            P3dmg.Text = "";
            //Set the P3DefenseBox.Text to ""
            P3armor.Text = "";
            //Set the P2SpeedBox.Text to ""
            P3Spd.Text = "";
            //Set the P3LevelBox.Text to ""
            P3lvl.Text = "";
        }
       //Gives each player unity a certain icon to display difference.
        private void CharIcon(List<Unit> units)
        {
            for(int i = 0; i < units.Count; i++)
            {
                if (units[i].Name == P1NBox.Text)
                {
                    switch (units[i].Name)
                    {
                        case "Jittery":
                            pictureBox1.Image = Properties.Resources.Jittery;
                            break;
                        case "Ryyul":
                            pictureBox1.Image = Properties.Resources.Ryyul;
                            break;
                        case "Rory":
                            pictureBox1.Image = Properties.Resources.Rory;
                            break;
                        case "Yato":
                            pictureBox1.Image = Properties.Resources.Yato;
                            break;
                        case "Meteos":
                            pictureBox1.Image = Properties.Resources.Meteos;
                            break;
                        case "Sneaky":
                            pictureBox1.Image = Properties.Resources.Sneaky;
                            break;
                        default:
                            break;
                    }
                }
                if (units[i].Name == P2NBox.Text)
                {
                    switch (units[i].Name)
                    {
                        case "Jittery":
                            pictureBox2.Image = Properties.Resources.Jittery;
                            break;
                        case "Ryyul":
                            pictureBox2.Image = Properties.Resources.Ryyul;
                            break;
                        case "Rory":
                            pictureBox2.Image = Properties.Resources.Rory;
                            break;
                        case "Yato":
                            pictureBox2.Image = Properties.Resources.Yato;
                            break;
                        case "Meteos":
                            pictureBox2.Image = Properties.Resources.Meteos;
                            break;
                        case "Sneaky":
                            pictureBox2.Image = Properties.Resources.Sneaky;
                            break;
                        default:
                            break;
                    }
                }
                if (units[i].Name == P3NBox.Text)
                {
                    switch (units[i].Name)
                    {
                        case "Jittery":
                            pictureBox3.Image = Properties.Resources.Jittery;
                            break;
                        case "Ryyul":
                            pictureBox3.Image = Properties.Resources.Ryyul;
                            break;
                        case "Rory":
                            pictureBox3.Image = Properties.Resources.Rory;
                            break;
                        case "Yato":
                            pictureBox3.Image = Properties.Resources.Yato;
                            break;
                        case "Meteos":
                            pictureBox3.Image = Properties.Resources.Meteos;
                            break;
                        case "Sneaky":
                            pictureBox3.Image = Properties.Resources.Sneaky;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void P2hp_TextChanged(object sender, EventArgs e)
        {

        }

        private void P1lvl_TextChanged(object sender, EventArgs e)
        {

        }

        private void P3NBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            NewGame.Enabled = false;

            SaveButton.Enabled = false;

            checkBox1.Enabled = true;

            button1.Enabled = true;
            pictureBox1.Image = null;
            //sets p1 name box
            P1NBox.Text = "";
            //Set p1 name to ""
            p1name = "";
            //Set the P1HealthBox.Text to ""
            P1hp.Text = "";
            //Set the P1StrengthBox.Text to ""
            P1dmg.Text = "";
            //Set armor.text to ""
            P1armor.Text = "";
            //Set the P1SpeedBox.Text to ""
            P1Spd.Text = "";
            //Set the P1LevelBox.Text to ""
            P1lvl.Text = "";


            pictureBox2.Image = null;
            //Set the P2NameBox.Text to ""
            P2NBox.Text = "";
            //Set the Player2name to ""
            p2name = "";
            //Set the P2HealthBox.Text to ""
            P2hp.Text = "";
            //Set dmg to ""
            P2dmg.Text = "";
            //Set the P2DefenseBox.Text to ""
            P2armor.Text = "";
            //Set the P2SpeedBox.Text to ""
            P2Spd.Text = "";
            //Set the P2LevelBox.Text to ""
            P2lvl.Text = "";

            pictureBox3.Image = null;
            //Set the P3NameBox.Text to ""
            P3NBox.Text = "";
            //Set the player3name to ""
            p3name = "";
            //Set the P3HealthBox.Text to ""
            P3hp.Text = "";
            //Set the P3StrengthBox.Text to ""
            P3dmg.Text = "";
            //Set the P3DefenseBox.Text to ""
            P3armor.Text = "";
            //Set the P2SpeedBox.Text to ""
            P3Spd.Text = "";
            //Set the P3LevelBox.Text to ""
            P3lvl.Text = "";

            


        }
    }
}
