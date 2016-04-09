using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Contains a bool to check the actions of a Player/Enemy
//Public interface for abilities 
public interface IAbilities<T>
{
    bool Combat(T u);
    
}
//creates a public interface for stats for Player and Enemy
public interface IStats
{
    //Upgrade property
    int Upgrade { get; set; }
    //Level Property
    int Lvl { get; set; }
    //Armor Property
    int Armor { get; set; }
    //Dmg Property
    int Dmg { get; set; }
    //Experience Property
    double XP { get; set; }
    //Health Property
    int HP { get; set; }
    string Type { get; set; }
    //Name Property
    string Name { get; set; }
}
//Public interface for Controlling the game
public interface IControl<T>
{
    List<Unit> Speed(T u);
    //Checks to see if player is victorious.
    bool Victorious(T p, T e);
   //Displays player object stats in the game.
    void Objectstats(T u);
   
}
