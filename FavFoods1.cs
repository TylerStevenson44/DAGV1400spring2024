using System;

public class Program
{
	public static void Main()
	{
		string[] foods = {"food", "food", "food"};
        //^ this is the array that holds our 3 objects.
		Console.WriteLine("What is your favorite food?");
		foods[0] = Console.ReadLine();
		//^ gather the first food from the user.
        // "foods[0]" represents the first food in the array.
		Console.WriteLine("Second fav food?");
		foods[1] = Console.ReadLine();
		//^ second and third foods use the same process as the first.
		Console.WriteLine("Third fav food?");
		foods[2] = Console.ReadLine();
		
		foreach (var food in foods)
		    Console.WriteLine("nomnomnom.. I love " + food + "! ");
	}// foreach loop causes WriteLine to happen once per object in our array
}   // it writes each corresponding food for the objects in the array.
