using System.Collections.Generic;

class ListofTerrorist
{
    private Dictionary<string, TerroristData> List_TR = new Dictionary<string, TerroristData>();
    
    public ListofTerrorist()
    {
        Wepens_Terorist wep_TR = new Wepens_Terorist();
        TerroristData T1 = new TerroristData("Mohamad", 9, true, wep_TR.randomeWeapons(), "Home");
        TerroristData T2 = new TerroristData("Ali", 6, true, wep_TR.randomeWeapons(), "Tenels");
        TerroristData T3 = new TerroristData("Abo Raed", 1, true, wep_TR.randomeWeapons(), "USA");
        List_TR.Add("Mohamaad", T1);
        List_TR.Add("Ali", T2);
        List_TR.Add("Abo Raed", T3);
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
}