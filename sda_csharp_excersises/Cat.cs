using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_excersises
{
    class Cat : Animal
    {
        private const string CAT_SOUND = "Miau";

        public Cat(string name) : base(name, CAT_SOUND) { }
    }
}

