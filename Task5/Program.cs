using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] salary = new salary[9];

            Console.WriteLine("Enter the person's salary");
            double inputSalary = Convert.ToDouble(Console.ReadLine());

            if(inputSalary != -1)
            {
                double computedSal = (inputSalary*(0.09)) + 200;
                if(computedSal < 300)
                {
                    salary[0] = salary[0] + 1;
                } else if(computedSal < 400)
                {
                    salary[1] = salary[1] + 1;
                } else if(computedSal < 500)
                {
                    salary[2] = salary[2] + 1;
                } else if(computedSal < 600)
                {
                    salary[3] = salary[3] + 1;
                } else if(computedSal < 700)
                {
                    salary[4] = salary[4] + 1;
                } else if(computedSal < 800)
                {
                    salary[5] = salary[5] + 1;
                } else if(computedSal < 900)
                {
                    salary[6] = salary[6] + 1;
                } else if(computedSal < 1000)
                {
                    salary[7] = salary[7] + 1;
                } else {
                    salary[8] = salary[8] + 1;
                }
            }
        
        for (int i = 0; i < salary.Length; i++)
        {
            // int num = 0;
            switch (i)
            {
                case 0:
                    Console.WriteLine($"$200-299: {salary[i]}");
                    break;

                case 1:
                    Console.WriteLine($"$300-399: {salary[i]}");
                    break;

                case 2:
                    Console.WriteLine($"$400-499: {salary[i]}");
                    break;

                case 3:
                    Console.WriteLine($"$500-599: {salary[i]}");
                    break;

                case 4:
                    Console.WriteLine($"$600-699: {salary[i]}");
                    break;

                case 5:
                    Console.WriteLine($"$700-799: {salary[i]}");
                    break;

                case 6:
                    Console.WriteLine($"$800-899: {salary[i]}");
                    break;

                case 7:
                    Console.WriteLine($"$900-999: {salary[i]}");
                    break;

                case 8:
                    Console.WriteLine($"$1000 and above: {salary[i]}");
                    break;
                default:
                    Console.WriteLine("invalid");
            }
        }
        Console.WriteLine();
        }
    }
}
