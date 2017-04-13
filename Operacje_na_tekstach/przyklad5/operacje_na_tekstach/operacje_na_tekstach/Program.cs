using System;

namespace operacje_na_tekstach
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 12.34567, wskaznik = 0.45;
            int suma = 10;
            string imie = "Jan", nazwisko = "Nowak";
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1. Imię: {0,8} Nazwisko: {1,10}", imie, nazwisko);
            Console.WriteLine("2. Imię: {0,-8} Nazwisko: {1,-10}", imie, nazwisko);
            Console.WriteLine("3. Wartość: {0,10} to suma", suma);
            Console.Write("4. Wskaźnik: {0,8:P4}", wskaznik);
            Console.WriteLine("5. Waga: {0,8} kg Waga: {0,8:F2} kg", x);
            Console.ReadKey();
        }
    }
}