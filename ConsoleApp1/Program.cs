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
            if (n1<5)
            {
                Console.WriteLine("ilnumero inserito è minore di 5");
            }
            double n2 = int.Parse(Console.ReadLine());
            {
                Console.WriteLine("il numero inserito è maggiore di 5");
            }
            double somma = n1 + n2;
            Console.WriteLine($"il risultato è {somma}");

        }
    }
}
