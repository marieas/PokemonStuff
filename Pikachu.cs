using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonObjectsAndStuff
{
    class Pikachu : Pokemon
    {
        public Pikachu()
        {
            this.Name = "Pikachu";
        }

        public void LightningAttack(Pokemon enemy)
        {
            Attack(enemy);
        }
    }
}
