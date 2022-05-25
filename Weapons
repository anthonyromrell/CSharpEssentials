using System;
					
public class Program
{
	public Weapon Glock;
	public PowerUp weaponPowerUp;
	
	public void Main()
	{
		Glock = new Weapon();
		weaponPowerUp = new PowerUp();
		
		Glock.ammoCount += 10 ;
		Glock.firePower += weaponPowerUp.powerLevel;
		Console.WriteLine(Glock.weaponName + " has an ammo count of " + Glock.ammoCount);
		Console.WriteLine("The fire power is now " + Glock.firePower + ". It has increased.");
		
	}
}

public class Weapon{

	public int ammoCount = 18;
	public string weaponName = "Glock 19";
	public float firePower = 8.5f;
} 

public class PowerUp{
	public float powerLevel = 4.5f;

}