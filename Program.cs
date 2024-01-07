using System;
using System.IO;
using System.Collections.Generic;

namespace mycs_project
{

 class Program
 {
  static void Main()
  {

   Bot bot = new Bot("Bot", 96, new byte[] { 3, 5, 7 });
   bot.printValues();

   Killer killer = new Killer("Killer", 980, new byte[] { 4, 6, 9 }, 100);
   killer.printValues();
   killer.Lazer();

   Bot bot1 = new Bot();

  }
 }
}