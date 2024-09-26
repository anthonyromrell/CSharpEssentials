using System;
					
public class Program
{
	public Weapon pistol;
	public Damage headshot;
	
	public void Main()
	{
		pistol = new Weapon();
		headshot = new Damage();
		
		pistol.damagePerBullet++;
		pistol.firePower+= headshot.precision;
		Console.WriteLine( pistol.weaponName + " deals " + pistol.damagePerBullet + " Damage.");
		Console.WriteLine("With precision accuracy El Pistole deals " + pistol.firePower + ", on headshots.");
	}
}

public class Weapon { 
	public int damagePerBullet = 10;
	public string weaponName = "El Pistole";
	public float firePower = 11.5f;
}

public class Damage {
	public float precision = 10.5f;	
}