using System;
using System.Collections.Generic;

public class Wepens_Terorist
{
    public Wepens_Terorist()
    {

    }

    Random x = new Random();
    public string randomeWeapons()
    {
        string[] weapons = { "Knife", "Gun", "M16", "AK47" };
        string choseweapon = weapons[x.Next(weapons.Length)];
        return choseweapon;
    }
}