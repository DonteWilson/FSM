using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Contains a bool to check the actions of a Player/Enemy
public interface IAbilities<T>
{
    bool Combat(T u);
    int Skill1();
    int Skill2();
    int Skill3();
    int Skill4();
    
}
//creates a public interface for stats for Player and Enemy
public interface IStats
{
    int Upgrade { get; set; }
    int Armor { get; set; }
    int XP { get; set; }
    string Type { get; set; }
    string Name { get; set; }
}
public interface IControl<T, U,V, W>
{
    List<Unit> Speed(T u);
    bool Victorious(bool b, U p, V e);
    void Fight(T u, W f);
    void Objectstats(T u);
   
}
