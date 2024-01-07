using System;

namespace mycs_project
{

 abstract class Robot
 {

  private static int conut;
  private string name;
  private int weight;
  private byte[] cordinates;
  protected string rank;

  public byte[] Cordinates
  {
   get
   {
    return cordinates;
   }
   private set { }
  }
  public string Name
  {
   get
   {
    return name;
   }
   private set { }
  }

  public int Weight
  {
   get
   {
    return this.weight;
   }
   set
   {
    if (value < 1)
     this.weight = 1;
    else if (value > 5000)
     this.weight = 5000;
    else
     this.weight = value;
   }
  }

  public int Width { private get; set; }

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

  public Robot(string name)
  {
   Console.WriteLine("Object has been created");
   this.name = name;
   conut++;
  }


  public void setValues(string name, int weight, byte[] cordinates)
  {
   this.name = name;
   this.weight = weight;
   this.cordinates = cordinates;
  }

  public abstract void printValues();

  public static void Print()
  {
   Console.WriteLine("Conut: " + conut);
  }

 }
}