using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] items = {5.0, 6.0, 7.0};

            Console.WriteLine(DoubleItems(items));
        }

        static double DoubleItems(double[] items)
        {
            int i= 0;
            double sumAll = 0;
            foreach (double item in items)
            {
                sumAll += items[i];
                i++;
            }
            return sumAll;
        }
    }
}
