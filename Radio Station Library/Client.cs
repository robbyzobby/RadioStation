using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio_Station_Library
{
    public class Client
    {
        public static Dictionary<Guid, Client> Clients = new Dictionary<Guid, Client>();

        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Port { get; set; }

        public string Email { get; set; }
                
        public ClientState State { get; set; }

        public Client()
        {
            this.Name = string.Empty;
            this.Port = 0;
            this.Id = Guid.NewGuid();
            this.State = ClientState.Online;
        }

        public Client(string name, int port)
        {
            this.Name = name;
            this.Id = Guid.NewGuid();
            this.Port = port;
            this.State = ClientState.Online;
        }

        public override string ToString()
        {
            return this.Port + " " + this.Name + this.State.ToString();
        }

        public enum ClientState
        {
            Online, Offline
        }
    }
}
