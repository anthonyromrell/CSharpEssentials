
					
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
		
		heroOne.health = 5;
		heroOne.powerLevel = 5;
		heroOne.speed = 5;
		heroOne.magic = 10; 
		
		heroTwo.health = 6;
		heroTwo.powerLevel = 4;
		heroTwo.speed = 10;
		heroTwo.magic = 1;
		
		heroThree.health = 10;
		heroThree.powerLevel = 7;
		heroThree.speed = 2;
		heroThree.magic = 1;
		
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
		Console.WriteLine(heroOne.speed); 
		Console.WriteLine(heroOne.magic);
			
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
		Console.WriteLine(heroTwo.speed);
		Console.WriteLine(heroTwo.magic);
		
		Console.WriteLine(heroThree.health);
		Console.WriteLine(heroThree.powerLevel);
		Console.WriteLine(heroThree.speed);
		Console.WriteLine(heroThree.magic);
		
		
	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public int speed;
	public int magic;
	
}
	