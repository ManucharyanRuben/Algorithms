﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Algorithms
{
    class Arrays
    {
        #region JuggedArrayTask
        private static string a = "";

        public void ArrJugged()
        {

            try
            {

                Random rnd = new Random();
                Console.WriteLine("Insert Array Rows Count");
                int length = int.Parse(Console.ReadLine());
                char[][] arrJugged = new char[length][];
                for (int i = 0; i < arrJugged.Length; i++)
                {
                    Console.WriteLine($"Insert Array {i + 1} Row's Column Count");
                    arrJugged[i] = new char[int.Parse(Console.ReadLine())];
                }
                for (int i = 0; i < arrJugged.Length; i++)
                {
                    Console.WriteLine($"\nAdd random characters in array ({i + 1} line)\n");
                    for (int j = 0; j < arrJugged[i].Length; j++)
                    {
                        arrJugged[i][j] = (char)rnd.Next((int)'A', (int)'Z');
                        Console.Write(arrJugged[i][j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                string str = null;
                int sum = 0;
                int line = 1;
                Console.WriteLine("\nResult: ");
                for (int i = 0; i < arrJugged.Length; i++)
                {
                    Console.WriteLine($"\nLine {line++}");
                    for (int j = 0; j < arrJugged[i].Length; j++)
                    {
                        foreach (var item in arrJugged[i])
                        {
                            str += item;
                            sum = arrJugged[i][j] == item ? sum + 1 : sum;
                        }
                        if (Check(arrJugged[i][j]))
                        {
                            Console.Write($"{arrJugged[i][j]} - {sum} | ");
                        }
                        sum = 0;
                    }
                    a = "";
                    Console.WriteLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("\nTry Again !!!\n");
                ArrJugged();
            }
        }

        protected bool Check(char value)
        {
            foreach (var item in a)
            {
                if (value == item)
                {
                    return false;
                }
            }
            a += value;
            return true;
        }
        #endregion

        /// <summary>
        /// Finds duplicates from chars input.
        /// </summary>
        public void QuantityOfDuplicatesJugged()
        {
            Random rnd = new Random();
            int count = 0;
            Console.WriteLine("enter quantity of jugged array");
            int n = int.Parse(Console.ReadLine());
            char[][] arr = new char[n][];

            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine("add number of elements");
                int m = int.Parse(Console.ReadLine());
                arr[i] = new char[m];
                int j = 0;
                while (arr[i].Length > j)
                {
                    for (int k = 65; k <= 90; k++)
                    {
                        int result = rnd.Next(65, 91);

                        if (j < m)
                        {
                            arr[i][j] = (char)result;
                            Console.Write(arr[i][j]);
                            j++;
                            if (j == arr[i].Length)
                            {
                                char[] duplicates = new char[j];

                                for (int p = 0; p < arr[i].Length; p++)
                                {
                                    if (!duplicates.Contains(arr[i][p]))
                                    {
                                        int index = p;
                                        count = 1;
                                        int dIndex = 0;
                                        for (int l = ++index; l < arr[i].Length; l++)
                                        {
                                            if (arr[i][p] == arr[i][l])
                                            {
                                                count++;
                                                duplicates[dIndex++] = arr[i][l];

                                            }
                                        }
                                        Console.Write($"    {arr[i][p]} count: {count}");

                                    }
                                }

                            }
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        public void QuantityOfDuplicates()
        {
            char[] arr = new char[] { 'a', 'a', 'b', 'c', 'c', 'c', 'c', 'l', 'v', 'l', 'c' };
            char[] duplicates = new char[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (!duplicates.Contains(arr[i]))
                {
                    int index = i;
                    int count = 1;
                    int dIndex = 0;
                    for (int j = ++index; j < arr.Length; j++)
                    {

                        if (arr[i] == arr[j])
                        {
                            count++;
                            duplicates[dIndex++] = arr[j];
                        }
                    }
                    Console.WriteLine($"{arr[i]} count: {count}");
                }
            }
        }

        public void JuggedColors()
        {
            Console.WriteLine("enter first dimension");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second dimenstion");
            int m = int.Parse(Console.ReadLine());

            string[,] arr = new string[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Random rnd = new Random();
                    int result = rnd.Next(0, 16);
                    Thread.Sleep(1000);
                    Console.ForegroundColor = (ConsoleColor)result;
                    arr[i, j] = ((ConsoleColor)result).ToString();
                    Console.WriteLine(arr[i, j]);
                }
            }
        }

        /// <summary>
        /// prints a matrix of numbers
        /// </summary>
        public void MatrixOfNumbers()
        {
            Console.Write("dimension: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = i + 1; j <= num + i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void SpiralMatrix()
        {
            Console.Write("enter number of dimensions: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int rows = 0;
            int cols = 0;
            int step = 1;
            for (int nums = 1; nums <= matrix.Length; nums++)
            {
                matrix[rows, cols] = nums;

                if (step == 1)
                {
                    if (cols < n - 1 && matrix[rows, cols + 1] == 0)
                    {
                        cols++;

                    }
                    else
                    {
                        step = step >= 4 ? 1 : step + 1;
                    }
                }
                if (step == 2)
                {
                    if (rows < n - 1 && matrix[rows + 1, cols] == 0)
                    {
                        rows++;
                    }
                    else
                    {
                        step = step >= 4 ? 1 : step + 1;
                    }
                }
                if (step == 3)
                {
                    if (cols > 0 && matrix[rows, cols - 1] == 0)
                    {
                        cols--;
                    }
                    else
                    {
                        step = step >= 4 ? 1 : step + 1;
                    }
                }

                if (step == 4)
                {
                    if (matrix[rows - 1, cols] == 0 && rows > 0)
                    {
                        rows--;
                    }
                    else
                    {
                        step = step >= 4 ? 1 : step + 1;
                        if (nums != matrix.Length)
                        {
                            nums--;
                        }
                    }

                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        #region Alphabetical order
        public char[] AlphabeticalOrder()
        {
            Console.Write("count of chars: ");
            int count = int.Parse(Console.ReadLine());
            char[] chars = new char[count];
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write("add one character: ");
                chars[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = i + 1; j < chars.Length; j++)
                {
                    if (chars[i] > chars[j])
                    {
                        char temp = chars[j];
                        chars[j] = chars[i];
                        chars[i] = temp;

                    }
                }
            }

            string[] arr = new string[] { "please wait", "lucky guy", "patient", "wait just wait", "maybe coffee?" };
            Random rnd = new Random();

            for (int index = 0; index < arr.Length; index++)
            {
                int strIndex = rnd.Next(0, arr.Length);
                Console.Write(arr[strIndex]);
                Thread.Sleep(1500);
                ClearLastLine();

            }
            Console.WriteLine("ordering...");
            Thread.Sleep(3000);
            return chars;
        }
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        #endregion

        public void MaximalConsecutiveSequence()
        {
            int[] arr = new int[] { 1, 1, 1, 1, 1, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 1 };
            List<string> list = new List<string>() { };
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        i++;

                    }
                    else if (count >= 2)
                    {
                        list.Add($"{arr[i]} count: {count}");
                        count = 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            char[] s = { ' ' };
            string[] s1;
            int p = 0;
            List<int> maxCount = new List<int>() { };
            for (int i = 0; i < list.Count; i++)
            {
                s1 = list[i].Split(s, StringSplitOptions.RemoveEmptyEntries);

                int num = 0;
                bool parsed = int.TryParse(s1[2], out num);
                if (parsed == true)
                {
                    maxCount.Add(num);
                }
            }

            int maxValue = 0;
            int countValue = -1;
            for (int i = 0; i < maxCount.Count; i++)
            {
                if (maxValue < maxCount[i])
                {
                    maxValue = maxCount[i];
                    countValue++;
                }
            }

            Console.WriteLine(list[countValue]);
        }

        public void MaximalSequenceOfIncreasingIntegers()
        {
            int[] arr = new int[] { 3, 2, 3, 4, 5, 2, 1, 2, 3, 4, 5, 6, 7, 2, 4 };
            List<List<int>> jugged = new List<List<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                jugged.Add(new List<int>());
            }

            int juggedIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != 0)
                {
                    if (arr[i] == arr[i + 1] - 1 || arr[i] == arr[i - 1] + 1)
                    {
                        jugged[juggedIndex].Add(arr[i]);

                    }
                    else
                    {
                        juggedIndex++;
                    }
                    if (i == arr.Length - 2)
                    {
                        break;
                    }
                }
            }

            int maxLength = 0;
            int indexCount = -1;
            for (int i = 0; i < jugged.Count; i++)
            {
                if (jugged[i].Count > maxLength)
                {
                    maxLength = jugged[i].Count;
                    indexCount++;
                }
            }
            Console.Write($"Best elements");
            for (int j = 0; j < jugged[indexCount].Count; j++)
            {
                Console.Write($" {jugged[indexCount][j]}  ");
            }
            Console.Write($"count: {maxLength}");
        }

        /// <summary>
        /// finds the most frequently occurring element in an array.
        /// </summary>
        public void Duplicates()
        {
            int[] arr = new int[] { 1, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 9, 9, 9 };
            List<List<int>> duplicates = new List<List<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                duplicates.Add(new List<int>());
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            int dIndex = 0;
            int count = 1;
            int increaser = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 2)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        if (increaser == 0)
                        {
                            duplicates[dIndex].Add(arr[i]);
                            increaser++;
                        }
                        duplicates[dIndex].Add(arr[i + 1]);
                        increaser++;

                        count++;
                    }
                    else if (arr[i + 1] == arr[i + 2])
                    {
                        Console.WriteLine(count);
                        count = 1;
                        increaser = 0;
                        dIndex++;
                    }
                    else
                    {
                        dIndex++;
                        increaser = 0;
                        duplicates[dIndex].Add(arr[i + 1]);
                        increaser++;
                    }

                }
                else
                {
                    if (arr[i] == arr[i + 1])
                    {
                        if (increaser == 0)
                        {
                            duplicates[dIndex].Add(arr[i]);
                            increaser++;
                        }

                        duplicates[dIndex].Add(arr[i + 1]);
                        increaser++;
                        count++;
                        break;
                    }
                    else
                    {
                        increaser = 0;
                        duplicates[++dIndex].Add(arr[i + 1]);
                        increaser++;
                        break;
                    }
                }
            }
            int max = 0;
            int pos = 0;
            for (int i = duplicates.Count - 1; i >= 0; i--)
            {
                if (duplicates[i].Count == 0)
                {
                    duplicates.Remove(duplicates[i]);
                }
            }

            for (int i = 0; i < duplicates[dIndex].Count; i++)
            {
                if (duplicates[i].Count > max)
                {
                    max = duplicates[i].Count;
                    pos = i;
                }
            }
            Console.Write($"Best ");
            for (int i = 0; i < duplicates[pos].Count; i++)
            {
                Console.Write($"{duplicates[pos][i]} ");
            }
            Console.Write($"count: {max}");
        }

        public void SquareMatrix()
        {
            Console.Write("enter dimension count: ");
            int dimension = int.Parse(Console.ReadLine());
            int[,] arr = new int[dimension, dimension];

            int temp = 1;
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                for (int j = i; j <= (dimension - 1) * (dimension - 1); j += dimension - 1)
                {
                    Console.Write($"{j}  ");
                    temp = j;
                }
                Console.WriteLine();
            }
        }

        public void SquareMatrix2()
        {
            Console.Write("enter dimension count: ");
            int dimension = int.Parse(Console.ReadLine());
            int[,] matrix = new int[dimension, dimension];

            int rows = 0;
            int cols = 0;
            int move = 1;
            for (int i = 1; i <= matrix.Length; i++)
            {
                if (move == 1)
                {
                    if (rows < dimension - 1)
                    {
                        matrix[rows, cols] = i;
                        rows++;
                    }
                    else
                    {
                        move = move >= 4 ? 1 : move + 1;
                    }
                }
                if (move == 2)
                {
                    matrix[rows, cols] = i;
                    cols++;
                    if (i != matrix.Length)
                    {
                        move = move >= 4 ? 1 : move + 1;
                        i++;
                    }
                }
                if (move == 3)
                {
                    if (rows > 0)
                    {
                        matrix[rows, cols] = i;
                        rows--;
                    }
                    else
                    {
                        move = move >= 4 ? 1 : move + 1;
                    }
                }

                if (move == 4)
                {
                    matrix[rows, cols] = i;
                    cols++;
                    move = move >= 4 ? 1 : move + 1;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}   ");
                }
                Console.WriteLine();
            }
        }

        public void SquareMatrix3()
        {
            Console.Write("enter dimension count: ");
            int dimension = int.Parse(Console.ReadLine());
            int[,] matrix = new int[dimension, dimension];

            int rows = dimension - 1;
            int cols = 0;
            int count = 1;
            bool accepted = false;
            int counter = 2;
            for (int i = 1; i <= matrix.Length; i++)
            {
                if (rows == dimension - 1)
                {
                    if (rows <= dimension - 1 && cols <= dimension - 1)
                    {
                        matrix[rows, cols] = i;
                    }
                    if (count >= dimension)
                    {
                        rows = 0;
                        cols = 1;
                        accepted = true;
                    }
                    else if (accepted)
                    {
                        rows = 0;
                        cols = count++;
                        matrix[rows, cols] = i;
                        cols++;
                    }
                    else
                    {
                        rows -= count++;
                        cols = 0;
                    }
                }
                else if (cols == dimension - 1 && accepted)
                {
                    matrix[rows, cols] = i;
                    rows = 0;
                    cols = counter++;
                }
                else
                {
                    matrix[rows, cols] = i;
                    cols++;
                    rows++;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public void SquareMatrix4()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("enter dimension count: ");
            int dimension = int.Parse(Console.ReadLine());
            int[,] matrix = new int[dimension, dimension];

            string move = "down";
            int rows = 0;
            int cols = 0;
            int counter = dimension - 1;

            for (int i = 1; i <= matrix.Length; i++)
            {
                if (move == "down")
                {
                    if (rows < dimension - 1 && matrix[rows + 1, cols] == 0)
                    {
                        matrix[rows, cols] = i;
                        rows++;
                    }
                    else
                    {
                        matrix[rows, cols] = i++;
                        if (i >= matrix.Length)
                        {
                            break;
                        }
                        move = "right";
                        cols++;

                    }
                }
                if (move == "right")
                {
                    if (cols < dimension - 1 && matrix[rows, cols + 1] == 0)
                    {
                        matrix[rows, cols] = i;
                        cols++;

                    }
                    else
                    {
                        matrix[rows, cols] = i++;
                        move = "up";
                        rows--;

                    }
                }
                if (move == "up")
                {
                    if (rows > 0 && matrix[rows - 1, cols] == 0)
                    {
                        matrix[rows, cols] = i;
                        rows--;
                    }
                    else
                    {
                        move = "left";
                    }
                }
                if (move == "left")
                {
                    if (cols > 0 && matrix[rows, cols - 1] == 0)
                    {
                        matrix[rows, cols] = i;
                        cols--;
                    }
                    else
                    {
                        matrix[rows, cols] = i;
                        rows++;
                        move = "down";
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
