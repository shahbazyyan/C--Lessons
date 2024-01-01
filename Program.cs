using System;
using System.Collections.Generic;

namespace mycs_project
{

 class Program
 {
  static void Main()
  {
   // Print("Hello World!");
   // Calculator(4,7,9);
   // PrintName();
   byte[] nums = { 3, 4, 5, 7, 9 };
   byte resultat = Calc(nums);
   // Console.WriteLine("Resultat: {0}", resultat);
   long factorial = Factorial(55);
   Console.WriteLine(factorial);
  }

  public static long Factorial(long n)
  {
   if (n == 0 || n == 1)
   {
    return 1;
   }
   long res = 1;
   for (long i = 2; i <= n; i++)
   {
    res *= i;
   }
   return res;
  }

  public static byte Calc(byte[] digits)
  {
   byte val = 0;
   foreach (byte item in digits)
   {
    val += item;
   }
   return val;
  }

  // public static void Print (string str) {
  //  Console.WriteLine(str);
  // }

  // public static void Calculator (int x, int y, int z) {
  //     int res = (x+y) * z;
  //     Print("Value: " + res);
  // }

  // public static string PrintName () {
  //  string names = Console.ReadLine();
  //  return names;
  // }




 }
}