using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Radio_Station_Library
{
    public class VoicePlaying : Connection
    {
        MusicPlayer mp = new MusicPlayer();        
            
        public override void Connect(Station station, Client client)
        {
            this.mp.Stop();
        }

        public override string ToString()
        {
            return GetType().ToString();
        }
    }
}
