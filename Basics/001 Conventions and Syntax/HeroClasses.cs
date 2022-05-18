using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
	}
}

public class Hero {
	public int health;
	public int powerLevel;
}