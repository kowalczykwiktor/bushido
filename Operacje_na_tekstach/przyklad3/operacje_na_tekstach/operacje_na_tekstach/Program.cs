using System;

namespace operacje_na_tekstach
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 6, suma = a + b;
            Console.WriteLine("a=" + a + " b=" + b + " Suma=" + suma);
            Console.WriteLine("a={0} b={1} Suma={2}", a, b, suma);
            Console.ReadKey();
        }
    }
}
