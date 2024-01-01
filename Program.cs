using System;
using System.Collections.Generic;

namespace mycs_project
{

 class Program
 {
  static void Main()
  {

   // short[] nums = {1,2,4,5,6,7};

   // foreach(short item in nums) {
   //  Console.WriteLine("Item: " + item);
   // }

   // short[,] numbers = {
   //  {2,3,4},
   //  {24,22,43},
   //  {6,77,34},
   // };

   // foreach(short item in numbers) {
   //  Console.WriteLine("Item: " + item);
   // }

   List<int> nums = new List<int> () {
    5,6,8
   };

   nums.Add(222);
   nums.Add(123);

   nums.Remove(222);
   nums.Sort();
   nums.Reverse();
   // nums.Clear();
   bool containsEight = nums.Exists(item => item == 8);
   Console.WriteLine(containsEight);
   

   foreach(int item in nums) {
    Console.WriteLine(item);
   }



  }
 }
}