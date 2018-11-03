using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cthing
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "grrr"
            };

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();



            whiskers.SetAnimalIDInfo(12345, "Pop Cristi");
            grover.SetAnimalIDInfo(321, "Gica IOn");

            whiskers.MakeSound();
            grover.MakeSound();
            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 46));


            Console.ReadLine();
        }
    }
}
