namespace MOBAChallenger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var players = new Dictionary<string, Player>();

            string input;
            while ((input = Console.ReadLine()) != "Season end")
            {
                var items = input.Split("->").ToArray();
                if (items.Length == 3)
                {
                    string name = items[0].Trim();
                    string position = items[1].Trim();
                    int skill = int.Parse(items[2]);
                    if (!players.Keys.Contains(name))
                    {
                        var player = new Player(name);
                        player.position.Add(position, skill);
                        players.Add(name, player);
                    }
                    else
                    {
                        if (!players[name].position.Keys.Contains(position))
                        {
                            players[name].position.Add(position, skill);
                        }
                        else if(players[name].position[position] < skill)
                        {
                            players[name].position[position] = skill;
                        }
                    }
                }
                else
                {
                    var playerItems = input.Split(new[] { " ", "vs" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string firstPlayerName = playerItems[0];
                    string secondPlayerName = playerItems[1];

                    if (players.ContainsKey(firstPlayerName) && players.ContainsKey(secondPlayerName))
                    {
                        var playerOne = players.FirstOrDefault(n => n.Key == firstPlayerName).Value;
                        var playerTwo = players.FirstOrDefault(n => n.Key == secondPlayerName).Value;

                        int playerOneSumAllSkills = playerOne.position.Values.Sum();
                        int playerTwoSumAllSkills = playerTwo.position.Values.Sum();

                        if (playerOneSumAllSkills != playerTwoSumAllSkills)
                        {
                            foreach (var pos in playerOne.position)
                            {
                                if (playerTwo.position.ContainsKey(pos.Key))
                                {
                                    int playerTwoSkillPoint = playerTwo.position[pos.Key];
                                    if (playerOneSumAllSkills > playerTwoSumAllSkills)
                                    {
                                        players.Remove(secondPlayerName);
                                    }
                                    else if (playerOneSumAllSkills < playerTwoSumAllSkills)
                                    {
                                        players.Remove(firstPlayerName);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            var sortedPlayers = players.OrderByDescending(s => s.Value.SumSkils()).ThenBy(n => n.Key);

            foreach (var player in sortedPlayers)
            {
                Console.WriteLine(player.Value);
            }
        }
    }
    public class Player
    {
        public string name;
        public Dictionary<string, int> position;

        public Player(string name)
        {
            this.name = name;
            this.position = new Dictionary<string, int>();
        }

        public int SumSkils()
        {
            int sum = 0;
            foreach (var item in this.position)
            {
                sum += item.Value;
            }
            return sum;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            string name = this.name;
            int sumSkils = this.SumSkils();
            sb.AppendLine($@"{name}: {sumSkils} skill");
            foreach (var item in this.position.OrderByDescending(s => s.Value).ThenBy(n => n.Key))
            {
                sb.AppendLine($"- {item.Key} <::> {item.Value}");
            }
            return sb.ToString().Trim();
        }
    }
}
