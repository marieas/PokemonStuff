using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonObjectsAndStuff
{
    public class Player
    { 
        public string Name { get; set; }
        public int Pokeball { get; set; }
        public Pokemon StarterPokemon { get; set; }
        public List<Pokemon> PokemonInventory { get; set; }
        Random random = new Random();

        public Player()
        {
            Pokeball = 10;
        }

        public void WalkInGrass(Pokemon randomPokemon)
        {
            Console.WriteLine($"You encountered: {randomPokemon.Name} do you wish to attack? Y/N");
            var response = Console.ReadLine();

            if(response == "Y")
            {
                AttackPokemon(randomPokemon);
            }
            else
            {
                TryCatchPokemon(randomPokemon);
            }
        }

        public void AttackPokemon(Pokemon enemy)
        {
            StarterPokemon.Attack(enemy);
            Console.WriteLine($"{StarterPokemon.Name} attacked {enemy.Name} with {StarterPokemon.Strenght} damage");
        }
        public void TryCatchPokemon(Pokemon pokemonToCatch)
        {       
            while (Pokeball > 0)
            {
                var isSuccessFull = Convert.ToBoolean(random.Next(0, 2));
                Console.WriteLine($"You caught {pokemonToCatch.Name}");
                if (isSuccessFull == true)
                {
                    PokemonInventory.Add(pokemonToCatch);
                    break;
                }
                else
                {
                    Pokeball--;
                }
            }
        }

    }
}
