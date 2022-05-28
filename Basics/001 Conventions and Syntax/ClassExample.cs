using System;

public class ClassExample
{
    public int numberCountForHealth = 4;
	public int characterAge;
	public string playerName = "Jasepi";
 

    public void Main(string[] args)
    {
		characterAge = 2;
        Console.WriteLine("Welcome " + playerName);
		Console.WriteLine("You have " + numberCountForHealth + " health.");
		Console.WriteLine("Happy Birthday! " + characterAge + " never looked so good!");
	
	}
}
