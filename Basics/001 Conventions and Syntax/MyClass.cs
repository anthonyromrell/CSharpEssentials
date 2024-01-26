//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables
using System;

	public class Human 
	{
		public string Name; 
		public int Age; 
		public bool HasPet;
		
		public void Greeting()
		{
			Console.WriteLine("This is" + Name + ".");
			Console.WriteLine("She is" + Age + ".");
		}
	}
class program 
{
	static void Main(string[] args)
	{
		Human person = new Human ();
		
		person.Name = "Polly";
		person.Age = 100;
		person.HasPet = true;
		
		person.Greeting();
	}	
}