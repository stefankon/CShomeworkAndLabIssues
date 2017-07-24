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
            List<Characteristics> data = new List<Characteristics>();
            Dictionary<string, string> talks = new Dictionary<string, string>();

            while (input != "I'm your Huckleberry")
            {
                string[] tokens = input
                                  .Split(' ')
                                  .ToArray();

                if (tokens.Length > 2)
                {
                    string kind = tokens[0];
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    int individuality = int.Parse(tokens[2]);

                    data.Add(new Characteristics(kind, name, age, individuality));
                }
                else //talk animal
                {
                    string talk = tokens[0];
                    string animalName = tokens[1];
                   
                    if (!talks.ContainsKey(nameAnimal))
                    {
                        talks.Add(nameAnimal, talk);
                    }
                }
            }
            foreach (var pet in data)
            {
                string petKind = pet.Kind;
                string petName = pet.Name;
                int petAge = pet.Age;
                int petIdividual = pet.Individuality;

                foreach (var kvp in talks)
                {
                    string currName = kvp.Key;
                    if (true)
                    {

                    }

                    switch (currAnimal)
                    {
                        case "Dog":

                   default:
                            break;
                    }
                }

               

            }
        }
    }
    class Characteristics
    {
       public string Kind { get; set; }
       public string Name { get; set; }
       public int Age { get; set; }
       public int Individuality { get; set; }

        public Characteristics(string kind, string name, int age, int individuality)
        {
            this.Kind = kind;
            this.Name = name;
            this.Age = age;
            this.Individuality = individuality;
        }
    }
   
}
