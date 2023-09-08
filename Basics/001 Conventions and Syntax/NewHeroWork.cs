//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

using System;
					
public class Program
{
	public Hero Kitsune;
	public Hero JackBat;
	
	public void Main()
	{
		Kitsune = new Hero();
		JackBat = new Hero();
		
		Kitsune.spirit = 3 + 10;
		JackBat.transformation = 4*3;
		
		JackBat.spirit = 10 % 5;
		Kitsune.transformation = 10/5;
		
		Console.WriteLine(Kitsune.spirit);
		Console.WriteLine(Kitsune.transformation);
		
		Console.WriteLine(JackBat.spirit);
		Console.WriteLine(JackBat.transformation);
	}
}

public class Hero {
	public int spirit;
	public int transformation;
}