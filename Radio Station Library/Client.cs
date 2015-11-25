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
        public  string Email { get; set; }
        public string Password { private get; set; }
        
        public ClientState State { get; set; }
        public Client()
        {
            Name = String.Empty;
            Port = 0;
            Id = Guid.NewGuid();
            State = ClientState.Online;
        }

        public Client(string name, int port)
        {
            Id = Guid.NewGuid();
            Port = port;
             State = ClientState.Online;
        }

        public override string ToString()
        {
            return Port + " " + Name + State.ToString();
        }

        public enum ClientState
        {
            Online, Offline
        }
    }
}
