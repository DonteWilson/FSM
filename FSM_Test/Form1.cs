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

namespace FSM_Test
{
    public partial class Form1 : Form
    {
        IO _Save = new IO();

        public ControlPanel Control = ControlPanel.instance;
        public Unit u = new Unit();

        public List<Unit> enemies = new List<Unit>();
        public List<Unit> BattleGroup = new List<Unit>();

        public string p1name;
        public string p2name;
        public string p3name;
        public string e1name;
        public string e2name;
        public string e3name;

        public Form1()
        {
            InitializeComponent();
        }
        private void CreateParty_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;

            List<Unit> NewGroup = PlayerObjects();

            List<Unit> players = new List<Unit>();
           

            foreach (Unit i in NewGroup)
            {
                if(i.Type == "Player")
                {
                    players.Add(i);
                }
                if(i.Type =="Enemy")
                {
                    enemies.Add(i);
                }
            }

            SetParties(players, enemies);

        }
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
            Unit Atoli = new Unit("Atoli",101,7,6,4,0,"Enemy");
            Unit Violet = new Unit("Violet",98,5,5,5,0,"Enemy");
            Unit Muur = new Unit("Savor", 100, 5,6, 4, 0, "Enemy");
            Unit Loki = new Unit("Friv", 99, 6,4, 4, 0, "Enemy");
           

            pObjects.Add(Jittery);
            pObjects.Add(Ryyul);
            pObjects.Add(Sneaky);
            pObjects.Add(Rory);
            pObjects.Add(Yato);
            pObjects.Add(Meteos);
           

            pObjects.Add(Savor);
            pObjects.Add(Friv);
            pObjects.Add(Atoli);
            pObjects.Add(Violet);
            pObjects.Add(Muur);
            pObjects.Add(Loki);
          

            return pObjects;
            
        }
        private void ConfirmParty_Check(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true )
            {
                DialogResult = MessageBox.Show("Are you sure about this party?\n", "Confirm", MessageBoxButtons.YesNo);

                if(DialogResult == DialogResult.Yes)
                {
                    Form2 Combat = new Form2(this);
                    Combat.ShowDialog();
                }
                else
                {
                    checkBox1.Checked = false;
                }
                
            }
        }
        private void SetParties(List<Unit> p, List<Unit> e)
        {
            List<Unit> empty = new List<Unit>();
            BattleGroup.RemoveRange(0, BattleGroup.Count);

            Random r = new Random();

            int p1 = r.Next(0, p.Count - 1);
            int p2 = r.Next(0, p.Count - 1);
            int p3 = r.Next(0, p.Count - 1);

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
            if(p3 != p2 && p3 != p1)
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

            //Random a = new Random();

            //int e1 = a.Next(0, e.Count);
            //int e2 = a.Next(0, e.Count);
            //int e3 = a.Next(0, e.Count);

            //e1name = e[e1].Name;
            //e2name = e[e2].Name;
            //e3name = e[e3].Name;

            //BattleGroup.Add(e[e1]);
            //BattleGroup.Add(e[e2]);
            //BattleGroup.Add(e[e3]);

                
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            Control.FSM.AddState(i_STATES.INIT);
            Control.FSM.AddState(i_STATES.START);
            Control.FSM.AddState(i_STATES.FIGHT);
            Control.FSM.AddState(i_STATES.PTURN);
            Control.FSM.AddState(i_STATES.ETURN);
            Control.FSM.AddState(i_STATES.EXIT);

            Control.FSM.AddT(i_STATES.INIT, i_STATES.START);
            Control.FSM.AddT(i_STATES.INIT, i_STATES.FIGHT);
            Control.FSM.AddT(i_STATES.INIT, i_STATES.PTURN);
            Control.FSM.AddT(i_STATES.INIT, i_STATES.ETURN);
            Control.FSM.AddT(i_STATES.PTURN, i_STATES.FIGHT);
            Control.FSM.AddT(i_STATES.ETURN, i_STATES.FIGHT);
            Control.FSM.AddT(i_STATES.FIGHT, i_STATES.EXIT);

            Control.FSM.TState(i_STATES.START);

            SaveButton.Enabled = false;
            textBox1.Text = Control.FSM.state.ToString();
        }

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
        private void LoadButton_Click(object sender, EventArgs e)
        {
            //Party LoadParty;

            //OpenFileDialog DialogWindow = new OpenFileDialog();

            //DialogWindow.InitialDirectory = @"..\SavedPArties\";
            //DialogWindow.Filter = "txt files (*.txt) |*.txt|All files (*.*)|*.*";
            //DialogWindow.FilterIndex = 2;
            //DialogWindow.RestoreDirectory = true;

            //if (DialogWindow.ShowDialog() == DialogResult.OK)
            //{
            //    string SelectedFile = DialogWindow.FileName;
            //    LoadParty = _Save.Deserialize<Party>(SelectedFile);
                
                 
            //}
        }
       
        private void CharIcon(List<Unit> units)
        {

        }

        private void P2hp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
