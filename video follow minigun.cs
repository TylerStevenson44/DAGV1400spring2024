using System;

public class Program
{
	public Weapon miniGun;
	public PowerPup weaponpowerup;
	public void Main()
	{
		miniGun = new Weapon();
		miniGun.ammoCount += 40;
		miniGun.firepower += powerUp();
		Console.WriteLine(miniGun.weaponName + " has ammo count " +  miniGun.ammoCount);
		Console.WriteLine("the fire power of is now " + miniGun.firepower + "has increased")

	}
}

public class Weapon {
	public int ammoCount = 10;
	public string weaponName = "Mini Gun";
	public float firepower = 11.5f;
}

public class powerUp {
	public float powerLevel + 2.5f;
}