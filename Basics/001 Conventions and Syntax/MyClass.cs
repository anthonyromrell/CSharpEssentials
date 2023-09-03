using System;

public class Program 
{
	public Item grenade;
	public Weapon pistole;
	public Item potion;
	public Weapon rifle;
	
	public void Main()
	{
		grenade = new Item();
		pistole = new Weapon();
		rifle= new Weapon();
		
		grenade.uses+=
		grenade.damage++;
		Console.WriteLine(grenade.uses);
		
		pistole.magazineSize++ ;
		pistole.damagePerBullet++ ;
		pistole.headshotDamage+= pistole.damagePerBullet; 
		Console.WriteLine(pistole.magazineSize);
		Console.WriteLine(pistole.damagePerBullet);
		Console.WriteLine(pistole.headshotDamage);
		
	}	
}

public class Item {
	public int uses = 2;
	public string itemName = "Frag";
	public int damage = 50;
}

public class Weapon {
	public int magazineSize = 10;
	public int damagePerBullet = 20;
	public float headshotDamage = 7.5f;
	public string weaponName = "Pistole" + "Rifle";
	
}