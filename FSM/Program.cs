using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum i_STATES
{
    Init, // Player init state
    Idle, // Player idle state
    Target, // Checks to see who is being target
    Dead, // Player Death state
}
namespace FSMachine
{ 
    class Program
    {
        
        static void Main(string[] args)
        {
            bool running = true;
            FSMac<i_STATES> FSM = new FSMac<i_STATES>();
            //Adding States
            FSM.AddState(i_STATES.Init);
            FSM.AddState(i_STATES.Idle);
            FSM.AddState(i_STATES.Target);
            FSM.AddState(i_STATES.Dead);

            //Adding Transitions
            FSM.AddT(i_STATES.Init, i_STATES.Idle);
            FSM.AddT(i_STATES.Idle, i_STATES.Target);
            FSM.AddT(i_STATES.Target, i_STATES.Dead);

            ControlPanel Control = ControlPanel.instance;
            //Represents group the members are in
            List<Unit> League = new List<Unit>();

            //Graps a list of units 
            Player listp = new Player();
            Enemy liste = new Enemy();

            //Player
            Player Jittery = new Player("Jittery", 100, 5,"Player");
            
            //Enemies
            Enemy Atoli = new Enemy("Atoli", 100, 2,"Enemy");
            Enemy Violet = new Enemy("Violet",100, 2,"Enemy");
            Enemy Savor = new Enemy("Savor",100, 3, "Enemy");
            Enemy Ryyul = new Enemy("Ryyul", 100, 4, "Enemy");

            Unit u = new Unit();

            u.member.Add(Jittery);
            u.member.Add(Atoli);
            u.member.Add(Violet);
            u.member.Add(Savor);
            u.member.Add(Ryyul);

            FSM.info();
            
            //Will Switch states between my FSM.
            while (running)
            {
                switch (FSM.state)
                {
                    //Unit starts in its initial state.
                    case i_STATES.Init:
                        FSM.TState(i_STATES.Idle);
                        break;
                    //Unit goes from idle to Target
                    case i_STATES.Idle:
                        League = Control.Speed(u.member);
                        FSM.TState(i_STATES.Target);
                        break;
                    //When Unit finds target they begin to fight.
                    case i_STATES.Target:
                        Control.Fight(League, FSM);
                        break;
                    //When target or player health = 0. sets the game running to false.
                    case i_STATES.Dead:
                        Control.Objectstats(u.member);
                        running = false;
                        break;


                    default:
                        break;
                       
                }

            }
            Console.Read();
        }
      }
}




