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
                Recursion(arr, ++position, element, new List<int>() { element });
            }

            lists.Sort((ICollection<int> l1, ICollection<int> l2) =>
            {
                if (l1.Count > l2.Count)
                {
                    return -1;
                }
                else
                {
                    if (l1.Count < l2.Count)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            );

            int index = 0;

            foreach (List<int> list in lists)
            {
                foreach (int number in list)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();

                if (index++ == 1)
                { break; }
            }
        }

        static int maxCount = 0;
        static List<ICollection<int>> lists = new List<ICollection<int>>();

        static void Recursion(int[] arr, int pos, int prevElement, ICollection<int> sequence)
        {
            if (pos == arr.Length)
            {
                EndSequence(sequence);
                return;
            }

            for (int i = pos; i < arr.Length; i++)
            {
                if (prevElement < arr[i])
                {
                    List<int> newSequence = new List<int>();
                    newSequence.AddRange(sequence);
                    newSequence.Add(arr[i]);
                    Recursion(arr, i + 1, arr[i], newSequence);
                }
            }

            EndSequence(sequence);
        }

        static void EndSequence(ICollection<int> sequence)
        {
            //Console.WriteLine();

            //foreach (int element in sequence)
            //{
            //    Console.Write("{0} ", element);
            //}

            if (sequence.Count > maxCount)
            {
                lists.Add(sequence);
            }

            //Console.WriteLine(" count: {0}", sequence.Count);
        }
    }
}
