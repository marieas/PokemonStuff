using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonObjectsAndStuff
{
    class Meowth : Pokemon
    {
        public Meowth()
        {
            this.Name = "Bjørnar";
        }

        public void Scratch(Pokemon enemy)
        {
            Attack(enemy);
        }
    }
}
