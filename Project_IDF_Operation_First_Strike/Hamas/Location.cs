using System;

public class Location
{
    public Location()
    {

    }

    Random x = new Random();
    public string randomeWeapons()
    {
        string[] loction = { "open areas", "vehicles", "buildings"};
        string choseloction = loction[x.Next(loction.Length)];
        return choseloction;
    }
}