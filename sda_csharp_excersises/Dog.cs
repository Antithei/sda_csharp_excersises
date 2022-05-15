using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_excersises
{
    class Dog : Animal
    {
        private const string DOG_SOUND = "Woof";

        public Dog(string name) : base(name, DOG_SOUND) { }
    }
}
