using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero");
            double n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero");
            double n2 = int.Parse(Console.ReadLine());
            double somma = n1 + n2;
            Console.WriteLine($"il risultato è {somma}");
        }
    }
}
