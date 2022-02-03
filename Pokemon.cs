namespace PokemonObjectsAndStuff
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strenght { get; set; }

        public Pokemon()
        {
            Health = 50;
        }
        public void Attack(Pokemon enemyPokemon)
        {

        }
        public void Flee()
        {

        }
    }
}