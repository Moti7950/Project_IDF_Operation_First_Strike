using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    private List<string> _weapons;

    public static List<TerroristData> listOfTerrorist = new List<TerroristData>();
    public TerroristData(string name, int rank,  List<string> weapons,bool status = true)
    {
        this._name = name;
        this._rank = rank;
        this._status = status;
        this._weapons = weapons;
        listOfTerrorist.Add(this);
    }

    //Method for get or set a name.
    public void setName(string name)
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
    public int getRank()
    {
        return this._rank;
    }

    //Method for get or set a status.
    public void setStatus(bool status)
    { this._status = status; }
    public bool getStatus()
    { return this._status; }

    //Method for get or set a weapons.
    public void setWeapons(List<string> weapons)
    { this._weapons = weapons; }
    public List<string> getWeapons()
    { return this._weapons; }

    public int LevelOfDangour()
    {
        int weaponDanger = 0;
        foreach (string weapon in _weapons )
        if (weapon == "Knife")
        {
            weaponDanger += 1;

        }
        else if (weapon == "Gun")
        {
            weaponDanger += 2;
        }
        else if (weapon  == "M16" || weapon ==  "AK47")
        {
            weaponDanger += 3;
        }
        else
        {
            Console.WriteLine("not a valid weapon");
        }
        return this._rank * weaponDanger;
    }
    public void  DisplayAllTerrorists()
    {
        foreach (TerroristData terrorist in TerroristData.listOfTerrorist)
        {
            Console.WriteLine(terrorist.getName());
        }
    }
}




