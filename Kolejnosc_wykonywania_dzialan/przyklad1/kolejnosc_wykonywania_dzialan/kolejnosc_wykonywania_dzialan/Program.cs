using System;

namespace kolejnosc_wykonywania_dzialan
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 1;
            a = b = c; //od prawej do lewej
            Console.WriteLine("a={0}", a);
            Console.WriteLine("suma={0}", a + b + c); //od lewej do prawej
            Console.ReadKey();
        }
    }
}