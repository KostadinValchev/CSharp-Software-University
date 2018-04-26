using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Radio_Database
{
    public class Song
    {
        private string artistName;
        private string songName;
        private int songMinutes;
        private int songSeconds;

        public Song(string artistName, string songName, string time)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Time = time;
        }

        private string Time
        {
            set
            {
                var minAndSec = value.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int min;
                int sec;

                if (minAndSec.Length != 2)
                {
                    throw new InvalidSongLengthException();
                }

                var isMinute = int.TryParse(minAndSec[0], out min);
                var isSecond = int.TryParse(minAndSec[1], out sec);
                if (!isSecond || !isMinute)
                {
                    throw new InvalidSongLengthException();
                }

                this.SongMinutes = min;
                this.SongSeconds = sec;
            }
        }

        private int SongSeconds
        {
            get
            {
                return this.songSeconds;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                this.songSeconds = value;
            }
        }

        private int SongMinutes
        {
            get
            {
                return this.songMinutes;
            }
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                this.songMinutes = value;
            }
        }

        private string SongName
        {
            get { return this.songName; }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }
                this.songName = value;
            }
        }

        private string ArtistName
        {
            get { return this.artistName; }
            set
            {

                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                this.artistName = value;
            }
        }
        public int GetLenghtInSeconds()
        {
            return this.SongMinutes * 60 + this.SongSeconds;
        }
    }
}
