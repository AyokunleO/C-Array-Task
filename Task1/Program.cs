using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // int[] series = new int [5];
             int[] series = {3, 4, 5};
            Console.WriteLine(Product(series));
        }

        static int Product (int[] series)
        {
            int product = 1;
            for (int i = 0; i < series.Length; i++)
            {
                product *= series[i];
            }
            return product;
        }
    }
}
