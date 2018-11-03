using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cthing
{
    class Animal
    {
    
        private string name;
        protected string sound;

        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the id of {animalIDInfo.IDNum} and is owned by {animalIDInfo.Owner}");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal()
            : this("No Name", "No Sound") { }  //Default constructor with no argumnent added

        public Animal(string name)
            : this(name, "No sound") { }  //Default constructor with 1 argument added

        public Animal(string name, string sound) //Constructor with all argument added
        {
            Name = name;
            Sound = sound;
        }

        public string Name    //Getter and setter for Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    this.name = "No Name";
                }
                this.name = value;
            }
        }

        public string Sound  //getter and setter for Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    this.sound = "No Sound";
                }
                this.sound = value;
            }
        }

        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;

                if ((calc >= .18 && (calc <= .28)))
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
