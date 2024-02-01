
using System;

public class Program
{
    public Score GetScore;
    public void Main()
    {
        GetScore = new Score();

        GetScore.Grade(100);

    }
}
public class Score
{
    public void Grade(int exScore) 
    {
        var number = exScore;
        if (number > 89)  
        {
            Console.WriteLine("You got an A!");
        }
        else if (number > 79)
        {
            Console.WriteLine("You got a B!");
        }
        else if (number >  69)
        {
            Console.WriteLine("You got a C!");
        }
        else if (number >  59)
        {
            Console.WriteLine("You got a D!");
        }
        else
        {
            Console.WriteLine("Oopsie whoopsie you failed UwU try harder next time!");
        }
    }
}
