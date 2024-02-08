using System;

public class Program
{
	public void Main()
	{
		Console.WriteLine("How big for this number pyramid?");
		string response = Console.ReadLine();
		int conv = int.Parse(response);
		// ^ ask user for input and convert to an integer.
		for (int i = 1; i <= conv; i++)
		{ 	// ^ statement "i = 1;" is done once. "i <= conv;" defines the condition to execute the code block.
			// in this case "i <= conv;" means the code keeps looping until "i" is larger than the user input integer.
		 	//  "i++" increases the value of "i" after each time the code is executed.
			for (int a = 1; a <= i; a++)
			{ 		// ^ this nested loop is what makes it write each number the
			 		// amount of times that is equal to the current value of "i" in the previous loop.
					// each time it loops it has Console.Write put down the number of numbers until
					// its larger than the number of numbers. then it adds one to "a" for the next time its executed.
				Console.Write(i);
			}	//Console.Write writes each number out each time it loops
			Console.WriteLine();
		} 	//Console.WriteLine separates the number groups into their own lines because once each outer loop completes
	}    	// it moves down to the next line unlike Console.Write which keeps using the same line.
}