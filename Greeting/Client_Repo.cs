using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Client_Repo
    {
        //helper and instantation
        public Client GetClientByNumber(int clientNumber)
        {
            foreach (Client client in _clients)
            {
                if (client.ClientNum==clientNumber)
                {
                    return client;
                }
            }
            return null;
        }
        private List<Client> _clients = new List<Client>();
        //create 
        public void AddNewClient(Client client)
        {
            _clients.Add(client);

        }

        //read
        public List<Client>GetClient()
        {
            return _clients;

        }

        //update
        public bool UpdateExistingClient(int originalClient, Client newClient)
        {
            Client oldClient = GetClientByNumber(originalClient);
            if (oldClient!=null)
            {
                oldClient.ClientNum = newClient.ClientNum;
                oldClient.FirstName = newClient.FirstName;
                oldClient.LastName = newClient.LastName;
                oldClient.ClientType = newClient.ClientType;
                oldClient.Email = newClient.Email;
                return true;
            }
            else
            {
                return false;
            }

        }
        //delete
        public bool DeleteExistingClient(int clientNum)
        {
            Client client = GetClientByNumber(clientNum);
            if (client==null)
            {
                return false;
            }
            int initialCount = _clients.Count;
            _clients.Remove(client);
            if (initialCount>_clients.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }
    }
}
