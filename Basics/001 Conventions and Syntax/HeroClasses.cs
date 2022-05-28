//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		heroThree = new Hero();
		
		heroOne.heroName = "Gary";
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroOne.stamina = 3;
		
		heroTwo.heroName = "Pen";
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.stamina = 6;
		
		heroThree.heroName = "Chip";
		heroThree.health = 4;
		heroThree.powerLevel = 4;
		heroTwo.stamina = 2;
		
		Console.WriteLine(heroOne.heroName);
		Console.WriteLine("Health: " + heroOne.health);
		Console.WriteLine("Power Level: " + heroOne.powerLevel);
		Console.WriteLine("Stamina: " + heroOne.stamina);
		
		Console.WriteLine(heroTwo.heroName);
		Console.WriteLine("Health: " + heroTwo.health);
		Console.WriteLine("Power Level: " + heroTwo.powerLevel);
		Console.WriteLine("Stamina: " + heroTwo.stamina);
		
		Console.WriteLine(heroThree.heroName);
		Console.WriteLine("Health: " + heroThree.health);
		Console.WriteLine("Power Level: " + heroThree.powerLevel);
		Console.WriteLine("Stamina: " + heroThree.stamina);
	}
}

public class Hero {
	
	public string heroName;
	public int health;
	public int powerLevel;
	public int stamina;
}
