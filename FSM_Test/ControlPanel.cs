using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Creates a a sealed ControlPanel class as a singleton pattern. 
public sealed class ControlPanel : IControl<List<Unit>>
{
    //Creates an instance of a FSM with an i_STATES type
    public FSM<i_STATES> FSM = new FSM<i_STATES>();

    //Constructor for Control Panel
    ControlPanel() { }

    //Private class variable
    static private ControlPanel _instance;

    //Public class varible
    static public ControlPanel instance
    {
        get
        {
            //Checks to see if instance exist
            if (_instance == null)
            {   // if it doesnt exist it creates one
                _instance = new ControlPanel();
            }
            //returns instance.
            return _instance;
        }
    }
    public string winText;

    //Keeps track of all stats on player objects.
    public string stats;
    //checks to see who attacks first.
    public List<Unit> Speed(List<Unit> List)
    {
        //Create a unit list.
        List<Unit> sortedList = new List<Unit>();
        //Sorts the list by speed stats in a descending order.
        sortedList = List.OrderByDescending(u => u.Spd).ToList<Unit>();
        Console.WriteLine(sortedList.ElementAt(0).Name + "I'll draw first");
        //return the sorted list
        return sortedList;
    }
    //void Function for Fight
    //public void Fight(List<Unit> uList)
    //{
        //char input;
        ////Player list
        //Player listp = new Player();
        ////Enemy list
        //Enemy liste = new Enemy();
        //Unit a = new Unit();

        //for(int i = 0; i < uList.Count; i++)
        //{
        //    if(uList.ElementAt(i).Type == "Player")
        //    {
        //        Console.Write("Press  to Attack");
        //        input = (char)Console.Read();

        //        if(input == '1')
        //        {
        //            if(uList.ElementAt(i).Combat(a.Indicator(liste.EP)) == true)
        //            {
        //                break;
        //            }
        //        }
        //    }
        //    else if (uList.ElementAt(i).Type == "Enemy")
        //    {

        //    }
        //}
   // }
    //Displays the stats of a Player
    public void Objectstats(List<Unit> ulist)
    {
        //header for Player Satts
        Console.WriteLine("\nPlayer Info");

        for(int i = 0; i < ulist.Count; i++)
        {
            //keeps up to date with player stats and updates them accordingly.
            Console.WriteLine(ulist.ElementAt(i).Name + "Stats : \n");
            Console.WriteLine("Level: " + ulist.ElementAt(i).Lvl + "Health: " + ulist.ElementAt(i).HP + "Armor: " + ulist.ElementAt(i).Armor + "Exp: " + ulist.ElementAt(i).XP);
        }
    }
    //Checks to see if the player is victorious in battle.
    public bool Victorious(List<Unit> listp, List<Unit> liste)
    {
        int count = 0;
        int counts = 0;
        foreach(Unit p in listp)
        {
            if(p.Life == false)
            {
                count++;
                if(listp.Count == count)
                {
                    Console.WriteLine("You have been Defeated!\n");
                    return true;
                }
            }
        }
        //checks through each enemy in the list and checks to see if they are still alive.
        foreach(Unit e in liste)
        {
            if(e.Life == false)
            {
                counts++;
                if (liste.Count == count)
                {
                    Console.WriteLine("You are Victorious");
                    return true;
                }
            }
        }
        return false;
    }
}

