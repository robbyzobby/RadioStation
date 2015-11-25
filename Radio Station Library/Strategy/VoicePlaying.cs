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
        public override void Connect(Station station, Client client)
        {
            
        }
        public override string ToString()
        {
            return GetType().ToString();
        }
    }
}
