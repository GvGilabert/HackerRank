//Lilah has a string, s, of lowercase English letters that she repeated infinitely many times.
//Given an integer, n, find and print the number of letter a's in the first n letters of Lilah's infinite string.

//For example, if the string s= 'abcac' and n=10, the substring we consider is abcacabcac, the first 10 characters of her infinite string. There are 4 occurrences of a in the substring.

//Function Description
//Complete the repeatedString function in the editor below.It should return an integer representing the number of occurrences of a in the prefix of length n in the infinitely repeating string.

//repeatedString has the following parameter(s):
//s: a string to repeat
//n: the number of characters to consider

//Input Format
//The first line contains a single string, s. 
//The second line contains an integer, n.

//Output Format
//Print a single integer denoting the number of letter a's in the first n letters of the infinite string created by repeating s infinitely many times.

class Solution
{

    static long repeatedString(string s, long n)
    {
        long result = s.Count(a => a == 'a');
        if (n % s.Count() == 0)
            return result * (n / s.Count());
        else
        {
            int r = 0;
            for (int i = 0; i < n % s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    r++;
                }
            }
            return result * (n / s.Count()) + r;
        }
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}