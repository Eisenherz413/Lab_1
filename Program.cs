using System;

namespace HelloWorld2021
{
    class FirstLab
    {
        static void Main(string[] args)
        {
            int alpha = Convert.ToInt32(Console.ReadLine());


            double z1 = (Math.Sin((Math.PI / 2) + 3 * alpha)) / (1 - Math.Sin(3 * alpha - Math.PI));
            double z2 = Math.Cos((5 / 4) * Math.PI + (3 / 2 * alpha)) / Math.Sin((5 / 4) * Math.PI + (3 / 2 * alpha));

            Console.WriteLine($"z1= {z1}, z2= {z2}");

        }
    }
}
