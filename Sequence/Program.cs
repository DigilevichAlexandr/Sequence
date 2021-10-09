using System;
using System.Collections.Generic;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 5, 6, 8, 7 };

            foreach (int number in arr)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            List<List<int>> lists = new List<List<int>>();
            List<int> beginList = new List<int>();
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    List<int> tempList = new List<int>();
                    tempList.Add(arr[i]);

                    for (int y = j; y < arr.Length; y++)
                    {
                        if (arr[y] > tempList[tempList.Count - 1])
                        {
                            tempList.Add(arr[y]);
                        }
                    }

                    max = tempList.Count;
                    lists.Add(tempList);
                }
            }

            lists.Sort((List<int> l1, List<int> l2) =>
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
    }
}
