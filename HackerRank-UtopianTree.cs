//The Utopian Tree goes through 2 cycles of growth every year. Each spring, it doubles in height. Each summer, its height increases by 1 meter.
//
//Laura plants a Utopian Tree sapling with a height of 1 meter at the onset of spring. How tall will her tree be after n growth cycles?
//
//For example, if the number of growth cycles is n = 5 , the calculations are as follows:
//
//Period  Height
//0          1
//1          2
//2          3
//3          6
//4          7
//5          14
//
//Function Description
//
//Complete the utopianTree function in the editor below. It should return the integer height of the tree after the input number of growth cycles.
//
//UtopianTree has the following parameter(s):
//
//n: an integer, the number of growth cycles to simulate
//
//Input Format
//
//The first line contains an integer, t, the number of test cases. 
//t subsequent lines each contain an integer, n, denoting the number of cycles for that test case.
// 
//Output Format
//
//For each test case, print the height of the Utopian Tree after n cycles. Each height must be printed on a new line.
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

class Solution {

    // Complete the utopianTree function below.
    static int utopianTree(int n) 
    {
        int result = 0;
        
	for(int i=0; i<=n; i++)
        {
            if(i%2==0)
                result++;
            else
                result*=2;
        }
        
	return result;
    }

    static void Main(string[] args) {

        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) 
	{
            int n = Convert.ToInt32(Console.ReadLine());
            int result = utopianTree(n);
            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
