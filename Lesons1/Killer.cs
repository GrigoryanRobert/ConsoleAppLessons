using System;
namespace ConsoleApp1
{ 
    class Killer : Class1
    {
        public int Health { get; set; }

        public Killer() { }

        public Killer(string name, int weight, byte[] array, int health) : base(name, weight, array)
        {
            this.Health = health;
        }

        public void Lazer()
        {
            System.Console.WriteLine("lazer shooting here");
        }
    }

}