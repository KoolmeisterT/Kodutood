using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodutoo02
{
    class Ülesanne1
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < 4; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = array[0];
            for (int i = 0; i < 4; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("The minimum value of the array is {0}", min);
            Console.Read();
        }
    }

    class Ülesanne2
    {
        static void Main2(string[] args)
        {
            int[] array = new int[4];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < 4; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Integer value to search in array.");
            int element = Convert.ToInt32(Console.ReadLine());
            bool elementInArray = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (element == array[i])
                {
                    Console.WriteLine("The index of {0} in array is {1}.", element, i);
                    elementInArray = true;
                }
            }
            if (!elementInArray)
            {
                Console.WriteLine("Element is not in array");
            }
            Console.Read();
        }
    }

    class Ülesanne3
    {
        static void Main2(string[] args)
        {
            double[] array = new double[4];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < 4; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;
            Console.WriteLine("Average value in array: " + average);
            Console.Read();
        }
    }
}
