// Task 
// Consider a database table, Emails, which has the attributes First Name and Email ID. 
// Given N rows of data simulating the Emails table, print an alphabetically-ordered list 
// of people whose email address ends in @gmail.com.

// Input Format
// The first line contains an integer, N, total number of rows in the table. 
// Each of the N subsequent lines contains 2 space-separated strings denoting 
// a person's first name and email ID, respectively.

// Output Format
// Print an alphabetically-ordered list of first names for every user with a 
// gmail account. Each name must be printed on a new line.
class Solution {

    static void Main(string[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        List<string> values = new List<string>();
        for (int NItr = 0; NItr < N; NItr++) 
        {
            string[] firstNameEmailID = Console.ReadLine().Split(' ');
            string firstName = firstNameEmailID[0];
            string emailID = firstNameEmailID[1];
            
            if (emailID.EndsWith("@gmail.com"))
                values.Add(firstNameEmailID[0]);
        }
        values.Sort();
        foreach(string val in values)
        {
            Console.WriteLine(val);
        }
    }
}