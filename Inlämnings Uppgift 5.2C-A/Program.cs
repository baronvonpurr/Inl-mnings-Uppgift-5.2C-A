using System;

namespace Uppgift5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många tal vill du skriva in?");
            int antal = int.Parse(Console.ReadLine());
            int[] nummer = new int[antal];

            for (int i = 0; i < antal; i++)
            {
                Console.Write($"Skriv in tal nr {i + 1}: ");
                nummer[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Detta är talen som du har skrivit");
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine($"Tal nr {i + 1}: {nummer[i]}");
            }
        }
    }
}