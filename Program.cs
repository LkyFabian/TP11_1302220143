using Library;
using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] persamaan = { 1, -3, -10 };
            double[] akar = Aljabar.AkarPersamaanKuadrat(persamaan);
            double[] hasilKuadrat = Aljabar.HasilKuadrat(new double[] { 2, -3 });

            Console.WriteLine(" Berikut akar persamaan kuadrat:");
            foreach (var akarValue in akar)
            {
                Console.WriteLine(akarValue);
            }

            Console.WriteLine("\n Berikut hasil kuadrat persamaan berpangkat 1:");
            foreach (var value in hasilKuadrat)
            {
                Console.WriteLine(value);
            }

        }
    }
}