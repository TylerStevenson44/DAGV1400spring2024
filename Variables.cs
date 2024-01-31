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
		Console.WriteLine("If enough Cats visit " + yardVisitors.catName + " gets out the toys.");
		Console.WriteLine("So there are " + yardVisitors.Cats + " visitors.");
		Totalvisits(1, 5);
		Toys(1, 5);
        Totalvisits(4, 12);
        Toys(4, 12);
        Totalvisits(8, 38);
		Toys(8, 38);
		Totalvisits(23, 27);
		Toys(23, 27);
		
    }
	public void Totalvisits (int food, int treat) {
		var number = food + treat / 5 ;
		Console.WriteLine("This many cats have visited! " + number);
    }
    public void Toys (int food, int treat) {
		var number = food + treat / 5 ;
        if (number > 14) {
            Console.WriteLine("Theres more than 15 cats! the toys have been brought out.");
        } else {
            Console.WriteLine("Not enough cats to bother with the toys.");
        }
    }
}
public class Visitors {
    public int Cats;
    public string catName = "Whiskers";
}
public class Food {
    public int Treats = 0;
    public int foodCans = 1;
}
