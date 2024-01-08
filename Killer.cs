using System;

namespace mycs_project
{

    enum Type {
        Enemy,
        Hero,
        Traitor
    }

    class Killer : Robot
    {
        public int Health { get; set; }

        public Type type;

        public Killer() { }

        public Killer(string name, int weight, byte[] cordinates, int health, Type type) : base(name, weight, cordinates)
        {
            this.Health = health;
            this.type = type;
        }

        public override void printValues()
        {
            Console.WriteLine(this.Name + " weight: " + this.Weight);
            Console.WriteLine("Health: " + this.Health);

            if(this.type == Type.Hero) {
                Console.WriteLine("He is hero!");
            } else {
                Console.WriteLine("Be cerful he is enemy or traitor!");
            }
        }

        public void Lazer()
        {
            Console.WriteLine("Shooting with lazer");
            this.rank = "S1";
        }
    }

}