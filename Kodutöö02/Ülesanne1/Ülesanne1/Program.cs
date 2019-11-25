using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne1

//Write the method that finds the minimum value of the array of integers.
//Inputs:     
//Array of integers.Example: [2, 75, 3, 15]
//Example output:      
    //Min number in array: 2

{
    class Program
    {
        static void Main()
        {
            int[] arr1 = new int[] { 23, 5, 1 }; //siin on 2 massiivi, mis lõime ise. tahame kirjutada uue massiivi, mis võtab arvesse eelmisi kahte massiive.
            int[] arr2 = new int[] { 345, 67 };

            int[] arr3 = Concat(arr1, arr2);
            PrintArrayf(arr3);

            Console.WriteLine("");
            Console.ReadKey();

        }

        static int[] Concat(int[] arr1, int[] arr2)
        {
            int[] con = new int[arr1.Length + arr2.Length];
            int conIndex = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                con[conIndex] = arr1[i];
                conIndex++;
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                con[conIndex] = arr2[i];
                conIndex++;
            }
            return con;
        }

        static int Sumf(int[] arr)
        {

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }


        static void SwapFirstAndLastf(int[] arr)
        {
            int first = arr[0];
            int last = arr[arr.Length - 1];

            arr[0] = last;
            arr[arr.Length - 1] = first;
        }

        static bool IsInArrayf(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return true;
                }

            }

            return false;
        }

        public static void PrintArrayf(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < (arr.Length - 1))
                    Console.Write(", ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
