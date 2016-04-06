using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class Unit : IStats, IAbilities<Unit> 
{
    //Stores combat text
    public string stuff;
    //Level Int
    private int m_uLvl;
    //Armor int
    private int m_uArmor;
    //XP Int
    private int m_uXP;
    //Dmg Int
    private int m_uDmg;
    private string m_uType;
    //creates a member list
    private List<Unit> m_member = new List<Unit>();
    private Unit m_uTarget;
    //Bool seeing if target is alive
    private bool m_uLife;
    //HP int
    private int m_uHP;
    //Speed Int
    private int m_uSpd;
    //String Name
    public string m_uName;
    //Default Constructor
    public Unit()
    {

    }
    //Unit class that stores Name, HP, Armor, DMG, Spd, XP, Type
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

    //String name property
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
    //Dmg int property
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
    //Spd int property
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
    //Level int property
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
    //Health int property
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
    ////Upgrade int property
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
    //Armor int property
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
    //Experience Property
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
    //String type property
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
            //Takes off a certain amount of damage based on armor
            float deflect = u.Armor * 0.25f;
            u.HP -= Dmg;
            stuff = this.Name + " is in Combat " + u.Name + "\n";
            stuff += u.Name + "took" + Dmg + "damage!\n";
            //returns true
            return true; 
        }
        else
        {
            Console.WriteLine(u.Name + "has been defeated");
            this.XP += u.XP;
            //return false
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
    //Function used for a enemy targeting player
    public Unit encounter(List<Unit> party)
    {
        //Creates Instance of Random Object
        Random r = new Random();

        int index = r.Next(0, party.Count);
        //stores unit as a party index
        Unit victim = party[index];
        //If victim life true
        if (victim.Life)
        {
            //return victim
            return victim;
        }
        else
        {

        }
        //return null if dead
        return null;
    }
    //Leveling Algortihm
    //Similar to borderlands
    public void LvlUP()
    {
        //Leveling system similar to borderlands 
        //Takes Current Lvl and times it by 50, so eacch time the player levels the amount of XP
        //needed for next lvl is increased by 50
        int XPCAP = this.Lvl * 50;
        if(this.XP >= XPCAP)
        {
            stuff += "\n" + this.Name + "Leveled Up!\n";
            this.Lvl++;
            this.XP = 0;
            this.m_uHP += 15;
            this.Armor += 5;
            this.Spd += 2;
        }
    }
 
}
