using System;

namespace mycs_project
{

 class Bot : Robot
 {
  public Bot() { }

  public Bot(string name, int weight, byte[] cordinates) : base(name, weight, cordinates)
  {

  }

  public override void printValues()
  {
   Console.WriteLine(this.Name + " weight: " + this.Weight + ". Cordinates: ");

   if (this.Cordinates != null)
   {
    foreach (byte item in this.Cordinates)
    {
     Console.WriteLine(item);
    }
   }
   else
   {
    Console.WriteLine("Cordinates are null.");
   }
  }


 }

}