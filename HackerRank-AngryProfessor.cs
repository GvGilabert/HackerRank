/*A Discrete Mathematics professor has a class of students. Frustrated with their lack of discipline, he decides to cancel class if fewer than some number of students are present when class starts. Arrival times go from on time (arrivalTime <= 0) to arrived late (arrivalTime > 0).

Given the arrival time of each student and a threshhold number of attendees, determine if the class is canceled.

Input Format
The first line of input contains t, the number of test cases.

Each test case consists of two lines.

The first line has two space-separated integers,n and k, the number of students (size of a) and the cancellation threshold. 
The second line contains n space-separated integers (a[1],a[2],...,a[n]) describing the arrival times for each student.

Note: Non-positive arrival times (a[i]<=0) indicate the student arrived early or on time; positive arrival times (a[i]>0) indicate the student arrived a[i] minutes late.

For example, there are n=6 students who arrive at times a = [-1,-1,0,0,1,1]. Four are there on time, and two arrive late. If there must be k=4 for class to go on, in this case the class will continue. If there must be k=5, then class is cancelled.

Function Description

Complete the angryProfessor function in the editor below. It must return YES if class is cancelled, or NO otherwise.
angryProfessor has the following parameter(s):

k: the threshold number of students
a: an array of integers representing arrival times

Output Format

For each test case, print the word YES if the class is canceled or NO if it is not.

Note 
If a student arrives exactly on time (a[i] = 0), the student is considered to have entered before the class started.*/

class Solution {

    // Complete the angryProfessor function below.
    static string angryProfessor(int k, int[] a) {
        int lates=0;
        foreach (int val in a)
            if (val > 0)
                lates++;
        return a.Length - lates >= k ? "NO":"YES";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            string result = angryProfessor(k, a);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}