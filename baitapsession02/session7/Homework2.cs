using System;
using System.Collections.Generic;
using System.Text;

namespace session7
{
    internal class Homework2
{
        static int[,] CreateDimensionalArray(int n, int m)
        {
            int[,] dimensions = new int[n, m];
            Random rnd = new Random();
            for(int i = 0; i < n; i++) 
                for (int j = 0; j < m; j++)
                    dimensions[i, j] = rnd.Next(0,100);
            return dimensions;
        }
        static void Print (int[,] dimensions)
        {
            for (int i = 0;i < dimensions.GetLength(0); i++)
            {
                for(int j= 0; j < dimensions.GetLength(1);j++)
                    Console.Write(dimensions[i,j] + " ");
                Console.WriteLine();
            }
        }
        static void PrintColAndRow(int[,] dimensions,int i)
        {
            Console.WriteLine($"{i} column");
            for(int j = 0; j <dimensions.GetLength(0);j++)
                Console.WriteLine(dimensions[j,i-1]);
            Console.WriteLine($"{i} row");
            for (int j =0; j < dimensions.GetLength(1); j++)
                Console.Write(dimensions[i-1,j] + " ");
        }
        static int Maxium(int[,] dimensions)
        {
            int max = dimensions[0, 0];
            for(int i = 0; i < dimensions.GetLength(0);i++)
                for(int j = 0; j < dimensions.GetLength(1);j++)
                {
                    if (dimensions[i, j] > max)
                        max = dimensions[i, j];
                }  
            return max;
        }
        static int[] Minium (int[,] dimensions,int i)
        {
            int[] min = { dimensions[0, 0], dimensions[0, 0] };
            for (int j = 0;j < dimensions.GetLength(0);j++)
            {
                if (dimensions[j,i-1] < min[0])
                    min[0] = dimensions[j,i-1];
            }   
            for (int j = 0; j < dimensions.GetLength(1);j++)
            {
                if (dimensions[i - 1, j] < min[1])
                    min[1] = dimensions[i - 1, j];
            } 
            return min;
        }
        static int[,] Transpose(int[,] dimensions)
        {
            int[,] transpose = new int[dimensions.GetLength(1), dimensions.GetLength(0)];
            for (int i = 0; i < dimensions.GetLength(0); i++)
                for (int j = 0; j < dimensions.GetLength(1); j++)
                {
                    transpose[j,i] = dimensions[i,j];
                }
            return transpose;
        }
        static int[,] PrintDiagonal (int[,] dimensions)
        {
            int[,] result = new int[2, dimensions.GetLength(1)];
            for (int i = 0; i < dimensions.GetLength(0); i++)
                result[0, i] = dimensions[i, i];
            for (int i = 0; i < dimensions.GetLength(1); i++)
                result[1, i] =  dimensions[dimensions.GetLength(0) -i-1,i];
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n row and m col for dimensional array");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            
            //Create dimensions array with random value 1->100
            int[,] arr = CreateDimensionalArray(n,m);

            //Print this demension arrays
            Print(arr);

            //print ith column and row
            Console.WriteLine("Enter i-th column and row to print");
            int i = int.Parse(Console.ReadLine());
            PrintColAndRow(arr, i);
            Console.WriteLine();
            Console.WriteLine();

            //Print maxium value 
            Console.WriteLine(Maxium(arr));
            Console.WriteLine();

            //Print min value of row/col of the matrix
            int[] min = Minium(arr, i);
            Console.WriteLine($"Minum of {i} col and row is {min[0]} and {min[1]} respectively");
            Console.WriteLine();

            //Transpose matrixintint
            int[,] transpose = Transpose(arr);
            Print(transpose);

            //Print main/sencondary diagonal
            Console.WriteLine("enter square arr");
            int a = int.Parse(Console.ReadLine());
            int[,] square = CreateDimensionalArray(a, a);
            Print(square);
            Console.WriteLine();
            int[,] diagonal = PrintDiagonal(square);
            Print(diagonal);
            Console.WriteLine();

            
        }
}
}
