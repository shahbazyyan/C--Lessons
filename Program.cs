using System;
using System.IO;
using System.Collections.Generic;

namespace mycs_project
{

 class Program
 {
  static void Main()
  {

   //    Bot bot = new Bot("Bot", 96, new byte[] { 3, 5, 7 });
   //    bot.printValues();

      Killer killer = new Killer("Killer", 980, new byte[] { 4, 6, 9 }, 100, Type.Traitor);
      killer.printValues();
      killer.Lazer();


      // Bot bot1 = new Bot();
      // bot1.setValues("Mike");
      

   // Multiply(7, 89);
   // Multiply(7.5f, 89.7f);


  }

  public static void Multiply(int a, int b)
  {
   int res = a * b;
   Console.WriteLine("Result: " + res);
  }

  public static void Multiply(float a, float b)
  {
   float res = a * b;
   Console.WriteLine("Result: " + res);
  }

 }
}