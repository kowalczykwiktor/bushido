class Program
{
    static void main([string] args)
    {
        Console.WriteLine("Wpisz porę roku po polsku");
        string poraRoku = Console.ReadLine();
        switch (poraRoku)
        {
            case "Wiosna":
            Console.WriteLine("Spring1");
            Console.WriteLine("Spring2"); //dodatkowa instrukcja
            //break;
            goto case "Lato";
            case "Lato":
            Console.WriteLine("Summer");
            Console.WriteLine("Summer2"); //dodatkowa instrukcja
            break;
            case "Jesień":
            Console.WriteLine("Autumn");
            Console.WriteLine("Autumn2"); //dodatkowa instrukcja
            break;
            case "Zima":
            Console.WriteLine("Winter");
            Console.WriteLine("Winter2"); //dodatkowa instrukcja
            break;
            default:
            Console.WriteLine("Nie ma takiej pory roku");
            break;
        }
        Console.ReadKey();
    }
}