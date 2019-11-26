using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodutoo03
{
    class Ülesanne1
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[4];
            Console.WriteLine("Enter the first array elements");
            for (int i = 0; i < 4; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            int[] array2 = new int[4];
            Console.WriteLine("Enter the second array elements");
            for (int i = 0; i < 4; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");

            int[] array3 = CompareArrays(array1, array2);
            PrintArray(array3);
            Console.WriteLine("");

            Console.WriteLine("End Loop");
            Console.ReadKey();
        }

        static int[] CompareArrays(int[] array1, int[] array2)
        {
            int[] compare = new int[4];
            for (int i = 0; i < 4; i++)
            {
                if (array1[i] > array2[i])
                {
                    compare[i] = 1;
                }
                else if (array1[i] == array2[i])
                {
                    compare[i] = 0;
                }
                else
                {
                    compare[i] = -1;
                }
            }
            return compare;
        }

        public static void PrintArray(int[] array3)
        {
            Console.Write("[");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i]);
                if (i < (array3.Length - 1))
                    Console.Write(", ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }

    class Ülesanne2
    {
        public static void Main11(string[] args)
        {
            int i, j;
            int[,] arr1 = new int[3, 3];

            Console.Write("Enter elements in the matrix :\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");

            int difference = DiagonalDifference(arr1);
            Console.WriteLine("Absolute difference between matrix diagonal values is: " + difference);

            Console.Write("\n\n");
            Console.WriteLine("End Loop");
            Console.ReadKey();
        }

        static int DiagonalDifference(int[,] arr1)
        {
            int n = 3;
            int difference;
            int d1 = 0, d2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        d1 += arr1[i, j];

                    if (i == n - j - 1)
                        d2 += arr1[i, j];
                }
            }
            return difference = Math.Abs(d1 - d2);
        }
    }

    class Ülesanne3
    {
        public static void Main3(string[] args)
        {
            int n;
            Console.Write("Enter the size of staircase -> ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Staircase(n);

            Console.Write("\n");
            Console.WriteLine("End Loop");
            Console.ReadKey();
        }

        static void Staircase(int n)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= n - 1 - j)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }

    class Ülesanne4
    {
        static void Main4(string[] args)
        {
            int[] array = new int[6];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < 6; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");

            PlusMinus(array);

            Console.WriteLine("");
            Console.WriteLine("End Loop");
            Console.ReadKey();
        }

        static void PlusMinus(int[] array)
        {
            int positive = 0, negative = 0, zero = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    ++positive;
                }
                else if (array[i] == 0)
                {
                    ++zero;
                }
                else
                {
                    ++negative;
                }
            }
            Console.WriteLine("Positive: " + Math.Round((double)positive/ array.Length, 2));
            Console.WriteLine("Negative: " + Math.Round((double)negative / array.Length, 2));
            Console.WriteLine("Zero: " + Math.Round((double)zero / array.Length, 2));
        }
    }
}
