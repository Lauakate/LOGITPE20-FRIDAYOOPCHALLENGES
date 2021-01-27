using System;

namespace FridayOOPChallenges
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hunger;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hunger = 0;

            }

            public string Name
            {
                get { return name; }
            }
            public void Sleep()
            {
                Console.WriteLine("Cat sleeps!");
                hunger += 0.2;
            }
            public void Meow()
            {
                Console.WriteLine("Meow!");
            }

            public double Hunger
            {
                get { return hunger; }
            }
        }
        static void Main(string[] args)
        {
            Cat newCat = new Cat("dots", "brown");
            Console.WriteLine($"Hunger level: {newCat.Hunger}");

            while (newCat.Hunger != 1)
            {
                newCat.Sleep();
            }
            Console.WriteLine($"Hunger level: {newCat.Hunger}");
            newCat.Meow();
        }
    }
}
