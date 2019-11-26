using System;
using System.IO;

namespace Kodutoo04
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearofbirth = 1987;
            int iterations = 0;
            while (true)
            {
                int sum = RandomArray();
                
                if (sum == yearofbirth)
                {
                    Console.WriteLine("Sum of border values is equal to my birth year.");
                    break;
                }
                if (sum != yearofbirth)
                {
                    Console.WriteLine("Sum of border values is NOT equal to my birth year.");
                }
                iterations++;
            }
            Console.WriteLine("It tooks {0} iterations.", iterations);
            Console.ReadKey();
        }

        static int RandomArray()
        {
            Random ran = new Random();
            int[,] arr = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = ran.Next(0, 400);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            int sum = BorderValues(arr);
            Console.WriteLine("Sum of boundary elements is " + sum + ".");
            return sum;
        }

        static int BorderValues(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0)
                        sum += arr[i, j];
                    else if (i == 4 - 1)
                        sum += arr[i, j];
                    else if (j == 0)
                        sum += arr[i, j];
                    else if (j == 4 - 1)
                        sum += arr[i, j];
                }
            }
            return sum;
        }
    }
}
