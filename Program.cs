using System;
using System.IO;

namespace mycs_project
{

 class Program
 {
  static void Main()
  {

   Robot bot = new Robot("Bot", 96, new byte[] { 3, 5, 7 });
   bot.printValues();

   Robot killer = new Robot();
   killer.setValues("Killer", 980, new byte[] {4,6,9});
   killer.printValues();

   Robot bot1 = new Robot("Botan");

   // Robot.conut = 10;
   Robot.Print();
  
  }
 }
}