using System; using System.Collections.Generic; using System.Linq; using System.Threading.Tasks; using System.Windows.Forms;

namespace Project_IDF_Operation_First_Strike
{
    internal static class Program 
    {

        static void Main()
        {

            Data x = new Data();
            x.y();

            Data_spy xy = new Data_spy();
            xy.HamasData();
           

        }
    }
}
