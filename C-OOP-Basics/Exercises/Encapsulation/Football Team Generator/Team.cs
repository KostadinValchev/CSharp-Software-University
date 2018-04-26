namespace Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private double rating;
        private string name;

        public Team(string name)
        {
            this.Name = name;
            this.Players = new List<Player>();
        }

        private List<Player> Players { get; set; }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public double Rating
        {
            get { return this.rating; }
            set
            {
                var average = (this.Players.Sum(p => p.Dribble) + this.Players.Sum(p => p.Endurance) +
                               this.Players.Sum(p => p.Passing) + this.Players.Sum(p => p.Shooting) +
                               this.Players.Sum(p => p.Sprint)) / 5.0;
                this.rating = Math.Round(average);
            }
        }

        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
            this.Rating = this.rating;
        }

        public void RemovePlayer(string playerName)
        {
            if (this.Players.Any(p => p.Name == playerName))
            {
                var player = this.Players.FirstOrDefault(p => p.Name == playerName);
                this.Players.Remove(player);
                this.Rating = this.rating;
            }
            else
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }
        }
    }
}
