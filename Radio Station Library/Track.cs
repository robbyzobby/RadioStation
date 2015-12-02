using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_Station_Library
{
    public class Track
    {
        public static Dictionary<Guid, Client> Tracks = new Dictionary<Guid, Client>();

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }

        public string Path { private get; set; }

         public Track()
        {
            this.Path = string.Empty;
            this.Title = string.Empty;
            this.Artist = string.Empty;
            this.Id = Guid.NewGuid();
        }

         public Track(string title, string artist, string path)
        {
            this.Path = path;
            this.Title = title;
            this.Artist = artist;
            this.Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return this.Title + this.Artist;
        }
    }
}
