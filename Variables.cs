using System;

public class Program
{
    public Visitors yardVisitors;
    public Food catSnack;

    public void Main()
    {
        yardVisitors = new Visitors();
		catSnack = new Food();
       
        yardVisitors.Cats += catSnack.foodCans;
        Console.WriteLine(yardVisitors.catName + " puts out " + catSnack.Treats + " treats with each can of food.");
		Console.WriteLine("So there are " + yardVisitors.Cats + " visitors.");
		
		
    }
}
public class Visitors {
    public int Cats = 1;
    public string catName = "Whiskers";
}
public class Food {
    public int Treats = 5;
    public int foodCans = 1;
}