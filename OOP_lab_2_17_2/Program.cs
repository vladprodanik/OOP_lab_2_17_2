using System;

namespace OOP_lab_2_17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(double x = 0; x <= 3; x += 0.025)
            {
                double y = Math.Log10(x) / (4 * x + 13);
                Console.WriteLine("x = {0:f4} y = {1:f4}", x, y);
            }
        }
    }
}
