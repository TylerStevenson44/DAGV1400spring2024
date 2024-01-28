using System;

public class Program
{
	public Weapon miniGun;
	
	public void Main()
	{
		miniGun = new Weapon();
		miniGun.ammoCount++;
		Console.WriteLine(miniGun.weaponName + " has ammo count " +  miniGun.ammoCount);

	}
}

public class Weapon {
	public int ammoCount = 10;
	public string weaponName = "Mini Gun";
	public float firepower = 11.5f;
}