using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.Animals
{
    class Animals
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            while (input != "I'm your Huckleberry")
            {
                string[] tokens = input
                                  .Split(' ')
                                  .ToArray();
                string type = tokens[0];
                
                if (type == "talk")
                {
                    string name = tokens[1];
                    if (dogs.ContainsKey(name))
                    {
                        dogs[name].ProduceSound();
                    }
                    else if (cats.ContainsKey(name))
                    {
                        cats[name].ProduceSound();
                    }
                    else
                    {
                        snakes[name].ProduceSound();
                    }
                }
                else
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    int parameters = int.Parse(tokens[3]);

                    if (type == "Dog")
                    {
                        dogs.Add(name, new Dog(name, age, parameters));
                    }
                    else if (type == "Cat")
                    {
                        cats.Add(name, new Cat(name, age, parameters));
                    }
                    else // type == "Snake"
                    {
                        snakes.Add(name, new Snake(name, age, parameters));
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var dog in dogs)
            {
                Dog currDog = dog.Value;
                Console.WriteLine($"Dog: {currDog.Name}, Age: {currDog.Age}, Number Of Legs: {currDog.NumberOfLegs}");
            }
            foreach (var cat in cats)
            {
                Cat currCat = cat.Value;
                Console.WriteLine($"Cat: {currCat.Name}, Age: {currCat.Age}, IQ: {currCat.IntelligenceQontient}");
            }
            foreach (var snake in snakes)
            {
                Snake currSnake = snake.Value;
                Console.WriteLine($"Snake: {currSnake.Name}, Age: {currSnake.Age}, Cruelty: {currSnake.CrueltyCoefficient}");
            }
        }
        class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int NumberOfLegs { get; set; }

            public Dog(string name, int age, int numberOfLegs)
            {
                this.Name = name;
                this.Age = age;
                this.NumberOfLegs = numberOfLegs;
            }
            public void ProduceSound()
            {
                Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
            }
        }

        class Cat
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int IntelligenceQontient { get; set; }

            public Cat(string name, int age, int intelligenceQontient)
            {
                this.Name = name;
                this.Age = age;
                this.IntelligenceQontient = intelligenceQontient;
            }
            public void ProduceSound()
            {
                Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
            }

        }
        class Snake
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int CrueltyCoefficient { get; set; }

            public Snake(string name, int age, int crueltyCoefficient)
            {
                this.Name = name;
                this.Age = age;
                this.CrueltyCoefficient = crueltyCoefficient;
            }
            public void ProduceSound()
            {
                Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
            }
        }
    }
}
