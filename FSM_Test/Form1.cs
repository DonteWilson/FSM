﻿using System;
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

namespace FSM_Test
{
    public partial class Form1 : Form
    {
        //Creates
        IO _Save = new IO();

        Form2 Arena;
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

        //Looks through players and generates a random party of 3.
        private void SetParties(List<Unit> p, List<Unit> e)
        {
            List<Unit> empty = new List<Unit>();
            BattleGroup.RemoveRange(0, BattleGroup.Count);
            //creates a random class out of 3 possibilities
            Random r = new Random();

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
            while(p1 == p3)
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
                P1lvl.Text = p[p1].Lvl.ToString();
                BattleGroup.Add(p[p1]);
            }
            
            while(p2 == p1)
            {
                p2 = r.Next(0, p.Count - 1);
            }

            while(p2 == p3)
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
                P2lvl.Text = p[p2].Lvl.ToString();
                BattleGroup.Add(p[p2]);
            }
            
            while(p3 == p1)
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
                P3lvl.Text = p[p3].Lvl.ToString();
                BattleGroup.Add(p[p3]);

            }
            CharIcon(BattleGroup);

            Random a = new Random();

            int e1 = a.Next(0, e.Count);
            int e2 = a.Next(0, e.Count);
            int e3 = a.Next(0, e.Count);

            while(e1 == e2)
            {
                e2 = a.Next(0, e.Count - 1);
            }
            while(e2 == e3)
            {
                e3 = a.Next(0, e.Count - 1);
            }
            while(e3 == e1)
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
        //Loads form 1 FSM states, along with delegates.
        private void Form1_Load_1(object sender, EventArgs e)
        {
            Ctrl StartCtrl = Arena.DisplayG;
            Ctrl LocateCtrl = Arena.Locate;
            Ctrl FightCtrl = Arena.Initiate;
            Ctrl PTurnCtrl = Arena.PTurn;
            Ctrl ETurnCtrl = Arena.ETurn;
            Ctrl ExitCtrl = Arena.ExitGame;
            Ctrl BeginCtrl = Arena.refer.Begin;

            Control.FSM.State(i_STATES.START, BeginCtrl);
            Control.FSM.State(i_STATES.LOCATE, LocateCtrl);
            Control.FSM.State(i_STATES.FIGHT, FightCtrl);
            Control.FSM.State(i_STATES.PTURN, PTurnCtrl);
            Control.FSM.State(i_STATES.ETURN, ETurnCtrl);
            Control.FSM.State(i_STATES.EXIT, ExitCtrl);
            //Switches from Init to Start
            Control.FSM.NewTransition(i_STATES.INIT, i_STATES.START, "begin");
            //Switches from Start to Locate
            Control.FSM.NewTransition(i_STATES.START, i_STATES.LOCATE, "locate");
            //Switches from Locate to PTURN
            Control.FSM.NewTransition(i_STATES.LOCATE, i_STATES.PTURN, "PTurn ");
            //Switches from Locate to ETURN
            Control.FSM.NewTransition(i_STATES.LOCATE, i_STATES.ETURN, "ETurn");
            //Switches from PTURN to FIGHT
            Control.FSM.NewTransition(i_STATES.PTURN, i_STATES.FIGHT, "fight");
            //Switches from ETURN to FIGHT
            Control.FSM.NewTransition(i_STATES.ETURN, i_STATES.FIGHT, "fight");
            //Switches from FIGHT to PTURN
            Control.FSM.NewTransition(i_STATES.FIGHT, i_STATES.PTURN, "SwitchPlayer");
            //Switches from FIGHT to ETURN
            Control.FSM.NewTransition(i_STATES.FIGHT, i_STATES.ETURN, "SwitchEnemy");
            //Switches from PTURN to EXIT
            Control.FSM.NewTransition(i_STATES.PTURN, i_STATES.EXIT, "Pquit");
            //Switches from ETURN to EXIT
            Control.FSM.NewTransition(i_STATES.ETURN, i_STATES.EXIT, "Equit");

            //Returns to start
            Control.FSM.Insert("begin");

            //Displays current state
            textBox1.Text = Control.FSM.cState.ToString();
        }
        //Saves current party.
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Party party = new Party();

            //perform this action for each object in battlegroup list
            foreach (Unit i in BattleGroup)
            {
                //Checks to see if the type is Player
                if (i.Type == "Player")
                {
                    party.units.Add(i);
                }
            }

            _Save.Serialize("Party", party);
        }
        //Load save from a file.
        private void LoadButton_Click(object sender, EventArgs e)
        {
            ////Disables NewGame button
            //NewGame.Enabled = false;
            ////Create a new OpenFileDialog 
            //OpenFileDialog LoadWindow = new OpenFileDialog();
            ////Set a directory as a string to a string variable
            //string path = @"..\Game Saves";
            ////This allows multiselect for the user
            //LoadWindow.Multiselect = true;
            ////If the initial directory is not equal to the path variable
            //if (LoadWindow.InitialDirectory != path)
            //{//Set the directory to the path variable
            //    LoadWindow.InitialDirectory = path;
            //}
            ////Set file type choices to appear
            //LoadWindow.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ////Sets filter selected
            //LoadWindow.FilterIndex = 2;
            ////Set the current form to not be visible
            //Visible = false;
            ////Create an instance of a new party
            //Party EnemyE = new Party();
            ////Create an instance of a new party
            //Party PlayerP = new Party();

            ////If the ok button is clicked
            //if (LoadWindow.ShowDialog() == DialogResult.OK)
            //{//Deserilalize the designated file name as a party object and store it into the PlayerP variable
            //    PlayerP = _Save.Deserialize<Party>(@"..\Game Saves\PartyData.xml");
            //    //Set the player1name to the given index of the PlayerP.unit
            //    p1name = PlayerP.units[0].Name;
            //    //Set the player2name to the given index of the PlayerP.unit
            //    p2name = PlayerP.units[1].Name;
            //    //Set the player3name to the given index of the PlayerP.unit
            //    p3name = PlayerP.units[2].Name;

            //    //Add the new units to the BattleReadyParty List
            //    BattleGroup.Add(PlayerP.units[0]);
            //    BattleGroup.Add(PlayerP.units[1]);
            //    BattleGroup.Add(PlayerP.units[2]);

            //    //Deserilalize the designated file name as a party object and store it into the EnemyE variable
            //    EnemyE = _Save.Deserialize<Party>(@"..\Game Saves\EnemyParty.xml");
            //    //Set the enemy1name to the given index of the EnemyE.unit
            //    e1name = EnemyE.units[0].Name;
            //    //Set the enemy1name to the given index of the EnemyE.unit
            //    e2name = EnemyE.units[1].Name;
            //    //Set the enemy1name to the given index of the EnemyE.unit
            //    e3name = EnemyE.units[2].Name;

            //    //Add the units loaded onto the battle group list
            //    BattleGroup.Add(EnemyE.units[0]);
            //    BattleGroup.Add(EnemyE.units[1]);
            //    BattleGroup.Add(EnemyE.units[2]);

            //    //Deserilalize the designated file name as an int object and store it into the currentUnitIndex variable
            //    UnitIndex = _Save.Deserialize<int>(@"..\Game Saves\Turn.xml");

            //    //Deserilalize the designated file name as a string object and store it into the deserializedState variable
            //    dState = _Save.Deserialize<string>(@"..\Game Saves\GameData.xml");

            //    //Calls the function to display game
            //    Arena.DisplayG();
            //    //Shows dialog for Arena
            //    Arena.ShowDialog();
            //}
            ////If the ok button is not clicked
            //else
            //{//Enable to the New Game Button
            //    NewGame.Enabled = true;
            //    //Allow the form to be visible
            //    Visible = true;
            //}



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

            checkBox1.Enabled = true;

            button1.Enabled = true;

        }
    }
}
