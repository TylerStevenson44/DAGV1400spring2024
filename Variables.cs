using System;

public class Program
{
    public Visitors yardVisitors;
    public Food catSnack;

    public void Main()
    {
        yardVisitors = new Visitors();
		catSnack = new Food();
		
        catSnack.Treats += 56;
        yardVisitors.Cats = (catSnack.foodCans + catSnack.Treats / 5);
        Console.WriteLine(yardVisitors.catName + " puts out " + catSnack.Treats + " treats outside with " + catSnack.foodCans + " cans of wet food.");
		Console.WriteLine("Every 5 treats brings another visit.");
		Console.WriteLine("So there are " + yardVisitors.Cats + " visitors.");
    }
}
public class Visitors {
    public int Cats;
    public string catName = "Whiskers";
}
public class Food {
    public int Treats = 0;
    public int foodCans = 6;
}