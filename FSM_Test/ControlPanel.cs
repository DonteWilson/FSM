using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public sealed class ControlPanel : IControl<List<Unit>>
{
    public FSM<i_STATES> FSM = new FSM<i_STATES>();

    ControlPanel() { }

    static private ControlPanel _instance;

    static public ControlPanel instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ControlPanel();
            }
            return _instance;
        }
    }
    public string winText;

    public string stats;
    //checks to see who attacks first.
    public List<Unit> Speed(List<Unit> List)
    {
        List<Unit> sortedList = new List<Unit>();

        sortedList = List.OrderByDescending(u => u.Spd).ToList<Unit>();
        Console.WriteLine(sortedList.ElementAt(0).Name + "I'll draw first");

        return sortedList;
    }
    //void Function for Fight
    public void Fight(List<Unit> uList)
    {
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
    }
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

