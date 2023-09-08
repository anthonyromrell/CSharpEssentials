using System;
					
public class Program
{
	public Weapon Laserbeam;
	public PowerUp weaponPowerUp;
	
	public void Main()
	{
		Laserbeam = new Weapon();
		weaponPowerUp = new PowerUp();
		
		Laserbeam.blowCount ++;
		Laserbeam.freezeRay += weaponPowerUp.fluid;
		Console.WriteLine(Laserbeam.weaponName + " has an ammo count of " + Laserbeam.blowCount + ".");
		Console.WriteLine("The fluid in the freeze ray has gone below " + Laserbeam.freezeRay + ", it below freezing.");
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