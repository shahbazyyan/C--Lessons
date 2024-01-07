using System;

namespace mycs_project
{

 class Robot
 {

  private static int conut;
  private string name;
  private int weight;
  private byte[] cordinates;

  public Robot(string _name, int _weight, byte[] _cordinates)
  {
   Console.WriteLine("Object has been created");
   setValues(_name, _weight, _cordinates);
   conut++;
  }

  public Robot()
  {
   conut++;
  }

  public Robot(string _name)
  {
   Console.WriteLine("Object has been created");
   name = _name;
   conut++;
  }


  public void setValues(string _name, int _weight, byte[] _cordinates)
  {
   name = _name;
   weight = _weight;
   cordinates = _cordinates;
  }

  public void printValues()
  {
   Console.WriteLine(name + " Weight: " + weight);
   foreach (byte item in cordinates)
   {
    Console.WriteLine(item);
   }
  }

  public static void Print()
  {
   Console.WriteLine("Conut: " + conut);
  }

 }
}