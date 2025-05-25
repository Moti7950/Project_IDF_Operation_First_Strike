using System; using System.Collections.Generic; using System.Linq; using System.Threading.Tasks; using System.Windows.Forms;

namespace Project_IDF_Operation_First_Strike
{
    internal static class Program 
    {

       static void UserInterface()
        {
            Data x = new Data();
            x.HamasData();
            Console.WriteLine("Plesa select:");
            string input = Console.WriteLine();
            switch (input)
            {
                case "a":
                    //serch the denger terorist
                    break;
                case "b":
                    //whe can attake
                    break;
                case "c":
                    //cheoos a terorist to attak
                    break;
                case "d":
                    //
                    break;

            }


        }
        
        static void Main()
        {
            UserInterface();
        }
    }
}
