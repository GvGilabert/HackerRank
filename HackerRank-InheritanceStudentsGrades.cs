//PROBLEM
//You are given two classes, Person and Student, where Person is the base class and Student is the derived class. Completed code for Person and a declaration for Student are provided for you in the editor.Observe that Student inherits all the properties of Person.

//Complete the Student class by writing the following:

//A Student class constructor, which has  parameters:
//A string, firstName.
//A string, lastName.
//An integer, id .
//An integer array(or vector) of test scores, scores.
//A char calculate() method that calculates a Student object's average and returns the grade character representative of their calculated average:

//GRADING SCALE
//LETTER AVERAGE(a)
//O	90-100
//E	80-90
//A	70-80
//P	55-70
//D	40-55
//T   <40

//Input Format

//The locked stub code in your editor calls your Student class constructor and passes it the necessary arguments.It also calls the calculate method (which takes no arguments).

//You are not responsible for reading the following input from stdin: 
//The first line contains, firstName, lastName, and id, respectively.The second line contains the number of test scores.The third line of space-separated integers describes scores.

//Output Format

//This is handled by the locked stub code in your editor. Your output will be correct if your Student class constructor and calculate() method are properly implemented.

using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person{
    private int[] testScores;
    private string FirstName;
    private string LastName;
    private int Id;
    private int[] Scores;  
    
    public Student(string fName, string lName, int id, int[] scores):base(fName,lName,id)
    {
        FirstName=fName;
        LastName=lName;
        Id=id;
        Scores=scores;
    }

    public char Calculate()
    { 
        double avg = Scores.Average();
        if(avg<40)
            return 'T';
        else if(avg<55)
            return 'D';
        else if(avg<70)
            return 'P';
        else if(avg<80)
            return 'A';
        else if(avg<90)
            return 'E';
        else 
            return 'O';
    }
}

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}
