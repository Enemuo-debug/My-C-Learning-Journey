// This is a code that exposes Object Oriented Programming in the Anmal Kingdom

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public abstract class Animal
    {
        public bool E_MR_NIGER_D = true;
        public string Name 
        {
            get; set;
        }
    }
    public class Vertebrate: Animal
    {
        private bool HasBackBone = true;
        private string Kind;
        private string Property;
        public void AboutAnimal()
        {
            Console.WriteLine($"{this .Kind} -> {this.Property}");
        }
        private static System.Collections.Generic.Dictionary <string, string> Vertebrates = new System.Collections.Generic.Dictionary <string, string> 
        {
            {
                "Lion", "This is the King of the Jungle"
            },
            {
                "Human-Being", "Commonly referred to as HOMO-SAPIEN and is the smartest vertebrate"
            },
            {
                "Gorrila", "Has similar properties with the HUMAN BEING except for its smartness"
            }
        };
        public Vertebrate()
        {
            Random index = new Random();
            List<string> MyList = new List<string>();
            foreach (string item in Vertebrates.Keys)
            {
                MyList.Add(item);
            }
            int key = index.Next(MyList.Count);
            this.Kind = MyList[key];
            this.Property = Vertebrates[MyList[key]];
        }
        public static void AddAnAnimal (string key, string value)
        {
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
        {
            Vertebrates.Add(key, value);
        }
        else
        {
            Console.WriteLine("Invalid Inputs");
        }

        }
    }
    public static void Main(string[] args)
    {
        Vertebrate animalOne = new Vertebrate();
        animalOne.AboutAnimal();
        string key = "Elephant";
        string value = "The biggest if not fattest in the Kingdom. Lion use them as food";
        Vertebrate.AddAnAnimal(key, value);
        Vertebrate animalTwo = new Vertebrate();
        animalTwo.AboutAnimal();
        Vertebrate animalThree = new Vertebrate();
        animalThree.AboutAnimal();
    }
}
