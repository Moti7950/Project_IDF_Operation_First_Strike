using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_IDF_Operation_First_Strike
{
    internal static class Program 
    {

        static void Main()
        {
            Console.WriteLine("Test");
            Dictionary<string, TerroristData> List_TR = new Dictionary<string, TerroristData>();
            TerroristData T1 = new TerroristData("Mohamad",9,true,"M16");
            TerroristData T2 = new TerroristData("Ali", 6, true, "kalatch");
            TerroristData T3 = new TerroristData("Abo Raed", 1, true, "kalatch");
            List_TR.Add("Mohamaad",T1);
            List_TR.Add("Ali",T2);
            List_TR.Add("Abo Raed",T3);
            foreach (var kvp in List_TR)
            {
                Console.WriteLine(kvp.Key + ": " +kvp.Value.getName());
            }


        }
    }
}
