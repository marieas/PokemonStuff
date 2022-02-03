using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonObjectsAndStuff
{
    class GamePlay
    { 
        public Player MainCharacter { get; set; }
        public List<Pokemon> WildPokemen { get; set; }
        Random randGenerator;

        public GamePlay(Player mainChar)
        {
            randGenerator = new Random();
            MainCharacter = mainChar;
            WildPokemen = new List<Pokemon>
            {
                new Pikachu(),
                new Magicarp(),
                new Meowth()
            };

            var randomPokemon = GetRandomPokemon();
            MainCharacter.WalkInGrass(randomPokemon);
        }

        public Pokemon GetRandomPokemon()
        {
            var listIndex = randGenerator.Next(0, WildPokemen.Count);
            return WildPokemen[listIndex];
        }




    }
}
