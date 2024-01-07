using System;
using System.IO;
using System.Collections.Generic;

namespace mycs_project
{

 class Program
 {
  static void Main()
  {

   // Robot bot = new Robot("Bot", 96, new byte[] { 3, 5, 7 });
   // bot.printValues();

   Killer killer = new Killer("Killer", 980, new byte[] { 4, 6, 9 }, 100);
   killer.setValues("Killer", 980, new byte[] {4,6,9});
   killer.printValues();
   killer.Health = 100;
   killer.Lazer();

   // Robot bot1 = new Robot("Botan");
   // bot1.Weight = -100;
   // Console.WriteLine(bot1.Weight);

   // bot1.Width = -100;
   // Console.WriteLine(bot1.Width);

   // Robot.conut = 10;
   // Robot.Print();





  }
 }
}