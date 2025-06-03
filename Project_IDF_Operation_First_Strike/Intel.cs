using System;
using System.Collections.Generic;

class Intel
{
    public TerroristData Terrorist { get; set; }
    public string Location { get; set; }
    public DateTime Timestamp { get; set;}
    public static List<Intel> listOfIntel = new List<Intel>();

    public Intel(TerroristData terrorist, string location, DateTime timestamp)
    {
        this.Terrorist = terrorist;
        this.Location = location;
        this.Timestamp = timestamp;

        listOfIntel.Add(this);
    }
    public void PrintReport()
    {
        Console.WriteLine($"Terrorist: {Terrorist.getName()}"); 
        Console.WriteLine($"Location: {Location}");
        Console.WriteLine($"Timestamp: {Timestamp:yyyy-MM-dd HH:mm:ss}");

    }

}