class Program
{
    static void main(string[] args)
    {
        double a = 0, b = -4, c = 4, delta;
        if (a != 0)
        {
            delta = Math.Pow(b, 2.0) -4 * a * c;
            Console.WriteLine("Delta={0}", delta);
            if (delta == 0)
            {
                Console.WriteLine("Pierwiastek x={0,6:F2}", -b / (2 * a));
            }
            Console.WriteLine("Pierwiastek x1= {0,6:F2}", (-b + Math.Sqrt(delta)) / (2 * a));
            Console.WriteLine("Pierwiastek x2= {0,6:F2}", (-b - Math>Sqrt(delta)) / (2 * a));
        }
        else
        {
            Console.WriteLine("Delta jest ujemna - brak pierwiastka");
        }
        Console.ReadKey();
    }
}