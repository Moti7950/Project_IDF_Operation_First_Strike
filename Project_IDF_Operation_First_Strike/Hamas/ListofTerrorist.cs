using System.Collections.Generic;

class ListofTerrorist
{
    public ListofTerrorist()
    {
        Dictionary<string, TerroristData> List_TR = new Dictionary<string, TerroristData>
        {
            { "Mohamad", new TerroristData("Mohamad", 9, true, "M16") },
            { "Ali", new TerroristData("Ali", 6, true, "Kalatch") },
            { "Abo Raed", new TerroristData("Abo Raed", 1, true, "Kalatch") }
        };
        //Dictionary<string, TerroristData> List_TR = new Dictionary<string, TerroristData>();
        //TerroristData T1 = new TerroristData("Mohamad", 9, true, "M16");
        //TerroristData T2 = new TerroristData("Ali", 6, true, "kalatch");
        //TerroristData T3 = new TerroristData("Abo Raed", 1, true, "kalatch");
        //List_TR.Add("Mohamaad", T1);
        //List_TR.Add("Ali", T2);
        //List_TR.Add("Abo Raed", T3);
    }
}