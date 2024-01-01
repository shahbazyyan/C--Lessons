using System;

namespace mycs_project
{

 class Program
 {
  static void Main()
  {

   // int[] numbers = new int[5];
   // numbers[0] = 20;
   // numbers[1] = 50;
   // numbers[2] = 100;
   // numbers[3] = 150;
   // numbers[4] = 210;

   // System.Console.WriteLine("El: " + numbers[2]); 

   // string[] words = new string[] {"John", "Alex", "Snow"};

   // words[1] = "Bob";

   // for (int i = 0; i < numbers.Length; i++) {
   //  Console.WriteLine("El: " + numbers[i] + 1);
   // }


   // short[] numbers = new short[10];
   // Random random = new Random();
   // short val = 0;

   // for (byte i = 0; i < numbers.Length; i++)
   // {
   //  numbers[i] = Convert.ToInt16(random.Next(11, 97));
   //  Console.WriteLine("Element: " + numbers[i]);

   //  val += numbers[i];
   // }
   // Console.WriteLine("Value: " + val);

   char[,] symbols = new char[2, 2];
   symbols[0, 0] = 'k';



   int[,] nums = {
    {5, 6, 7},
    {1, 3, 2},
    {3, 3, 3}
};

   nums[1, 2] = 5;

   for (int i = 0; i < nums.GetLength(0); i++) // Loop through rows
   {
    for (int j = 0; j < nums.GetLength(1); j++) // Loop through columns
    {
     Console.WriteLine(nums[i, j]);
    }
   }



  }
 }
}