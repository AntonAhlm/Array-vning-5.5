using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Ålder = new int[99];
            int i = 0;
            string svar;
            do
            {
                Console.Write("Skriv in åldern på en hyresgäst : ");
                Ålder[i] = Convert.ToInt32(Console.ReadLine());
                i++;

                Console.Write("Vill du fortsätta? j/n : ");
                svar=Console.ReadLine();

            } while (svar=="j");


            for (i = 0; i < Ålder.Length; i++)
                if (Ålder[i] > 0)
                {
                    Console.WriteLine("Personen i index " + i + " är " + Ålder[i] + " år gammal");
                }
                else
                    break;
        }
    }
}
