using System;

namespace dice_game
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Random randomnumber = new Random();
			int numberofattempts = 0;

			int attempts = 0;

			while (attempts!=6)
			{
				attempts = randomnumber.Next(1, 7);
				numberofattempts++;
				Console.WriteLine("You rolled a: "+attempts);
				if (attempts != 6)
				{
					Console.WriteLine("You did not roll a six i will try again");
				}
				else { 
					Console.WriteLine("great job");
				}
			}
			Console.WriteLine("You attempted this game "+numberofattempts+" times");
		}
	}
}
