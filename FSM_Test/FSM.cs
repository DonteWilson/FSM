using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void Ctrl();

[Serializable]
 public class State
 {
        public Enum name;

        public Delegate d;

        public State()
        {

        }

        public State(Enum CState, Delegate TCtrl)
        {
            name = CState;

            d = TCtrl;
        }

        public bool Ctrl()
        {
            if (d != null)
            {
                Ctrl c;

                c = d as Ctrl;

                c();

                return true;                    
            }

            return false;
        }     
    }

    public class Transition
    {
        public string input
        {
            get;
            private set;
        }

        public State focus
        {
            get;
            private set;
        }
        public Transition(string value, State s)
        {
            input = value;

            focus = s;
        }
    }


    [Serializable]
  public class FSM<T>
{
    public State cState
    {
        get;
        private set;
    }

    private List<State> _states;

    private Dictionary<Enum, List<Transition>> Trans;

    public FSM()
    {
        Trans = new Dictionary<Enum, List<Transition>>();

        _states = new List<State>();

        NewState();
    }
    public bool Insert<V>(V value)
    {
        foreach (Transition t in Trans[cState.name])
        {
            if (t.input == value.ToString())
            {
                cState = t.focus;

                cState.Ctrl();

                return true;
            }
        }

        return false;
    }
    public void NewState()
    {
        if(typeof(T).IsEnum)
        {
            foreach (T states in Enum.GetValues(typeof(T)))
            {
                State state = new State(states as Enum, null);

                _states.Add(state);

                Trans.Add(state.name, new List<Transition>());
            }

            cState = _states[0];
        }
        else
        {
            Console.WriteLine("Invalid " + typeof(T) + "is not of type Enum");
        }
    }
    public bool NewTransition<V>(T from, T to, V input)
    {
        Enum f = from as Enum;

        Enum t = to as Enum;

        State focus = new State();

        foreach (State s in _states)
        {
            if(s.name.ToString() == t.ToString())
            {
                focus = s;

                break;
            }
        }
        if (Trans.ContainsKey(f))
        {
            Transition transition = new Transition(input.ToString(), focus);

            Trans[f].Add(transition);
        }
        else
        {
            Console.WriteLine("Cannot find state");
        }

        return true;
    }
    public bool State(T ss, Delegate del)
    {
        Enum nState = ss as Enum;

        State newState = new State();

        foreach (State s in _states)
        {
            if(s.name.ToString() == nState.ToString())
            {
                newState = s;

                break;
            }
        }
        newState.d = del;

        return true;
    }

}
