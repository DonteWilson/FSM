using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Contains a bool to check the actions of a Player/Enemy
public interface IAbilities<T>
{
    bool Combat(T u);
    
}
//creates a public interface for stats for Player and Enemy
public interface IStats
{
    int Upgrade { get; set; }
    int Lvl { get; set; }
    int Armor { get; set; }
    int Dmg { get; set; }
    int XP { get; set; }
    string Type { get; set; }
    string Name { get; set; }
}
public interface IControl<T>
{
    List<Unit> Speed(T u);
    bool Victorious(T p, T e);
    void Objectstats(T u);
   
}
