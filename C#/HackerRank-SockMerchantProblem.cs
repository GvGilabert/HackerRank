//PROBLEM
//John works at a clothing store.He has a large pile of socks that he must pair by color for sale.Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

//For example, there are n = 7 socks with colors ar =[1, 2, 1, 2, 1, 3, 2].There is one pair of color 1 and one of color 2. There are three odd socks left, one of each color.The number of pairs is 2.

//Function Description

//Complete the sockMerchant function in the editor below.It must return an integer representing the number of matching pairs of socks that are available.

//sockMerchant has the following parameter(s) :

//n: the number of socks in the pile
//ar: the colors of each sock

//Input Format

//The first line contains an integer n, the number of socks represented in ar.
//The second line contains n space-separated integers describing the colors ar[i] of the socks in the pile.

class Solution
{

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        Array.Sort(ar);
        int result = 0;
        for (int i = 0; i < ar.Length - 1; i++)
        {
            if (ar[i] == ar[i + 1])
            {
                result++;
                i++;
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
