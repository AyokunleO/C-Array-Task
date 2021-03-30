using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of rows for the first matrix: ");
            int matRow1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns for the first matrix: ");
            int matCol1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of rows for the second matrix: ");
            int matRow2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns for the second matrix: ");
            int matCol2 = Convert.ToInt32(Console.ReadLine());

            int [,] mat1 = new int [matRow1, matCol1];
            int [,] mat2 = new int [matRow2, matCol2];

            // Taking Inputs
            Console.WriteLine("Enter the items in the first matrix: ");
            for (int i = 0; i < matRow1; i++)
            {
                for (int j = 0; j < matCol1; j++)
                {
                    Console.Write($"Enter the value for row{i+1} column {j+1}: ");
                    mat1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the items in the second matrix: ");
            for (int i = 0; i < matRow2; i++)
            {
                for (int j = 0; j < matCol2; j++)
                {
                    Console.Write($"Enter the value for row{i+1} column {j+1}: ");
                    mat2[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

        // Display Inputs
        Console.WriteLine("First Matrix: ");
         for (int i = 0; i < matRow1; i++) 
         {
            for (int j = 0; j < matCol1; j++) 
            {
               Console.Write(mat1[i, j] + " ");
            }
            Console.WriteLine();
         }
         Console.WriteLine("Second Matrix: ");
         for (int i = 0; i < matRow2; i++) 
         {
            for (int j = 0; j < matCol2; j++) 
            {
               Console.Write(mat2[i, j] + " ");
            }
            Console.WriteLine();
         }

         if(matCol1 != matRow2)
         {
             Console.WriteLine("Matrix multiplication cannot happen! Go over your Math lesson");
         } else {
            int [,] newMat = new int [matRow1, matCol2];
            for (int i = 0; i < matRow1; i++)
            {
                for (int j = 0; j < matCol2; j++)
                {
                    for (int k = 0; k < matCol1; k++)
                    {
                        newMat[i, j] += mat1[i, k] * mat2[k, j];
                    }
                }
            }
            Console.WriteLine("The product of the two matrices is :");
            for (int i = 0; i < matRow1; i++) {
               for (int j = 0; j < matCol1; j++) {
                  Console.Write(newMat[i, j] + "\t");
               }
               Console.WriteLine();
            }

         }
        }
    }
}
