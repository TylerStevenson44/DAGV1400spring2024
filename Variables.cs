using System;

public class Program
{
    public Visitors yardVisitors;
    public Food catSnack;

    public void Main()
    {
        yardVisitors = new Visitors();
		catSnack = new Food();
		
        catSnack.Treats += 5;
        yardVisitors.Cats = (catSnack.foodCans + catSnack.Treats / 5);
        Console.WriteLine(yardVisitors.catName + " puts out " + catSnack.Treats + " treats outside with " + catSnack.foodCans + " cans of wet food.");
		Console.WriteLine("Every food can and every 5 treats brings another visit.");
		Console.WriteLine("So there are " + yardVisitors.Cats + " visitors.");
		Totalvisits(1, 5);
		Totalvisits(3, 15);
		Totalvisits(6, 30);
		Totalvisits(12, 60);
		Totalvisits(24, 120);
	
		
    }
	public void Totalvisits (int food, int treat) {
		var number = food + treat / 5 ;
		Console.WriteLine("This many cats have visited! " + number);
}
public class Visitors {
    public int Cats;
    public string catName = "Whiskers";
}
public class Food {
    public int Treats = 0;
    public int foodCans = 1;
}
}
