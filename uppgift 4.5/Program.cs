using System;

namespace uppgift_4_5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string heltal = Console.ReadLine();

            for(int i = 0; i < heltal.Length; i++)
            {
                string tecken = heltal[i].ToString();
                int siffra = int.Parse(tecken);
                siffra++;

                if (siffra == 10)
                    Console.WriteLine(0);
                else
                {
                    Console.WriteLine(siffra);
                }
            }
            Console.ReadKey();
        }
    }
}