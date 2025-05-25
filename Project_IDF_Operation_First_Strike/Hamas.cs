using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_IDF_Operation_First_Strike
{
    internal class Hamas
    {

        public Hamas()
        {
            Console.WriteLine("Data of establish is : 1987 ");
            Console.WriteLine("Corent commander is :  abo zaeiv");
        }

        public void Soliders()
        {
            ListofTerrorist List_Soliders = new ListofTerrorist();
            Console.WriteLine("List frome Hamas class");
            List_Soliders.getInfo();
            Console.WriteLine("Done");
        }
    }
}
