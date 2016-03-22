using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class Unit : IStats, IAbilities<Unit> 
{
    private int m_uLvl;
    private int m_uArmor;
    private int m_uXP;
    private string m_uType;
    private List<Unit> m_member = new List<Unit>();
    private Unit m_uTarget;
    private bool m_uLife;
    private int m_uHP;
    private int m_uSpd;
    public string m_uName;

    public Unit()
    {

    }
    public Unit(string name, int HP, int Armor, int Spd, int XP, string type)
    {
        m_uName = name;
        m_uHP = HP;
        m_uArmor = Armor;
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
            u.HP -= this.Armor * (int)avg;
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
    public Unit Indicator(List<Unit> EP)
    {
        string Input;

        Console.WriteLine("Chose a target: \n");
        for (int i = 0; i < EP.Count; i ++)
        {
            Console.WriteLine(EP.ElementAt(i).Name);
        }

        Input = Console.ReadLine();
        for (int i = 0; i < EP.Count; i++)
        {
            if (Input == EP.ElementAt(i).Name && EP.ElementAt(i).Life == true)
            {
                Target = EP.ElementAt(i);
            }
            else if (Input == EP.ElementAt(i).Name && EP.ElementAt(i).Life == false)
            {
                //Has Detected that the target is dead.
                Console.WriteLine(EP.ElementAt(i).Name + "Target is Dead\n");
                Indicator(EP);
            }
        }
        return Target;
    }
}
