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

            Unit Jittery = new Unit("Jittery",100,10,15,5,0,"Player");
            Unit Ryyul = new Unit("Ryyul",100,9,10,4,0,"Player");
            Unit Sneaky = new Unit("Sneaky", 100, 9,10, 5, 0, "Player");
            Unit Rory = new Unit("Rory", 100, 8,10, 5, 0, "Player");
            Unit Yato = new Unit("Yato", 100, 10,10, 5, 0, "Player");
            Unit Meteos = new Unit("Meteos", 100, 9,10, 4, 0, "Player");
        

            Unit Savor = new Unit("Savor",100,5, 5,4,0,"Enemy");
            Unit Friv = new Unit("Friv",99,6,10,4,0,"Enemy");
            Unit Atoli = new Unit("Atoli",100,7,6,4,0,"Enemy");
            Unit Violet = new Unit("Violet",98,5,5,5,0,"Enemy");
            Unit Muur = new Unit("Savor", 100, 5,6, 4, 0, "Enemy");
            Unit Loki = new Unit("Friv", 99, 6,4, 4, 0, "Enemy");
           
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
        private void SetParties(List<Unit> Plyr, List<Unit> Enmy)
        {
            List<Unit> empty = new List<Unit>();
            BattleGroup.RemoveRange(0, BattleGroup.Count);
            //creates a random class out of 3 possibilities
            Random r = new Random();

            //Calls the next function to grab a random group of 3 members
            int p1 = r.Next(0, Plyr.Count - 1);
            int p2 = r.Next(0, Plyr.Count - 1);
            int p3 = r.Next(0, Plyr.Count - 1);
            //goes through different players
            while (p1 == p2)
            {
                p2 = r.Next(0, Plyr.Count - 1);
            }
            //goes through different players
            while(p1 == p3)
            {
                p3 = r.Next(0, Plyr.Count - 1);
            }

            if (p1 != p2 && p1 != p3)
            {
                P1NBox.Text = Plyr[p1].Name;
                p1name = Plyr[p1].Name;
                P1hp.Text = Plyr[p1].HP.ToString();
                P1dmg.Text = Plyr[p1].HP.ToString();
                P1armor.Text = Plyr[p1].Armor.ToString();
                P1lvl.Text = Plyr[p1].Lvl.ToString();
                BattleGroup.Add(Plyr[p1]);
            }
            
            while(p2 == p1)
            {
                p2 = r.Next(0, Plyr.Count - 1);
            }

            while(p2 == p3)
            {
                p3 = r.Next(0, Plyr.Count - 1);
            }

            if (p2 != p3 && p2 != p1)
            {
                P2NBox.Text = Plyr[p2].Name;
                p2name = Plyr[p2].Name;
                P2hp.Text = Plyr[p2].HP.ToString();
                P2dmg.Text = Plyr[p2].Dmg.ToString();
                P2armor.Text = Plyr[p2].Armor.ToString();
                P2lvl.Text = Plyr[p2].Lvl.ToString();
                BattleGroup.Add(Plyr[p2]);
            }
            
            while(p3 == p1)
            {
                p3 = r.Next(0, Plyr.Count - 1);
                
                while (p3 == p2)
                {
                    p3 = r.Next(0, Plyr.Count - 1);
                }                  
            }

            if (p3 != p2 && p3 != p1)
            {
                P3NBox.Text = Plyr[p3].Name;
                p3name = Plyr[p3].Name;
                P3hp.Text = Plyr[p3].HP.ToString();
                P3dmg.Text = Plyr[p3].Dmg.ToString();
                P3armor.Text = Plyr[p3].Armor.ToString();
                P3lvl.Text = Plyr[p3].Lvl.ToString();
                BattleGroup.Add(Plyr[p3]);

            }
            CharIcon(BattleGroup);

            Random a = new Random();

            int e1 = a.Next(0, Enmy.Count);
            int e2 = a.Next(0, Enmy.Count);
            int e3 = a.Next(0, Enmy.Count);

            while(e1 == e2)
            {
                e2 = a.Next(0, Enmy.Count - 1);
            }
            while(e2 == e3)
            {
                e3 = a.Next(0, Enmy.Count - 1);
            }
            while(e3 == e1)
            {
                e1 = a.Next(0, Enmy.Count - 1);

                while (e1 == e2)
                {
                    e1 = a.Next(0, Enmy.Count - 1);
                }
            }

            BattleGroup.Add(Enmy[e1]);
            BattleGroup.Add(Enmy[e2]);
            BattleGroup.Add(Enmy[e3]);


        }
        //Loads form 1 FSM states, along with delegates.
        private void Form1_Load_1(object sender, EventArgs e)
        {
            Ctrl BeginCtrl = Arena.DisplayG;
            Ctrl LocateCtrl = Arena.Locate;
            Ctrl FightCtrl = Arena.Initiate;
            Ctrl PTurnCtrl = Arena.PTurn;
            Ctrl ETurnCtrl = Arena.ETurn;
            Ctrl ExitCtrl = Arena.ExitGame;

            Control.FSM.State(i_STATES.START, null);
            Control.FSM.State(i_STATES.LOCATE, LocateCtrl);
            Control.FSM.State(i_STATES.FIGHT, FightCtrl);
            Control.FSM.State(i_STATES.PTURN, PTurnCtrl);
            Control.FSM.State(i_STATES.ETURN, ETurnCtrl);
            Control.FSM.State(i_STATES.EXIT, ExitCtrl);

            Control.FSM.NewTransition(i_STATES.INIT, i_STATES.START, "begin");
            Control.FSM.NewTransition(i_STATES.START, i_STATES.LOCATE, "locate");
            Control.FSM.NewTransition(i_STATES.LOCATE, i_STATES.PTURN, "PTurn ");
            Control.FSM.NewTransition(i_STATES.LOCATE, i_STATES.ETURN, "ETurn");
            Control.FSM.NewTransition(i_STATES.PTURN, i_STATES.FIGHT, "fight");
            Control.FSM.NewTransition(i_STATES.ETURN, i_STATES.FIGHT, "fight");
            Control.FSM.NewTransition(i_STATES.FIGHT, i_STATES.PTURN, "SwitchPlayer");
            Control.FSM.NewTransition(i_STATES.FIGHT, i_STATES.ETURN, "SwitchEnemy");
            Control.FSM.NewTransition(i_STATES.PTURN, i_STATES.EXIT, "Pquit");
            Control.FSM.NewTransition(i_STATES.ETURN, i_STATES.EXIT, "Equit");

            Control.FSM.Insert("begin");

            textBox1.Text = Control.FSM.cState.ToString();
        }
        //Saves current party.
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Party party = new Party();

            foreach (Unit i in BattleGroup)
            {
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
            Party loadedunits;


            OpenFileDialog DialogWindow = new OpenFileDialog();
            DialogWindow.InitialDirectory = @"..\SavedParties";
            DialogWindow.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogWindow.FilterIndex = 2;
            DialogWindow.RestoreDirectory = true;

            if (DialogWindow.ShowDialog() == DialogResult.OK)
            {

                string chosenFile = DialogWindow.FileName;
                loadedunits = _Save.Deserialize<Party>(chosenFile);

                P1NBox.Text = loadedunits.units[0].Name;
                P1hp.Text = loadedunits.units[0].HP.ToString();
                P1dmg.Text = loadedunits.units[0].Dmg.ToString();
                P1Spd.Text = loadedunits.units[0].Spd.ToString();
                P1armor.Text = loadedunits.units[0].Armor.ToString();
                P1lvl.Text = loadedunits.units[0].Lvl.ToString();

                P2NBox.Text = loadedunits.units[1].Name;
                P2hp.Text = loadedunits.units[1].HP.ToString();
                P2dmg.Text = loadedunits.units[1].Dmg.ToString();
                P2Spd.Text = loadedunits.units[1].Spd.ToString();
                P2armor.Text = loadedunits.units[1].Armor.ToString();
                P2lvl.Text = loadedunits.units[1].Lvl.ToString();

                P3NBox.Text = loadedunits.units[2].Name;
                P3hp.Text = loadedunits.units[2].HP.ToString();
                P3dmg.Text = loadedunits.units[2].Dmg.ToString();
                P3Spd.Text = loadedunits.units[2].Spd.ToString();
                P3armor.Text = loadedunits.units[2].Armor.ToString();
                P3lvl.Text = loadedunits.units[2].Lvl.ToString();

                if(BattleGroup.Count >= 1)
                {
                    BattleGroup.RemoveRange(0, BattleGroup.Count);
                }

                foreach (Unit i in loadedunits.units)
                {
                    BattleGroup.Add(i);
                }

                List<Unit> tempParty = new List<Unit>();

                tempParty = PlayerObjects();

                foreach (Unit i in tempParty)
                {
                    if (i.Type == "Enemy")
                    {
                        Enemies.Add(i);
                    }

                }
                Random a = new Random();

                int e1 = a.Next(0, Enemies.Count);
                int e2 = a.Next(0, Enemies.Count);
                int e3 = a.Next(0, Enemies.Count);

                while (e1 == e2)
                {
                    e2 = a.Next(0, Enemies.Count - 1);
                }

                while (e2 == e3)
                {
                    e3 = a.Next(0, Enemies.Count - 1);
                }

                while (e3 == e1)
                {
                    e1 = a.Next(0, Enemies.Count - 1);

                    while (e1 == e2)
                    {
                        e1 = a.Next(0, Enemies.Count - 1);

                    }
                }


                e1name = Enemies[e1].Name;
                e2name = Enemies[e2].Name;
                e3name = Enemies[e3].Name;


                BattleGroup.Add(Enemies[e1]);
                BattleGroup.Add(Enemies[e2]);
                BattleGroup.Add(Enemies[e3]);

                CharIcon(loadedunits.units);
            }
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
    }
}
