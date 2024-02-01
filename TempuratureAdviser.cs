using System;
public class Program
{
    public Cel Temp;
		
	public void Main() 
    {
		Temp = new Cel();
		
		Temp.Tempurature(12);
    }//^ some left over code. originally ref'd 'public class Cel' for the score.
    //changed to Console.Readline and an int.Parse() to ref the users input. 
    //could remove extra and move all lines below 'public void Tempurature()' 
    //under 'public void Main()'
}
public class Cel 
{ 	
    public void Tempurature(int celsius)
    {
        Console.WriteLine("What is the tempurature(C)?");
        //asks user question.
        string response = Console.ReadLine();
        //gathers response from the user.
        int number = int.Parse(response);
        //converts the users input into an integer(int).
		if (number < 3) 
        {
			Console.WriteLine("Cold today tho.");
        }
         else if (number > 29) 
        {
            Console.WriteLine("It's hot outside stay hydrated and in shade!");
        }
         else
        {
            Console.WriteLine("It should be a nice day outside!");		
		}
    }   //takes the converted integer provided from the user and runs it sequentially
}       //through various equations until it meets a condition that is true,
        //the Console.Writeline associated with each if/else statement will provide the answer.
