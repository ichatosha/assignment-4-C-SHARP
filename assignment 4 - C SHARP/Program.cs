using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace Assignment4
{
    class program
    {
        static void Main(string[] args)
        {
            #region Q 1 
            /* 1 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            Example
            Input: 5
            Output: 1 2 3 4 5
            */
            static void PrintNumbers(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region Q 2

            /*
            2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            Example
            Input: 5
            Outputs: 5 10 15 20 25 30 35 40 45 50 55 60
            */
            static void PrintMultiplicationTable(int n)
            {
                for (int i = 1; i <= 12; i++)
                {
                    Console.Write(n * i + " ");
                }
                Console.WriteLine();
            }

            #endregion

            #region Q 3
            static void PrintEvenNumbers(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
            #endregion

            #region Q 4
            static void CalculatePower(int baseNum, int exponent)
            {
                int result = 1;
                for (int i = 0; i < exponent; i++)
                {
                    result *= baseNum;
                }
                Console.WriteLine(result);
            }
            #endregion

            #region Q 5
            static void PrintReverseString(string input)
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(new string(charArray));
            }
            #endregion

            #region Q 6
            static void FindPrimeNumbers(int start, int end)
            {
                for (int i = start; i <= end; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }

            // to print number 2 only :
            static bool IsPrime(int number)
            {
                if (number <= 1) return false;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0) return false;
                }
                return true;  
            }

            #endregion

            #region Q 7
            static void DecimalToBinary(int number)
            {
                if (number == 0)
                {
                    Console.WriteLine(0);
                    return;
                }

                string binary = "";
                while (number > 0)
                {
                    binary = (number % 2) + binary;
                    number /= 2;
                }
                Console.WriteLine(binary);
            }
            #endregion

            #region Q 8
            static void PrintIdentityMatrix(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.Write("1 ");
                        }
                        else
                        {
                            Console.Write("0 ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            #endregion

            #region Q 9
            /*
            9- Write C# program that Extract a substring from a given string.
            */
            static void ExtractSubstring(string input, int start, int length)
            {
                if (start >= 0 && start + length <= input.Length)
                {
                    Console.WriteLine(input.Substring(start, length));
                }
                else
                {
                    Console.WriteLine("Invalid start index or length.");
                }
            }
            #endregion

            #region Q 10
            /*
            10- Write C# program that take two string variables and print them as one variable.
            */
            static void ConcatenateStrings(string str1, string str2)
            {
                Console.WriteLine(str1 + str2);
            }
            #endregion

            #region Q 11
            /*
            11- Write a program that prints an identity matrix using 
            for loop in other words takes a value n from the user 
            and shows the identity table of size n * n.
            */
            
            static void PrintIdentityMatrix01(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.Write("1 ");
                        }
                        else
                        {
                            Console.Write("0 ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            #endregion

            #region Q 12
            /*
            12- Write a program in C# Sharp to find the sum of all elements of the array.
            */
            static void SumArrayElements(int[] array)
            {
                int sum = 0;
                foreach (int num in array)
                {
                    sum += num;
                }
                Console.WriteLine(sum);
            }
            #endregion

            #region Q 13
            /*
            13- Write a program in C# Sharp to merge two arrays of the same size 
            sorted in ascending order.
            */
            static void MergeAndSortArrays(int[] array1, int[] array2)
            {
                int[] mergedArray = new int[array1.Length + array2.Length];
                // start from zero index :
                array1.CopyTo(mergedArray, 0);
                // start after the last index of array1 = array1.length
                array2.CopyTo(mergedArray, array1.Length);   
                Array.Sort(mergedArray);
                Console.WriteLine(string.Join(" ", mergedArray));
            }
            #endregion

            #region Q 14
            /*
            14- Write a program in C# Sharp to count the frequency of each element of an array.
            */
            static void CountElementFrequency(int[] array)
            {
                // dict have values 
                var frequency = new Dictionary<int, int>();
                foreach (int num in array)
                {
                    // count :
                    if (frequency.ContainsKey(num))
                    {
                        frequency[num]++;
                    }
                    // if not repeated 
                    else
                    {
                        frequency[num] = 1;
                    }
                }

                // key value pair
                foreach (var kvp in frequency)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
            #endregion

            #region Q 15
            /*
            15- Write a program in C# Sharp to find maximum and minimum element in an array.
            */
            static void FindMaxAndMin(int[] array)
            {
                int max = array.Max();
                int min = array.Min();
                Console.WriteLine($"Max: {max}, Min: {min}");
            }
            #endregion

            #region Q 16
            /*
            16- Write a program in C# Sharp to find the second largest element in an array.
            */
            static void FindSecondLargest(int[] array)
            {
                if (array.Length < 2)
                {
                    Console.WriteLine("Array must contain at least two elements.");
                    return;
                }

                Array.Sort(array);
                int largest = array[array.Length - 1];

                for (int i = array.Length - 2; i >= 0; i--)
                {
                    if (array[i] != largest)
                    {
                        Console.WriteLine($"The second largest element is: {array[i]}");
                        return;
                    }
                }

                Console.WriteLine("There is no second largest element.");
            }
            #endregion

            #region Q 17
            /*
            17- Consider an Array of Integer values with size N having values as in this Example:
             7 0 0 0 5 6 7 5 0 7 5 3
            write a program find the longest distance between Two equal cells. 
            In this example, the distance is measured by the number of cells.
            */
            static void FindLongestDistance(int[] array)
            {
                var indexMap = new Dictionary<int, int>();
                int maxDistance = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (indexMap.ContainsKey(array[i]))
                    {
                        int distance = i - indexMap[array[i]];
                        if (distance > maxDistance)
                        {
                            maxDistance = distance;
                        }
                    }
                    else
                    {
                        indexMap[array[i]] = i;
                    }
                }

                Console.WriteLine(maxDistance);
            }
            #endregion


            #region Q 18
            /*
            18- Write a program to create two multidimensional arrays of same size. 
            Accept value from user and store them in first array. 
            Now copy all the elements of first array on second array and print second array.
            */
            static void CopyMultidimensionalArray(int[,] array)
            {
                int rows = array.GetLength(0);
                int cols = array.GetLength(1);
                int[,] copiedArray = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        copiedArray[i, j] = array[i, j];
                    }
                }

                // Print copied array
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(copiedArray[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            #endregion
        }
    }
}