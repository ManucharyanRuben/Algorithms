﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class ListSeries
    {
        /// <summary>
        /// check whether an element occurs in a list.
        /// </summary>
        public void CheckElement()
        {
            while (true)
            {
                List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int key = int.Parse(Console.ReadLine());

                int i = 0;
                while (i < list.Count)
                {
                    if (key == list[i])
                    {
                        Console.WriteLine(true.ToString());
                        break;
                    }
                    i++;
                }


                if (i == list.Count)
                {
                    Console.WriteLine(false.ToString());
                }
            }
        }

        /// <summary>
        /// Rotate a list by k elements
        /// </summary>
        public void RotateElements()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            int key = int.Parse(Console.ReadLine());

            for (int i = 0; i < key; i++)
            {
                list.Add(list[key - i - 1]);
                list.RemoveAt(key - i - 1);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void ConvertableList()
        {
            List<string> list = new List<string>() { "b1", "b2", "1b3", "1b23" };

            for (int i = 0; i < list.Count; i++)
            {
                string key = "";
                char[] arr = new char[list[i].Length];

                for (int j = 0; j < list[i].Length; j++)
                {
                    int number;
                    string str = (list[i])[j].ToString();
                    arr[j] = ((list[i])[j]);

                    bool flag = int.TryParse((list[i])[j].ToString(), out number);
                    if (flag == true)
                    {
                        key += number.ToString();
                        if ((list[i])[j] == arr[arr.Length - 1])
                        {
                            Console.WriteLine(Convert.ToInt32(key));
                        }
                    }
                }
            }
        }

        public void RectangularFrame()
        {
            List<string> list = new List<string>() { "Hello", "World", "in", "aghffgfgfgbcdefghi", "a", "frame" };

            int length = 0;
            int rowIndex = 0;
            foreach (var item in list)
            {
                length = item.Length > length ? item.Length : length;
            }

            for (int i = 0; i <= list.Count + 1; i++)
            {
                int columnIndex = 0;
                int space = length - list[rowIndex].Length;
                int frontSpace = space / 2;
                int endSpace = space % 2 == 0 ? frontSpace : frontSpace + 1;
                int word = list[rowIndex].Length;
                for (int j = 0; j <= length + 1; j++)
                {
                    if (i == 0 || i == list.Count + 1 || j == 0 || j == length + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (frontSpace-- > 0)
                        {
                            Console.Write(" ");
                        }
                        else if (word-- > 0)
                        {
                            Console.Write((list[rowIndex])[columnIndex++]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
                rowIndex = rowIndex < list.Count - 1 && i != 0 ? rowIndex + 1 : rowIndex;
            }
        }

        /// <summary>
        /// English is translated to Pig Latin by taking the first letter of every word, moving it to the end of the word and adding ‘ay’.
        /// <para>Pig Latin is a language game in which words in English are altered.</para>
        /// </summary>
        public void PigLatin()
        {
            List<string> list = new List<string>() { "smile", "pig", "latin", "eat", "happy", "duck", "too" };

            for (int i = 0; i < list.Count; i++)
            {
                bool flag = true;

                List<char> listChar = new List<char>() { };
                foreach (var item in list[i])
                {
                    listChar.Add(item);
                }
                for (int k = 0; k < listChar.Count; k++)
                {
                    if ((listChar[k] == 'a' && flag == true) || (listChar[k] == 'e' && flag == true) || (listChar[k] == 'i' && flag == true) || (listChar[k] == 'o' && flag == true) || (listChar[k] == 'u' && flag == true) || (listChar[k] == 'y' && flag == true))
                    {
                        if (k == 0)
                        {
                            Console.WriteLine($"{list[i]}way");
                            break;
                        }
                        else
                        {
                            int index = 0;
                            while (index < k)
                            {
                                listChar.Add(listChar[0]);
                                listChar.RemoveAt(0);
                                index++;

                            }
                            flag = false;
                        }
                    }

                    if (k == listChar.Count - 1)
                    {
                        for (int j = 0; j < listChar.Count; j++)
                        {
                            if (j == listChar.Count - 1)
                            {
                                Console.Write($"{listChar[j]}ay");
                            }
                            else
                            {
                                Console.Write(listChar[j]);
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
