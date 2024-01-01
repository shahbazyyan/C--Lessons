using System;

namespace mycs_project
{

 class Program
 {
  static void Main()
  {
    string word = "hello";
    Console.WriteLine(word.Substring(0, word.Length - 1));
    // Console.WriteLine(word.Trim());
    // word = string.Concat(word, "!!");
    // Console.WriteLine(String.Compare(word, "hello"));

   // string people = "Alex,Bob,Jhon";
   // string[] names = people.Split(new char[]{','});

   // people = String.Join("-", names);
   // Console.WriteLine(people);

   // foreach (string item in names)
   // {
   //  Console.WriteLine(item);
   // }

  }
 }
}