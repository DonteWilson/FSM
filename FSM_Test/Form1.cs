using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Collections;
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

        public List<Unit> BattleGroup = new List<Unit>();

        public string p1name;
        public string p2name;
        public string e1name;
        public string e2name;

        public Form1()
        {
            InitializeComponent();
        }
        private void BeginParty_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = true;

            List<Unit> NewGroup = PlayerObjects();

            List<Unit> players = new List<Unit>();
            List<Unit> enemies = new List<Unit>();

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

            Unit Jittery = new Unit("Jittery",100,10,5,0,"Player");
            Unit Ryyul = new Unit("Ryyul",100,9,4,0,"Player");
            Unit Sneaky = new Unit("Sneaky", 100, 9, 5, 0, "Player");

            Unit Savor = new Unit("Savor",100,5,4,0,"Enemy");
            Unit Friv = new Unit("Friv",99,6,4,0,"Enemy");
            Unit Atoli = new Unit("Friv",101,7,4,0,"Enemy");
            Unit Violet = new Unit("Violet",98,5,5,0,"Enemy");

            pObjects.Add(Jittery);
            pObjects.Add(Ryyul);

            pObjects.Add(Savor);
            pObjects.Add(Friv);
            pObjects.Add(Atoli);
            pObjects.Add(Violet);

            return pObjects;
            
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
                
            }
            if (p2 != p3 && p2 != p1)
            {

            }
            if(p3 != p2 && p3 != p1)
            {

            }
            characterpreview(BattleGroup);

            Random a = new Random();

            int e1 = a.Next(0, e.Count);
            int e2 = a.Next(0, e.Count);
            int e3 = a.Next(0, e.Count);

            BattleGroup.Add(e[e1]);
            BattleGroup.Add(e[e2]);
            BattleGroup.Add(e[e3]);

                
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Control.FSM.AddState(i_STATES.INIT);
            //Control.FSM.AddState(i_STATES.START);
            //Control.FSM.AddState(i_STATES.FIGHT);
            //Control.FSM.AddState(i_STATES.PTURN);
            //Control.FSM.AddState(i_STATES.ETURN);
            //Control.FSM.AddState(i_STATES.EXIT);

            //SaveButton.Enabled = false;
            //textBox1.Text = Control.FSM.state.ToString();
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
            Party LoadParty;

            OpenFileDialog DialogWindow = new OpenFileDialog();

            DialogWindow.InitialDirectory = @"..\SavedPArties\";
            DialogWindow.Filter = "txt files (*.txt) |*.txt|All files (*.*)|*.*";
            DialogWindow.FilterIndex = 2;
            DialogWindow.RestoreDirectory = true;

            if (DialogWindow.ShowDialog() == DialogResult.OK)
            {
                string SelectedFile = DialogWindow.FileName;
                LoadParty = _Save.Deserialize<Party>(SelectedFile);
                
                 
            }
        }
       
        private void characterpreview(List<Unit> units)
        {

        }

    }
}
