using System;

namespace mycs_project
{

	class Program
	{
		static void Main()
		{
			// string word = "david";
			// bool isAlive = true;

			// if (isAlive) {
			// 	Console.WriteLine("good");
			// }

			// if (word.Length == 5) {
			// 	Console.WriteLine("ok");
			// }

			// int x = 10;
			// bool isHappy = false;

			// if (x == 10 && isHappy)
			// {
			// 	Console.WriteLine("Number is 10 and user is happy!");
			// }
			// 		if (x == 10 || isHappy)
			// 	{
			// 		Console.WriteLine("Number is 10 and user is happy!");
			// 	}
			// 	else if (x > 100)
			// 	{
			// 		Console.WriteLine("X is not bigger than 10");
			// 	}
			// 	else
			// 	{
			// 		Console.WriteLine("Something went wrong");
			// 	}


			Console.Write("Enter name: ");
			string role = Console.ReadLine();

			if (role == "admin")
			{
				Console.Write("Enter name: ");
				string user_name = Console.ReadLine();
				Console.Write("Enter {0} age", user_name);
				short age = Convert.ToInt16(Console.ReadLine());

				if (age <= 0 || age > 99)
				{
					Console.Write("Enter {0} age", user_name);
					age = Convert.ToInt16(Console.ReadLine);
				}

				if (age <= 0 || age > 99)
					Console.WriteLine("Error");
				else
				{
					Console.WriteLine("User age is" + age);
				}

			}
			else
				Console.WriteLine("You are not admin");

		}
	}

}