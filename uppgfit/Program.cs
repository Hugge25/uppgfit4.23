using System;

namespace Uppgfit4._23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            int helTal = int.Parse(Console.ReadLine());

            Console.WriteLine("Vill du skriva in ett till heltal. 1/0 (1 = ja, 0 = nej");
            int igen = int.Parse(Console.ReadLine());
            while (igen == 1)
            {
                if (igen == 1)
                {
                    Console.WriteLine("Skriv in ett heltal");
                    int i = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vill du skriva in ett till heltal. 1/0 (1 = ja, 0 = nej");
                    igen = int.Parse(Console.ReadLine());
                    if (helTal < i)
                    {
                        helTal = i;
                    }
                }
            }
            Console.WriteLine("Det största nummert du skrev in var:");
            Console.WriteLine($"{helTal}");
        }
    }
}
