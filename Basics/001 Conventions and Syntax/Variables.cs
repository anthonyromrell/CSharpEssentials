using System;
					
public class Program
{
	public MeleeWeapon beamSword;
	public ChargeUp tBag;
	
	public void Main()
	{
		beamSword = new MeleeWeapon();
		tBag = new ChargeUp();
			
		beamSword.basicDmg++;
		beamSword.basicDmg *= tBag.dmgMultiplier;
		
		Console.WriteLine(beamSword.meleeWeaponName + ". Halo's most iconic weapon, now in C#! ");
		Console.WriteLine("Durability of " + beamSword.durability);
		Console.WriteLine("Right click to stab for " + beamSword.basicStab + " damage!" );
		Console.WriteLine("TBag for an increase of your basic attacks " +  "to " + beamSword.basicDmg + " instead of the usual 5.5.");
		
	
	}
}

public class MeleeWeapon {
	public int durability = 15;
	public string meleeWeaponName = "Beam Sword";
	public float basicDmg = 5.5f;
	public int basicStab = 20;
	
}

public class ChargeUp{
		public float dmgMultiplier = 3.5f;
	
}