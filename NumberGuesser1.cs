using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Guess from 1-10.");
		Random rnd = new Random();
		// ^ generate random number.
		int random = rnd.Next(1, 11);
		// ^ make the random number between 1 and 10.
		int input = 0;
		Console.WriteLine(random);
		while (random != input)
		{// ^ outer loop checks if the input is not equal to the random number.
			input = Convert.ToInt32(Console.ReadLine());
			// ^ convert "input" to an integer.
			while (input < random)
			{
				Console.WriteLine("Too low!");
				Console.ReadLine();
			}// ^ inner loop checks to see if the input is smaller than the random number.

			while (input > random)
			{
				Console.WriteLine("Too high!");
				Console.ReadLine();
			}// ^ second inner loop checks to see if the input is larger than the random number.
		}

		while (input == random)
		{
			Console.WriteLine("Correct guess! Nice.");
			Console.ReadLine();
		}// ^ if the input equals the random number then its a correct guess!
	}
}