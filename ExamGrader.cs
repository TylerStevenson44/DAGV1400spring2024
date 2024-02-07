using System;

public class Program
{
	public void Main()
	{
		Console.WriteLine("Which is your favorite subject? 1.Math, 2.Sciences, 3.English or 4.Arts? Enter corrosponding number.");
		string userInput1 = Console.ReadLine();
		int i = int.Parse(userInput1);
		switch (i)
		{
			case 1:
				Console.WriteLine("Math is cool! Cooler than");
				break;
			case 2:
				Console.WriteLine("The scientific kind obviously.");
				break;
			case 3:
				Console.WriteLine("Write the instructions for an ikea desk pls.");
				break;
			case 4:
				Console.WriteLine("If you like art so much why don't you marry it! hehehhe >///<");
				break;
			default:
				Console.WriteLine("Maybe something different?");
				break;
		}

		Console.WriteLine("Please enter your score for this subject! 0-100+");
		//ask the user for their score!
		string userInput2 = Console.ReadLine();
		//this line the Console.ReadLine takes the response from the user and makes
		//it the value for the string "userInput
		int number = int.Parse(userInput2);
		//this line "int.Parse" converts the value from string "userInput" into an int "number"
		if (number > 100)
		{
			Console.WriteLine("Very impressive!");
		}
		else if (number > 89)
		{
			Console.WriteLine("You got an A!");
		}
		else if (number > 79)
		{
			Console.WriteLine("You got a B!");
		}
		else if (number > 69)
		{
			Console.WriteLine("You got a C!");
		}
		else if (number > 59)
		{
			Console.WriteLine("You got a D!");
		}
		else
		{
			Console.WriteLine("Oopsie whoopsie you failed UwU try harder next time!");
		}
	} //the if, if else and else statements decide which letter ranking will be awarded.
} //the score from the users input gets run as an int through each equation until it meets a true condition.
//Console.WriteLine then provides the user with a letter ranking!
