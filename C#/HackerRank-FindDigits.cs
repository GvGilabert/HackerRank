//An integer d is a divisor of an integer n if the remainder of n / d = 0.

//Given an integer, for each digit that makes up the integer determine whether it is a divisor.Count the number of divisors occurring within the integer.

//Note: Each digit is considered to be unique, so each occurrence of the same digit should be counted (e.g. for n = 111, 1 is a divisor of 111 each time it occurs so the answer is 3).

//Function Description
//Complete the findDigits function in the editor below.It should return an integer representing the number of digits of d that are divisors of d.

//findDigits has the following parameter(s):
//n: an integer to analyze

//Input Format
//The first line is an integer, t, indicating the number of test cases. 
//The t subsequent lines each contain an integer, n.

//Output Format
//For every test case, count the number of digits in n that are divisors of n. Print each answer on a new line.

class Solution
{

    static int findDigits(int n)
    {
        int result = 0;
        foreach (char val in n.ToString())
        {
            if (n % Char.GetNumericValue(val) == 0)
                result++;
        }
        return result;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = findDigits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}