using System;

namespace mycs_project
{

	class Program
	{
		static void Main()
		{
			short user_input = Convert.ToInt16(Console.ReadLine());

			switch (user_input)
			{
				case 1: System.Console.WriteLine("Number is 1"); break;
				case 2: System.Console.WriteLine("Number is 2"); break;
				case 3: System.Console.WriteLine("Number is 3"); break;
				case 4: System.Console.WriteLine("Number is 4"); break;
				default:
					Console.WriteLine("Number not found!");
					break;
			}
		}
	}

}