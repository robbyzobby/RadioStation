using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;

namespace Radio_Station_Library
{
     public class MusicPlaying : Connection
    {
         MusicPlayer mp = new MusicPlayer();        
            
       public override void Connect(Station station, Client client)
        {
            this.mp.Open(Directory.GetCurrentDirectory() +  "/Intro.mp3" );
            this.mp.Play();
        }
        
        public override string ToString()
        {
            return GetType().ToString();
        }
    }
}