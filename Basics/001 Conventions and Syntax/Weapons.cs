using System;
					
public class Program
{
	public Weapon miniGun;
	public PowerUp weaponPowerUp;
	
	public void Main()
	{
		miniGun = new Weapon();
		weaponPowerUp = new PowerUp();
		
		miniGun.blowCount ++;
		miniGun.freezeRay += weaponPowerUp.fluid;
		Console.WriteLine(miniGun.weaponName + " has an ammo count of " + miniGun.blowCount + ".");
		Console.WriteLine("The fluid in the freeze ray has gone below " + miniGun.freezeRay + ", it below freezing.");
	}
}

public class Weapon { 
	public int blowCount = 100;
	public string weaponName = "Laser Beam";
	public float freezeRay = -5f;
}

public class PowerUp {
	public float fluid = -60.4f;	
}