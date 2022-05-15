using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_excersises
{
    class Animal
    {
        private string name;
        private string sound;
        public Animal(string name, string sound)
        {
            this.name = name;
            this.sound = sound;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{name} wydaje dzwięk {sound}");
        }
    }
}
