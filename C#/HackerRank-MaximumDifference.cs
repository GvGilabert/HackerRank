//The absolute difference between two integers, a and b, is written as |a-b|. The maximum absolute difference between two integers in a set of positive integers, elements, is the largest absolute difference between any two integers in elements.
//
//The Difference class is started for you in the editor. It has a private integer array (elements) for storing N non-negative integers, and a public integer (maximumDifference) for storing the maximum absolute difference.
//
//Task 
//Complete the Difference class by writing the following:
//
//	- A class constructor that takes an array of integers as a parameter and saves it to the elements instance variable.
//	- A computeDifference method that finds the maximum absolute difference between any 2 numbers in N and stores it in the maximumDifference instance variable.

using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

	public Difference(int[] _elements)
    {
        elements = _elements;
    }

    public void computeDifference()
    {
        Array.Sort(elements);
        Array.Reverse(elements);
        maximumDifference = elements[0]-elements[elements.Length-1];
    }
} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}