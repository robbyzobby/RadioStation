using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_Station_Library
{
    public class Context
    {
        Connection connection;

        Client firstclient = new Client("John", 2);

        Station mystation = new Station("Africa");
        
        public Context(Connection connection)
        {
            this.connection = connection;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tutn")]
        public void TutnOn()
        {
            this.connection.Connect(this.mystation, this.firstclient);
        }
    }
}
