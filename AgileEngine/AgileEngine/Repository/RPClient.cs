using AgileEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileEngine.Repository
{
    public class RPClient
    {
        public static List<Client> _lstClients = new List<Client>() {
            new Client() { Id= 0, Name="Oscar", LastName="Robles" }
        };

        public IEnumerable<Client> getClients() {
            return _lstClients;
        }

        public void AddNewClient(Client newC) {
            _lstClients.Add(newC);
        }
    }
}
