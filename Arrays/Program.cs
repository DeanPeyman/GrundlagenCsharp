using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 20;
            int summe = 0;
            int[] noten = new int[n];
            for (int i = 0; i < n; i++) 
            {

                Console.WriteLine($"Bitte geben Sie die {i+1} Note ein");
                noten[i] = Convert.ToInt32(Console.ReadLine());
                summe = summe + noten[i];
            }

            for (int p = 0; p < noten.Length; p++)
            {

                Console.WriteLine(noten[p]);

            }

            Console.WriteLine("Der Notendurchschnitt beträgt:");
            Console.WriteLine(summe / n);

        }
    }
}
