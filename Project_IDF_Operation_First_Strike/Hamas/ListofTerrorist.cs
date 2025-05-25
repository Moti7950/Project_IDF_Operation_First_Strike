using System;
using System.Collections.Generic;

class ListofTerrorist
{
    private Dictionary<string, TerroristData> List_TR = new Dictionary<string, TerroristData>();

    
    public ListofTerrorist()
    {
        Wepens_Terorist wep_TR = new Wepens_Terorist();
        Location loc_TR = new Location();
        TerroristData T1 = new TerroristData("Mohamad", rand.Next(1,10), true, wep_TR.randomeWeapons(), loc_TR.randomeWeapons());
        TerroristData T2 = new TerroristData("Ali", rand.Next(1, 10), true, wep_TR.randomeWeapons(), loc_TR.randomeWeapons());
        TerroristData T3 = new TerroristData("Abo Raed", rand.Next(1, 10), true, wep_TR.randomeWeapons(), loc_TR.randomeWeapons());
        List_TR.Add("Mohamaad", T1);
        List_TR.Add("Ali", T2);
        List_TR.Add("Abo Raed", T3);
    }

    Random rand = new Random();
    public void Random_rank()
    { 
        int ranki = rand.Next();
    }
    public void getInfo()
    {
        int num = 1;
        foreach (var kvp in List_TR)
        {
            System.Console.WriteLine($"{num + ": "}{kvp.Key} : {kvp.Value}");
            num +=1;

        }

    }
    public Dictionary<string, TerroristData> GetDictionary()
    {
        return List_TR;
    }
}