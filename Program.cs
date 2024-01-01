using System;

namespace mycs_project
{

 class Program
 {
  static void Main()
  {

   // for (byte i = 0; i <= 21; i++) {
   //  Console.WriteLine("Element: {0}", i);
   // }

   // for (float i = 200; i > 10; i/=2) {
   //   Console.WriteLine("Element: {0}", i);
   // }

   // int i = 0;
   // while (i <= 15)
   // {
   //  Console.WriteLine("Element: {0}", i);
   //  i++;
   // }

   // bool isAlive = true;
   // while(isAlive) {
   //  string end = Console.ReadLine();
   //  if(end == "end") 
   //        isAlive = false;
   // }


   // byte i = 100;

   //  do {
   //     Console.WriteLine("Element: " + i);
   //  } while (i < 10);


   for (short i = 0; i < 100; i++) {
    // if(i > 5) break;
    if(i % 2 == 0) continue;
    Console.WriteLine("Element: " + i);
   }

  }
 }

}