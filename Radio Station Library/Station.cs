using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_Station_Library
{
    public class Station
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        static Dictionary<Guid, Station> Stations = new Dictionary<Guid, Station>();

        public Guid Id { get; set; }

        public string Name { get; set; }

        public StationState State { get; set; }

        public Station()
        {
            this.Name = string.Empty;
            this.Id = Guid.NewGuid();
            this.State = StationState.Ready;
        }

        public Station(string name)
        {
            this.Name = name;
            this.Id = Guid.NewGuid();
            this.State = StationState.Ready;
        }
        
        public override string ToString()
        {
            return this.Name + this.State.ToString();
        }

        public enum StationState
        {
            Ready, Off
        }
    }
}
