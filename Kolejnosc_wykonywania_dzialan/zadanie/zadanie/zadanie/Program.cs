using System;

namespace zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            bool czyWagaNorma;
            double waga, wzrost, wskaznikBMI;

            //wczytajmy dane nt. użytkownika
            Console.Write("Podaj wagę swojego ciała w kilogramach:");
            waga = double.Parse(Console.ReadLine());
            Console.Write("Podaj swój wzrost w metrach:");
            wzrost = double.Parse(Console.ReadLine());

            //obliczmy BMI dla użytkownika
            wskaznikBMI = waga / Math.Pow(wzrost, 2.0);
            czyWagaNorma = wskaznikBMI >= 18.5 && wskaznikBMI < 25;
            Console.WriteLine("BMI = {0,6:F2}", wskaznikBMI);
            Console.WriteLine("Czy Twoja waga jest w normie = {0}", czyWagaNorma);

            //obliczmy wagę idealną wg. Lorentz-a
            double wskLorentzaKobieta = wzrost * 100 - 100 - (wzrost * 100 - 150) / 2;
            double wskLorentzaMezczyzna = wzrost * 100 - 100 - (wzrost * 100 - 150) / 4;
            Console.WriteLine("Waga wg. Lorentza dla kobiet = {0,6:F2}", wskLorentzaKobieta);
            Console.WriteLine("Waga wg. Lorentza dla mężczyzn = {0,6:F2}", wskLorentzaMezczyzna);
            Console.ReadKey();
        }
    }
}