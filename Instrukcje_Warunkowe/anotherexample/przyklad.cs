class Program
{
    static void main([string] args)
    {
        Console.WriteLine("Wpisz porę roku po polsku");
        string poraRoku = Console.ReadLine();
        switch (poraRoku)
        {
            case "Wiosna":
            //Console.WriteLine("Spring1");
            //break;
            case "Lato":
            Console.WriteLine("Spring or Summer");
            break;
            case "Jesień":
            Console.WriteLine("Autumn");
            break;
            case "Zima":
            Console.WriteLine("Winter");
            break;
            default:
            Console.WriteLine("Nie ma takiej pory roku");
            break;
        }
        Console.ReadKey();
    }
}