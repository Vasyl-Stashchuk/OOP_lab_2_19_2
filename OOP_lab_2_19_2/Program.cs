using System;

namespace OOP_lab_2_19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -2;

            while (x <= 12)
            {
                double y = (x * x * x * x - 12 * x) / (x - 2);

                if (x != 2)
                {
                    Console.WriteLine("x = {0,4:f1}, y = {1:f4}", x, y);
                }
                else
                {
                    Console.WriteLine("x = {0,4:f1}, y - не iснує", x);
                }

                x += 0.5;
            }
        }
    }
}
