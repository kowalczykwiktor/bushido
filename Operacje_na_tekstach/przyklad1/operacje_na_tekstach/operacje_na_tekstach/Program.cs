using System;

namespace operacje_na_tekstach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imię");
            string tekst = Console.ReadLine();
            tekst = "Cześć" + tekst;
            Console.WriteLine(tekst);
            Console.WriteLine(tekst.Length);
            Console.ReadKey();
        }
    }
}