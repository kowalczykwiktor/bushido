using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyrazenia_logiczne
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            bool wynik;
            wynik = !((x == 1 || x == 3 || x == 5) && y < 1); //zapis negacji przed wyrażeniem logicznym
            Console.WriteLine(wynik);
            Console.ReadKey();
        }
    }
}