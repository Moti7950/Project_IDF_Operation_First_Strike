using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_IDF_Operation_First_Strike
{
    internal class IDF
    {
        public IDF()
        {}
        public void Info_obout_IDF()
        {
            Console.WriteLine("Data of establish is : 26/05/1948 ");
            Console.WriteLine("Corent commander is : eyall zamir ");
        }
        //Get the List frome strike
        public void ListStrike()
        {
            ListAttak listAttak = new ListAttak();
            Console.WriteLine(listAttak);
        }
    }

}

