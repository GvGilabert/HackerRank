//Task 
//The AdvancedArithmetic interface and the method declaration for the abstract divisorSum(n) method are provided for you in the editor below.
//
//Complete the implementation of Calculator class, which implements the AdvancedArithmetic interface. The implementation for the divisorSum(n) method must return the sum of all divisors of n.
//
//Input Format
//
//A single line containing an integer, n.
//
//Output Format
//
//You are not responsible for printing anything to stdout. The locked template code in the editor below will call your code and print the necessary output.

using System;
public interface AdvancedArithmetic{
    int divisorSum(int n);
}

public class Calculator : AdvancedArithmetic
{
 
    public int divisorSum(int n)
    {
        int result = 0;
        int divN = n;

        while(divN>0)
        {
            if(n%divN==0)
                result+= divN;
            divN--;
        }
        return result;
    }
}

class Solution{
    static void Main(string[] args){
        int n = Int32.Parse(Console.ReadLine());
      	AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
    }
}