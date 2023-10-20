using System;

namespace uppgift_4_5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string heltal = Console.ReadLine();
            string talet = "";
            for(int i = 0; i < heltal.Length; i++)
            {
                string tecken = heltal[i].ToString();
                int siffra = int.Parse(tecken);
                siffra++;

                if (siffra == 10)
                {
                    siffra = 0;
                }

                talet += "" + siffra;

            }
            Console.WriteLine(talet);
            Console.ReadKey();
        }
    }
}
