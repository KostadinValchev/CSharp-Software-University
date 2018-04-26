namespace Online_Radio_Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
       public static void Main()
        {
            var songsCount = int.Parse(Console.ReadLine());
            var songs = new List<Song>();
            for (int i = 0; i < songsCount; i++)
            {
                // ^(.*?);(.*?);((1[0-4])|([0-9])):([0-5]?[0-9])$
                try
                {
                    var songData = Console.ReadLine();

                    var regex = @"^(.*?);(.*?);((.*?):(.*?))$";

                    var match = Regex.Match(songData, regex);

                    var artist = match.Groups[1].ToString();
                    var name = match.Groups[2].ToString();
                    var time = match.Groups[3].ToString();
                    var song = new Song(artist, name, time);
                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ise)
                {
                    Console.WriteLine(ise.Message);
                }
            }

            var totalDuration = songs.Sum(x => x.GetLenghtInSeconds());
            Console.WriteLine($"Songs added: {songs.Count}");
            Console.WriteLine($"Playlist length: {totalDuration / 3600}h {totalDuration / 60 % 60}m {totalDuration % 60}s");
        }
    }
}
