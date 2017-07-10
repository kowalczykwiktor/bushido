class Program
{
    static void Main(string[] args)
    {
        double a = 1, b = -4, c = 4, delta, x;
        delta = Math.Pow(b, 2.0) -4 * a * c;
        Console.WriteLine("Delta={0}", delta);
        if (delta == 0)
        {
            x = -b / (2 * a);
            Console.WriteLine("Pierwiastek={0}", x);
        }
        Console.ReadKey();
    }
}