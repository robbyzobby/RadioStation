using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_Station_Library
{
    public class Station
    {
        public static Dictionary<Guid, Station> Stations = new Dictionary<Guid, Station>();
        public Guid Id { get; set; }
        public string Name { get; set; }
        public StationState State { get; set; }
        public Station()
        {
            Name = String.Empty;
            Id = Guid.NewGuid();
            State = StationState.Ready;
        }

        public Station(string name)
        {
            Id = Guid.NewGuid();
            State = StationState.Ready;
        }

        public override string ToString()
        {
            return  Name + State.ToString();
        }

        public enum StationState
        {
            Ready, Off
        }
    }
}
