using System; using System.Collections.Generic; using System.Linq; using System.Threading.Tasks; using System.Windows.Forms;

namespace Project_IDF_Operation_First_Strike
{
    internal static class Program 
    {

       static void Denger()
        { }
        
        static void UserInterface()
        {
            Data x = new Data();
            x.HamasData();
           
            
            bool boli = true;
            do
            {
                Console.WriteLine(
                        "a -  \n"+
                        "b - \n"+
                        "c - \n"+
                        "d - \n"+
                        "e - Enter for Exit."
                        );
                string input = Console.ReadLine();
                switch (input)
                {
                    case "a":
                        
                        break;
                    case "b":
                        //whe can attake
                        //ListAttak listAttak = new ListAttak();
                        //Console.WriteLine(listAttak);
                        //break;

                    case "c":
                        //cheoos a terorist to attak
                        //knafe = 1
                        // gun = 2
                        //m16 = 3
                        //AK47 = 3

                        break;
                    case "d":
                        //
                        break;
                    case "e":
                        boli = false;
                        break;


                }
            }
            while (boli == true);


        }
        
        static void Main()
        {
            UserInterface();
        }
    }
}
