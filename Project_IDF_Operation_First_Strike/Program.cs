using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;
namespace Project_IDF_Operation_First_Strike
{
    internal static class Program 
    {

        //public static async Task  Main()
        static void Main()
        {
            Env.Load("C:\\Users\\ydovz\\OneDrive\\Desktop\\8200\\Project_IDF_Operation_First_Strike\\Project_IDF_Operation_First_Strike\\.env");
            string apikey = Environment.GetEnvironmentVariable("GEMINI_API");
            Console.WriteLine(apikey);
            TerroristData t1 = new TerroristData("ali", 4, new List<string>{ "Gun" });
            TerroristData t2 = new TerroristData("abu", 3, new List<string> { "Knife" });
            TerroristData t3 = new TerroristData("muhamad", 4, new List<string> { "Gun" });
            TerroristData t4 = new TerroristData("ahmed", 3, new List<string> { "Knife" });


            foreach (TerroristData terrorist in TerroristData.listOfTerrorist)
            {
                Console.WriteLine(terrorist.getName());
            }
            DateTime timestamp = DateTime.Now;
            Intel intelT1 = new Intel(t1, "building", timestamp);
            Intel intelT2 = new Intel(t2, "building", timestamp);
            Intel intelT3 = new Intel(t3, "open Area", timestamp);
            Intel intelT4 = new Intel(t4, "vhicle", timestamp);
            Drone MQ9Reaper = new Drone("MQ9Reaper");
            foreach (Intel intel in Intel.listOfIntel)
            {
                Console.WriteLine(intel.Location);
            }
            Drone drone1 = new Drone("drone1");
            FighterJet f16 = new FighterJet();
            Artillery tank1 = new Artillery();
            strikeManager strike = new strikeManager();
            //strike.Strike(1);
            Menu.Options();



        }
    }
}
