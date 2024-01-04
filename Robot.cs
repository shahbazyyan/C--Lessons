using System;

namespace mycs_project {
     
     class Robot {

       private string name;
       private int weight;
       private byte[] cordinates;

       private int total;

       public void setValues (string _name, int _weight, byte[] _cordinates) {
        name = _name;
        weight = _weight;
        cordinates = _cordinates;
       }

       public void printValues () {
        Console.WriteLine(name + " Weight: " + weight);
        foreach(byte item in cordinates) {
            Console.WriteLine(item);
        }
       }

     }

}