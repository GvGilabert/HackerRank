//Task
//Given an array, a, of size n distinct elements, sort the array in ascending order using the Bubble Sort algorithm above.Once sorted, print the following 3 lines:

//1- Array is sorted in numSwaps swaps.
//Where numSwaps is the number of swaps that took place.
//2- First Element: firstElement.
//where firstElement is the first element in the sorted array.
//3- Last Element: lastElement
//where lastElement is the last element in the sorted array.

//Input Format

//The first line contains an integer, n, denoting the number of elements in array a.
//The second line contains n space-separated integers describing the respective values of a0,a1,...,an-1.

//Output Format

//Print the following three lines of output:
//1- Array is sorted in numSwaps swaps. 
//where numSwaps is the number of swaps that took place.
//2- First Element: firstElement
//where firstElement is the first element in the sorted array.
//Last Element: lastElement
//where lastElement is the last element in the sorted array.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    public static void swap(ref int a, ref int b)
    {
        int aux = a;
        a = b;
        b = aux;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        int numberOfSwaps = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    swap(ref a[j], ref a[j + 1]);
                    numberOfSwaps++;
                }
            }

            if (numberOfSwaps == 0)
            {
                break;
            }
        }

        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.\n" +
                          $"First Element: {a[0]}\n" +
                          $"Last Element: {a[a.Length - 1]}");

    }
}