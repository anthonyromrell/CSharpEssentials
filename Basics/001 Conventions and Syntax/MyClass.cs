using System;
					
public class Program
{
	public Weapon wOne;
	public Weapon wTwo;
	public Weapon wThree;
	
	public void Main()
	{
		wOne = new Weapon();
		wTwo = new Weapon();
		wThree = new Weapon();
		
		wOne.Name = "MP5";
		wOne.Power = 5;
		wOne.Ammo = 30;
		wOne.Range = 5;
		
		wTwo.Name = "RPG";
		wTwo.Power = 25;
		wTwo.Ammo = 4;
		wTwo.Range = 8;
		
		wThree.Name = "1911";
		wThree.Power = 7;
		wThree.Ammo = 18;
		wThree.Range = 7;
		
    Console.WriteLine("CHOOSE YOUR WEAPON");
		Console.WriteLine(wOne.Name);
		Console.WriteLine("Damage: " + wOne.Power);
		Console.WriteLine("Capacity: " + wOne.Ammo);
		Console.WriteLine("Range: " + wOne.Range + "00 meters");
		
		Console.WriteLine(wTwo.Name);
		Console.WriteLine("Health: " + wTwo.Power);
		Console.WriteLine("Capacity: " + wTwo.Ammo);
		Console.WriteLine("Range: " + wTwo.Range + "00 meters");
		
		Console.WriteLine(wThree.Name);
		Console.WriteLine("Health: " + wThree.Power);
		Console.WriteLine("Capacity: " + wThree.Ammo);
		Console.WriteLine("Range: " + wThree.Range + "00 meters");
	}
}

public class Weapon {
	
	public string Name;
	public int Power;
	public int Ammo;
	public int Range;
}
