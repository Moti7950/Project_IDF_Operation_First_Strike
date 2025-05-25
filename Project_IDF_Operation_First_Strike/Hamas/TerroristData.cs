using System;
using System.Collections.Generic;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public class TerroristData
{
    //name
    private string _name;
    //Rank
    private int _rank;
    //Status = Bool
    private bool _status;
    //Weapons
    private string _weapon;

    public static List<TerroristData> listOfTerrorist = new List<TerroristData>();
    public TerroristData(string name, int rank, bool status, string weapon)
    {
        this._name = name;
        this._rank = rank;
        this._status = status;
        this._weapon = weapon;
        listOfTerrorist.Add(this);
    }

    //Method for get or set a name.
    public void setname(string name)
    {
        this._name = name;
    }
    public string getName()
    {
        return this._name;
    }

    //Method for get or set a rank.
    public void setRank(int rank)
    {
        if (rank > 5)
        {
            Console.WriteLine("enter as number between 1-5");
        }
        this._rank = rank;
    }
    public int getRank(int rank)
    {
        return this._rank;
    }

    //Method for get or set a status.
    public void setStatus(bool status)
    { this._status = status; }
    public bool getStatus(bool status)
    { return this._status; }

    //Method for get or set a weapons.
    public void setWeapons(string weapon)
    { this._weapon = weapon; }
    public string getWeapons(string weaponsi)
    { return this._weapon; }

    public int LevelOfDangour()
    {
        int weaponDanger = 0;
        if (this._weapon == "Knife")
        {
            weaponDanger = 1;

        }
        else if (this._weapon == "Gun")
        {
            weaponDanger = 2;
        }
        else if (this._weapon == "M16 / AK47")
        {
            weaponDanger = 3;
        }
        else
        {
            Console.WriteLine("not a valid weapon");
        }
        return this._rank * weaponDanger;
    }
}




