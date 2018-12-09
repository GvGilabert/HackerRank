//PROBLEM
//Given a 6x6 2D Array, A:

//1 1 1 0 0 0
//0 1 0 0 0 0
//1 1 1 0 0 0
//0 0 0 0 0 0
//0 0 0 0 0 0
//0 0 0 0 0 0

//We define an hourglass in A to be a subset of values with indices falling in this pattern in A's graphical representation:

//a b c
//  d
//e f g

//There are 16 hourglasses in A, and an hourglass sum is the sum of an hourglass' values.

//Task
//Calculate the hourglass sum for every hourglass in A, then print the maximum hourglass sum.

//Input Format

//There are 6 lines of input, where each line contains 6 space-separated integers describing 2D Array A; every value in A will be in the inclusive range of -9 to 9.

//Output Format

//Print the largest (maximum) hourglass sum found in A.

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution 
{

    static void Main(string[] args) {
        int[][] arr = new int[6][];
        int maxSum =0;

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
            for (int i = 0; i < arr.Length-2; i++)
            {
                for (int j = 0; j < arr[i].Length-2; j++)
                {
                    int hourglass = 
                        arr[i][j]+arr[i][j+1]+arr[i][j+2]+
                        arr[i+1][j+1]+
                        arr[i+2][j]+arr[i+2][j+1]+arr[i+2][j+2];
                    if(i==0&&j==0)
                        maxSum=hourglass;
                    else if(hourglass>maxSum)
                        maxSum=hourglass; 
                }
            }
            Console.WriteLine(maxSum);
	}
}