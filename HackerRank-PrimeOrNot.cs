//Task
//A prime is a natural number greater than 1 that has no positive divisors other than 1 and itself. Given a number, n, determine and print whether it's Prime or Not prime.

//Input Format
//The first line contains an integer, T, the number of test cases.
//Each of the T subsequent lines contains an integer, n, to be tested for primality.

//Output Format
//For each test case, print whether n is Prime or Not Prime on a new line.

//Sample Input
//3
//12
//5
//7

//Sample Output
//Not prime
//Prime
//Prime

class Solution
{
    static void Main(String[] args)
    {
        int t = int.Parse(Console.ReadLine());
        while (t > 0)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
            t--;
        }
    }

    public static string IsPrime(int n)
    {
        if (n == 1)
            return "Not prime";
        else if (n == 2)
            return "Prime";
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return "Not prime";
        }
        return "Prime";
    }
}