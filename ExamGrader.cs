using System;

public class Program
{
	public void Main()
	{
		Console.WriteLine("Please enter your score! 0-100+");
        //ask the user for their score!
		string userInput = Console.ReadLine();
        //this line the Console.ReadLine takes the response from the user and makes
       //it the value for the string "userInput
		int number = int.Parse(userInput);
        //this line "int.Parse" converts the value from string "userInput" into an int "number"
		if (number > 89)
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
	}    //the if, if else and else statements decide which letter ranking will be awarded.
}       //the score from the users input gets run as an int through each equation until it meets a true condition.
       //Console.WriteLine then provides the user with a letter ranking!