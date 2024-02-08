using System;

public class Program
{
	public void Main()
	{
		Console.WriteLine("How big do you want your pyramid?");
		string resp = Console.ReadLine();
		int howMany = int.Parse(resp);
		int i = 1;
		while (i <= howMany)
		{
			for (int a = 1; a <= i; a++)
			{
				Console.Write(i);
			}

			Console.WriteLine();
			i++;
		} // this is another method i found that works for this. it seems like 
	}// whats happening here is that the 3 statements in the "for" loop are broken up
}// into separate lines because all the same elements are there, just in different spots. 
// then it adds 1 to "i" at the after the WriteLine until "while (i <= howMany)" is false.
// i dont know which way of doing it is better or worse though.