using System;

namespace PokemonObjectsAndStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            var game  = new GamePlay(player);
        }
    }
}
