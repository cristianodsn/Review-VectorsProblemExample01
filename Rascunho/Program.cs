using System;
using System.Globalization;

namespace Rascunho
{
    class Program
    {      
        static void Main(string[] args)
        {            
            Console.Write("Enter the quantity heitghts to calculate the average: ");
            int quantityHeight = int.Parse(Console.ReadLine());
            double[] heights = new double[quantityHeight];

            Console.WriteLine("Enter the heights measurements to calculate the average: ");
            for(int i = 0; i < quantityHeight; i++)
            {
                Console.Write($"#{i + 1}: ");
                heights[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);               
            }

            double average = 0.0;

            for (int i = 0; i< heights.Length; i++)
            {
                average += heights[i];
            }
            average /= quantityHeight; 
            Console.WriteLine();
            Console.WriteLine("Average height: " + average.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }      

    }
}
