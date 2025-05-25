using System.Collections.Generic;

class ListofTerrorist
{
    private Dictionary<string, TerroristData> List_TR = new Dictionary<string, TerroristData>();
    public ListofTerrorist()
    {
        TerroristData T1 = new TerroristData("Mohamad", 9, true, "M16","Home");
        TerroristData T2 = new TerroristData("Ali", 6, true, "kalatch","Tenels");
        TerroristData T3 = new TerroristData("Abo Raed", 1, true, "kalatch", "USA");
        List_TR.Add("Mohamaad", T1);
        List_TR.Add("Ali", T2);
        List_TR.Add("Abo Raed", T3);
    }

    public void getInfo()
    {
        foreach (var kvp in List_TR)
        {
            System.Console.WriteLine(kvp.Key +": "+kvp.Value);
        }
    }
}