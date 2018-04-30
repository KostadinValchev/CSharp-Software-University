namespace TseamAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var games = Console.ReadLine().Split().ToList<string>();
            var items = new Dictionary<string, string>();

            string input = "";
            while ((input = Console.ReadLine()) != "Play!")
            {
                var tokens = input.Split().ToList();
                var command = tokens[0];
                var game = tokens[1];
                switch (command)
                {
                    case "Install":
                        if (!games.Contains(game))
                        {
                            games.Add(game);
                        }
                        break;
                    case "Uninstall":
                        if (games.Contains(game))
                        {
                            games.Remove(game);
                        }
                        break;
                    case "Update":
                        if (games.Contains(game))
                        {
                            games.Remove(game);
                            games.Add(game);
                        }
                        break;
                    case "Expansion":
                        var item = game.Split('-');
                        string gameName = item[0];
                        string expansion = item[1];

                        for (int i = 0; i < games.Count; i++)
                        {
                            if (games[i].Contains(gameName))
                            {
                                games.Insert(i + 1, $"{gameName}:{expansion}");
                                break;
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(' ', games));
        }
    }
}
