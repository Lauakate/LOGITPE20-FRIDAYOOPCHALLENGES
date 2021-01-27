using System;

namespace FridayOOPChallenges2
{
    class Program
    {
        class Pet
        {
            string name;
            double age;
            double weight;
            int lifespan;

            public Pet(string _name, double _weight)
            {
                name = _name;
                weight = 0;
                age = 0;
                lifespan = 0;

            }
            public string Name
            {
                get { return Name; }
            }

            public int Age
            {
                get { return Age; }
            }

            public double Weight
            {
                get { return weight; }
            }

            public int Lifespan
            {
                get { return lifespan; }
            }
            public void PetInfo()
            {
                Console.WriteLine($"Name: {name} Age: {age}");
            }

            public void Lifespan1()
            {
                Console.WriteLine($"Lifespan: {lifespan}");
            }

            public void Weight1()
            {
                Console.WriteLine($"Lifespan: {weight}");
            }

            public void Eat()
            {
                weight += 0.2;
                Console.WriteLine($"{name} munches!");
            }

            public void Exercise()
            {
                weight -= 0.1;
                Console.WriteLine($"{name} exercises!");
            }
        }

        static void Main(string[] args)
        {
            Pet Hamster = new Pet("Hammy", 0);

            for (int i = 0; i < 11; i++)
            {
                if (Hamster.Weight > 0.7)
                {
                    Hamster.Exercise();
                    Console.WriteLine($"Hammy exercises!");
                }
                else
                {
                    Hamster.Eat();

                }

            }

            Console.WriteLine("Hammy has passed away! :(");
        }
    }
}
