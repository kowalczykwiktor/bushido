using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyrazenia_algebraiczne
{
    class Program
    {
        static void Main(string[] args)
        {
            const int liczbaMiesiecy = 12;
            int liczbaSamochodow;
            double sredniaSprzedazSamochodow;
            Console.WriteLine("Podaj roczną sprzedaż samochodów:");
            liczbaSamochodow = Convert.ToInt32(Console.ReadLine());
            sredniaSprzedazSamochodow = (double)liczbaSamochodow / (double)liczbaMiesiecy;
            Console.WriteLine(sredniaSprzedazSamochodow);
            Console.ReadKey();
        }
    }
}