﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Controls Functions
public delegate void Ctrl();

[Serializable]
//Creates States for object
 public class State
 {
    //states Enum name
        public Enum name;
    //Delegate for storing functions
        public Delegate d;
    //Constructor for states
        public State()
        {

        }
    //Enum naming current state and to pass delegates to an object.
        public State(Enum CState, Delegate TCtrl)
        {
            //string name turns in current state
            name = CState;
            //Delegate equals Ctrl State
            d = TCtrl;
        }

        public bool Ctrl()
        {
            if (d != null)
            {
                Ctrl c;

                c = d as Ctrl;
                //Calls the delegate and begins functions
                c();
                //returns true
                return true;                    
            }
            //returns false
            return false;
        }     
    }
//class representing transitions on an object
    public class Transition
    {
        //used for the input of a transition
        public string input
        {
            get;
            private set;
        }
        //where the transition is focused on going
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
    //Generic FSM Class
  public class FSM<T>
{
    //Current State
    public State cState
    {
        get;
        private set;
    }

    private List<State> _states;
    //Dictionary containing list of transitions for values
    private Dictionary<Enum, List<Transition>> Trans;
    //Finite State Machine Constructor
    public FSM()
    {
        //Initialize Dictionary
        Trans = new Dictionary<Enum, List<Transition>>();
        //Initializes the list
        _states = new List<State>();
        //Stores state in both
        NewState();
    }
    //Takes in a generic type to attack transitions
    public bool Insert<V>(V value)
    {
        foreach (Transition t in Trans[cState.name])
        {
            if (t.input == value.ToString())
            {
                cState = t.focus;
                //Activates the current state of the function
                cState.Ctrl();
                //returns true
                return true;
            }
        }
        //returns false
        return false;
    }
    //Function for Adding a new state
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
            //Adds transition key to dictionary
            Trans[f].Add(transition);
        }
        else
        {
            Console.WriteLine("Cannot find state");
        }
        //returns true
        return true;
    }
    public bool State(T ss, Delegate del)
    {
        Enum nState = ss as Enum;
        //Creates and instance of a new state object
        State newState = new State();
        //goes through each state in the list
        foreach (State s in _states)
        {//checks in state name is the same as the passed variable.
            if(s.name.ToString() == nState.ToString())
            {//sat the newstate object that was created
                newState = s;
                //break out of the loop
                break;
            }
        }
        newState.d = del;
        //returns true
        return true;
    }

}
