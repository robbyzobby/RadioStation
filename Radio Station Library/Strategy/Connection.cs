using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Radio_Station_Library
{
    public abstract class Connection
    {
        public abstract void Connect(Station station, Client client);
       // string ToString();
    }
}
