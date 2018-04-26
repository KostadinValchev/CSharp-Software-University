namespace Pokemon_Trainer
{
    using System.Collections.Generic;

    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> listOfPokemons = new List<Pokemon>();

        public string Name { get { return this.name; } set { this.name = value; } }
        public int NumberOfBadges { get { return this.numberOfBadges; } set { this.numberOfBadges = value; } }
        public List<Pokemon> ListOfPokemons { get { return this.listOfPokemons; } set { this.listOfPokemons = value; } }
    }
}