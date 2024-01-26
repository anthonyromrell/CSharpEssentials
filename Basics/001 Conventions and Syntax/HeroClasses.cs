using System;
					
public class Program
{
	public Hero Kitsune;
	public Hero JackBat;
	
	public void Main()
	{
		Kitsune = new Hero();
		JackBat = new Hero();
		
		Kitsune.spirit = 3;
		JackBat.transformation = 1;
		
		JackBat.spirit = 5;
		Kitsune.transformation = 10;
		
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