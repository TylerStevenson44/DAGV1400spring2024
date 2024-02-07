public void Tempurature(int celsius)
	{
		Console.WriteLine("What is the tempurature(C)?");
		//asks user question.
		string response = Console.ReadLine();
		//gathers response from the user.
		int number = int.Parse(response);
		//converts the users input into an integer(int).
		if (number < -20)
		{
			Console.WriteLine("Are you in Antacrtica? Kiss a penguin for the boys.");
		}
		else if (number < 0)
		{
			Console.WriteLine("It's below freezing! Wear warm and layered clothes.");
		}
		else if (number < 10)
		{
			Console.WriteLine("It's pretty cold, it would be good to wear a jacket.");
		}
		else if (number < 20)
		{
			Console.WriteLine("It's nice and cool outside!");
		}
		else if (number < 30)
		{
			Console.WriteLine("It's nice and warm outside!");
		}
		else if (number < 40)
		{
			Console.WriteLine("It's farily warm be sure to stay hydrated.");
		}
		else
		{
			Console.WriteLine("Stay indoors or in the shade! Hydration is very important!");
		}
	} //takes the converted integer provided from the user and runs it sequentially
} //through various equations until it meets a condition that is true,
//the Console.Writeline associated with each if/else statement will provide the answer.
