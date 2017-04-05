﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
   static class Sortable
    {
        /// <summary>
        /// Repeatedly compare neighbor pairs and swap if necessary.
        /// </summary>
        public static void BubbleSort()
        {
            int[] arr = new int[] { 2, 5, 6, 8, 8, 1, 4, 7, 9, 3 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])   //arr[i] < arr[j] to sort from large to small
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Repeatedly pick the smallest element to append to the result.
        /// </summary>
        public static void SelectionSort()
        {
            int[] arr = new int[] { 2, 5, 6, 8, 8, 1, 4, 7, 9, 3 };
            int pos_min = 0, temp;

            for (int i = 0; i < arr.Length; i++)
            {
                pos_min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    pos_min = arr[j] < arr[pos_min] ? j : pos_min;
                }

                if (pos_min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
