using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class Unit : IStats, IAbilities<Unit> 
{
    [NonSerialized]public string stuff;
    private int m_uLvl;
    private int m_uArmor;
    private int m_uXP;
    private int m_uDmg;
    private string m_uType;
    private List<Unit> m_member = new List<Unit>();
    private Unit m_uTarget;
    private bool m_uLife;
    private int m_uMHP;
    private int m_uHP;
    private int m_uSpd;
    public string m_uName;

    public Unit()
    {

    }
    public Unit(string name, int HP, int Armor,int dmg, int Spd, int XP, string type)
    {
        m_uName = name;
        m_uHP = HP;
        m_uArmor = Armor;
        m_uDmg = dmg;
        m_uSpd = Spd;
        m_uXP = XP;
        m_uLife = true;
        m_uLvl = 1;
    }


    public string Name
    {
        get
        {
            return m_uName;
        }
        set
        {
            m_uName = value;
        }
    }
    public int MHP
    {
        get
        {
            return m_uMHP;
        }
        set
        {
            m_uMHP = value;
        }
    }
    public int Dmg
    {
        get
        {
            return m_uDmg;
        }
        set
        {
            m_uDmg = value;
        }
    }
    public int Spd
    {
        get
        {
            return m_uSpd;
        }
        set
        {
            m_uSpd = value;
        }
    }
    public int Lvl
    {
        get
        {
            return m_uLvl;
        }
        set
        {
            m_uLvl = value;
        }
    }
    public bool Life
    {
        get
        {
            return m_uLife;
        }
        set
        {
            m_uLife = value;
        }
    }


    public Unit Target
    {
        get
        {
            return m_uTarget;
        }
        set
        {
            m_uTarget = value;
        }
    }
    public int HP
    {
        get
        {
            return m_uHP;
        }
        set
        {
            m_uHP = value;
        }
    }
    public int Upgrade
    {
        get
        {
            return m_uLvl;
        }
        set
        {
            m_uLvl = value;
        }
    }
    public int Armor
    {
        get
        {
            return m_uArmor;
        }
        set
        {
            m_uArmor = value;
        }
    }
    public int XP
    {
        get
        {
            return m_uXP;
        }
        set
        {
            m_uXP = value;
        }
    }
    public string Type
    {
        get
        {
            return m_uType;
        }
        set
        {
            m_uType = value;
        }
    }
    public bool Combat(Unit u)
    {
        if(u == null)
        {
            return false;
        }

        if (u.HP > 0)
        {
            float avg = u.Armor * 0.25f;
            u.HP -= Dmg;
            stuff = this.Name + " is in Combat " + u.Name + "\n";
            stuff += u.Name + "took" + Dmg + "damage!\n";
            return true; 
        }
        else
        {
            Console.WriteLine(u.Name + "has been defeated");
            this.XP += u.XP;
            return false;
        }

    }
    public List<Unit> member
    {
        get
        {
            return m_member;
        }
        set
        {
            m_member = value;
        }
    }
    //Indicate she enemies hp and checks to see if dead or alive.
    //public Unit Indicator(List<Unit> EP)
    //{
    //    string Input;

    //    Console.WriteLine("Chose a target: \n");
    //    for (int i = 0; i < EP.Count; i ++)
    //    {
    //        Console.WriteLine(EP.ElementAt(i).Name);
    //    }

    //    Input = Console.ReadLine();
    //    for (int i = 0; i < EP.Count; i++)
    //    {
    //        if (Input == EP.ElementAt(i).Name && EP.ElementAt(i).Life == true)
    //        {
    //            Target = EP.ElementAt(i);
    //        }
    //        else if (Input == EP.ElementAt(i).Name && EP.ElementAt(i).Life == false)
    //        {
    //            //Has Detected that the target is dead.
    //            Console.WriteLine(EP.ElementAt(i).Name + "Target is Dead\n");
    //            Indicator(EP);
    //        }
    //    }
    //    return Target;
    public void LvlUP()
    {
        if(this.XP == 50)
        {
            stuff += "\n" + this.Name + "Leveled Up!\n";
            this.Lvl++;
            this.XP = 0;
            this.m_uHP += 15;
            this.Armor += 5;
            this.Spd += 2;
        }
    }
    public Unit encounter(List<Unit> party)
    {
        Random r = new Random();

        int index = r.Next(0, party.Count);
        Unit victim = party[index];
        if(victim.Life)
        {
            return victim;
        }
        else
        {

        }
        return null;
    }
}
