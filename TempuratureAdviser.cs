using System;
public class Program
{
    public Cel Temp;
		
	public void Main() 
    {
		Temp = new Cel();
		
		Temp.Tempurature(12);
    }
}
public class Cel { 	
    public void Tempurature(int celsius){
        var number = celsius;
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
    }
}

