using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    public class Client
    {
        public int ClientNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClientType {get; set; }
        public string Email { get; set; }
        public Client() { }
        public Client(int clientNum, string firstName, string lastName, string clientType, string email)
        {
            ClientNum = clientNum;
            FirstName = firstName;
            LastName = lastName;
            ClientType = clientType;
            Email = email;
        }
    }
}
