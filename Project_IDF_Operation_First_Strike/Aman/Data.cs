using System;
using System.Drawing.Drawing2D;

class Data
{
    public Data()
    { 
        //Get Info about the terrorist
        //Name
        //Rank
        //Status
        //Locaition
        //Weapons
        //Timestemp of the Data
    }

    public void HamasData()
    {
        Data_spy hamasi = new Data_spy();
        Console.WriteLine("Frome Aman_Data");
        hamasi.HamasData();
        DateTime now = DateTime.Now;
        string dateAndTime = now.ToString("dd/MM/yyyy HH:mm");
        Console.WriteLine(dateAndTime);
        Console.WriteLine("Done!");
    }
        

}