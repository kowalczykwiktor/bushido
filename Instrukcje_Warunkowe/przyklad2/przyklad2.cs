class Program
{
    static void main(string[] args)
    {
        double a = 0, b = -4, c = 4, delta;
        if (a != 0)
        {
            delta = Math.Pow(b, 2.0) -4 * a * c;
            Console.WriteLine("Delta={0}", delta);
        }
        else
        {
            Console.WriteLine("Współczynnik a jest równy zero");
        }
        Console.ReadKey();
    }
}