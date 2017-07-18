using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgo
{
    public class ReverseAnArray
    {
        static void Mains()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Normal Array is: ");
            PrintArray(arr, arr.Length);

            // Iterative Way
            // ReverseArray(arr, 0, arr.Length - 1);

            // Recursive Way
            ReverseArrayRecursive(arr, 0, arr.Length - 1);

            Console.WriteLine("Reversed Array is: ");
            PrintArray(arr, arr.Length);

            Console.ReadLine();

        }

        static void PrintArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0}", arr[i]);
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Iterative Way of Reversing an Array. Time Complexity is O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        static void ReverseArray(int[] arr, int start, int end)
        {
            
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;

            }
        }


        static void ReverseArrayRecursive(int[] arr, int start, int end)
        {
            int temp;
            if (start >= end)
            {
                return;
            }
            temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            ReverseArrayRecursive(arr, start + 1, end - 1);

        }

    }
}
