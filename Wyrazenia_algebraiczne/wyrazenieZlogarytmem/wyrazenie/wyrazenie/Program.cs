using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyrazenie
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Podaj wartość x (większą od 0):");
            x = Convert.ToDouble(Console.ReadLine());
            y = Math.PI * Math.Sqrt(Math.Abs(Math.Sin(x)) * Math.Log(x, 2.0));
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
