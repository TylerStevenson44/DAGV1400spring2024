using System;
					
public class Program
{
	public void Main()
	{
		string[] playerTypes = {"Pawn", "Pawn", "Pawn"};
		
		for (var i =0; i < playerTypes.Length ; i++) 
		{
			playerTypes[i] = "Queen";
		}
		
		foreach(var playerType in playerTypes) 
		{
			Console.WriteLine(playerType);
		}
	}
}