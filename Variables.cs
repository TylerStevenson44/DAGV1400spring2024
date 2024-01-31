using System;

public class Program
{
    public Visitors Yard;
    public Food catSnack;

    public void Main()
    {
        Yard = new Visitors();
		catSnack = new Food();
		
        catSnack.Treats += 5;
        Yard.Cats = (catSnack.foodCans + catSnack.Treats / 5);
        Console.WriteLine(Yard.catName + " puts out " + catSnack.Treats + " treats outside with " + catSnack.foodCans + " cans of wet food.");
		Console.WriteLine("Every food can and every 5 treats brings another visit.");
		Console.WriteLine("If enough Cats visit " + Yard.catName + " gets out the toys.");
		Console.WriteLine("So there are " + Yard.Cats + " visitors.");
		Yard.Totalvisits(1, 5);
		Yard.Toys(1, 5);
        Yard.Totalvisits(4, 12);
        Yard.Toys(4, 12);
        Yard.Totalvisits(8, 38);
		Yard.Toys(8, 38);
		Yard.Totalvisits(23, 27);
		Yard.Toys(23, 27);
		Yard.Totalvisits(38, 73);
		Yard.Toys(38, 73);
    }
}
public class Visitors {
    public void Totalvisits (int food, int treat) {
		var number = food + treat / 5 ;
		Console.WriteLine("This many cats have visited! " + number);
    }
    public void Toys (int food, int treat) {
		var number = food + treat / 5 ;
        if (number > 49) {
            Console.WriteLine("50 CATS!");
        }
        else if (number > 14) {
            Console.WriteLine("Theres more than 15 cats! The toys have been brought out.");
        }
        else {
            Console.WriteLine("Not enough cats to bother with the toys.");
		}
	}
    public int Cats;
    public string catName = "Whiskers";
    
}
public class Food {
    public int Treats = 0;
    public int foodCans = 1;
}
