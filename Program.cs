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

   // Killer killer = new Killer("Killer", 980, new byte[] { 4, 6, 9 }, 100);
   // killer.setValues("Killer", 980, new byte[] {4,6,9});
   // killer.printValues();
   // killer.Health = 100;
   // killer.Lazer();

   // Robot bot1 = new Robot("Botan");
   // bot1.Weight = -100;
   // Console.WriteLine(bot1.Weight);

   // bot1.Width = -100;
   // Console.WriteLine(bot1.Width);

   // Robot.conut = 10;
   // Robot.Print();

  //  List<Robot> robots = new List<Robot>();
  //  robots.Add(new Robot("Alex", 400, new byte[] { 3, 4, 7 }));
  //  robots.Add(new Robot("Deniel", 650, new byte[] { 9, 4, 1 })); 
  //  robots.Add(new Robot("Francua", 350, new byte[] { 5, 4, 7 })); 
  //  robots.Add(new Robot("Carmen", 250, new byte[] { 7, 4, 9 }));

  //  foreach (Robot item in robots)
  // {
  //  Console.WriteLine(item.Name);
  // }



   List<Killer> robots = new List<Killer>();
   robots.Add(new Killer("Alex", 400, new byte[] { 3, 4, 7 }, 100));
   robots.Add(new Killer("Deniel", 650, new byte[] { 9, 4, 1 }, 100)); 
   robots.Add(new Killer("Francua", 350, new byte[] { 5, 4, 7 }, 100)); 
   robots.Add(new Killer("Carmen", 250, new byte[] { 7, 4, 9 }, 100));

   Robot newRobot = null;

   foreach (Killer item in robots)
  {
   if(item.Name == "Carmen") {
    newRobot = item as Killer;
   }
   Console.WriteLine(item is Killer);
  }

  }
 }
}