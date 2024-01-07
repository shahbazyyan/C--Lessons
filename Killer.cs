using System;

namespace mycs_project {

 class Killer : Robot  {
    public int Health {get; set;}

    public Killer () {}

    public Killer (string name, int weight, byte[] cordinates, int health): base(name,weight,cordinates) {
        this.Health = health;
        base.printValues();
    }

    public void Lazer () {
        Console.WriteLine("Shooting with lazer");
        this.rank = "S1";
    }
 }

}