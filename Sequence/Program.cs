using System;
using System.Collections.Generic;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 5, 6, 8, 7 };
            int position = 0;

            foreach (int element in arr)
            {
                Recursion(arr, ++position, 0, element, new List<int>() { element });
            }
        }

        static int maxLevel = 1;
        static List<int> list = new List<int>();

        static void Recursion(int[] arr, int pos, int level, int prevElement, IEnumerable<int> sequence)
        {
            if (pos == arr.Length)
            {
                Console.WriteLine();

                foreach (int element in sequence)
                {
                    Console.Write("{0} ", element);
                }

                Console.WriteLine(" level: {0}", level);
                return;
            }

            for (int i = pos; i < arr.Length; i++)
            {
                if (prevElement < arr[i])
                {
                    List<int> newSequence = new List<int>();
                    newSequence.AddRange(sequence);
                    newSequence.Add(arr[i]);
                    Recursion(arr, i + 1, level + 1, arr[i], newSequence);
                }
            }

            Console.WriteLine();

            foreach (int element in sequence)
            {
                Console.Write("{0} ", element);
            }

            Console.WriteLine(" level: {0}", level);
        }
    }
}
