
using System;

namespace lab3ex1
{
    /*  L3E1. Scrieti o functie care va calcula suma cifrelor unui numar.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar ");
            int number = int.Parse(Console.ReadLine());
            int suma = SumaCifrelor(number);
            Console.WriteLine($"Suma cifrelor a numarului este {suma}");
        }
        static int SumaCifrelor( int number)
        {
            int SumaCifrelor = 0;
            while (number != 0)
            {
                SumaCifrelor += number % 10;
                number /= 10;
            }
            return SumaCifrelor;
        }
        
    }
}
