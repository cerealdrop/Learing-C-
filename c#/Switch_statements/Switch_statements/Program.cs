using System;

namespace Switch_statements
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Random numberGenerator = new Random();
			int num01 = numberGenerator.Next(1, 11);
			int num02 = numberGenerator.Next(1, 11);

			Console.WriteLine("what is " + num01 + "times" + num02 + "?");

			int answer = Convert.ToInt32(Console.ReadLine());

			if (answer == num01 + num02)
			{

				Console.WriteLine("Well done your answer is correct.");
			}
			else
			{

				int respondindex = numberGenerator.Next(1, 4);


				switch (respondindex)
				{
					case 1:
						Console.WriteLine("are you even trying");
						break;

					case 2:
						Console.WriteLine("The answer was incorect");
						break;

					default:
						Console.WriteLine("The answer was incorect");
						break;
				}
			}
		}
	}
}
