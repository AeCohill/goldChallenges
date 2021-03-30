using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class ProgramUI
    {
        //Main menu
        private Client_Repo _clientRepo = new Client_Repo();

        public void Run()
        {
            Menu();
        }
        public void Menu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Please enter number corrisponding with your choice\n"
                    +"1: |Create a new client.....\n"+
                    "2: |Show client list........\n"+
                    "3: |Update current client...\n"+
                    "4: |Delete client...........\n"+
                    "5: |EXIT....................\n");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    //create
                    //display
                    //update
                    //deletE
                    case "1":
                        CreateNewClient();
                        break;
                    case "2":
                        DisplayClientList();
                        break;
                    case "3":
                        UpdateExistingClient();
                        break;
                    case "4":
                        DeleteClient();
                        break;
                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Please enter valid option...");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
        //Creates new client for the list
        private void CreateNewClient()
        {
            Client client = new Client();
            Console.Clear();
            
            Console.WriteLine("Enter clientnumber here:");
            client.ClientNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Firstname of Client here:");
            client.FirstName = Console.ReadLine();
            
            Console.WriteLine("Enter Lastname of Client here:");
            client.LastName = Console.ReadLine();

            Console.WriteLine("Enter type of Client here:(Active, Pending, Complete)");
            client.ClientType = Console.ReadLine().ToLower();

            bool emailSet = false;
            while (!emailSet)
            {
                if (client.ClientType == "complete")
                {
                    client.Email = "Hi there stranger!! Its been a while since weve seen you would you like to see our latest deals!?";
                    emailSet = true;
                }
                else if (client.ClientType == "active")
                {
                    client.Email = "Thank you for working with our company please accept this coupon as gratitude!!";
                    emailSet = true;
                }
                else if (client.ClientType == "pending")
                {
                    client.Email = "LEMU EMU SUCKS! COME TO KOMODO INSURANCE INSTEAD!!\n" + "DONT BE THE EMU EAT THE EMU!!!!!";
                    emailSet = true;
                }
                else
                {
                    Console.WriteLine("ENTER VALID OPTION!!!:");
                }
            }

            Console.WriteLine($"Your client type is : {client.ClientType}");
            _clientRepo.AddNewClient(client);
        }

        //shows user current client list
        private void DisplayClientList()
        {
            Console.Clear();
            List<Client> clients = _clientRepo.GetClient();

            foreach (Client client in clients)
            {
                Console.WriteLine($"Client number is: {client.ClientNum}\n" +
                    $"Clients FirstName Is:{client.FirstName}\n"+
                    $"Clients LastName Is:{client.LastName}\n" +
                    $"Clients Type Is:{client.ClientType}\n" +
                    $"Email to send to client is: {client.Email}");
            }
        }
      // updates current client list
        private void UpdateExistingClient()
        {
            DisplayClientList();

            Console.WriteLine("Enter the client number you would like to update.");
            int oldClient = Convert.ToInt32(Console.ReadLine());

            Client client = new Client();
            Console.Clear();

            Console.WriteLine("Enter clientnumber here:");
            client.ClientNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Firstname of Client here:");
            client.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Lastname of Client here:");
            client.LastName = Console.ReadLine();

            Console.WriteLine("Enter type of Client here:(Active, Pending, Complete)");
            client.ClientType = Console.ReadLine().ToLower();

            bool emailSet = false;
            while (!emailSet)
            {
                if (client.ClientType == "complete")
                {
                    client.Email = "Hi there stranger!! Its been a while since weve seen you would you like to see our latest deals!?";
                    emailSet = true;
                }
                else if (client.ClientType == "active")
                {
                    client.Email = "Thank you for working with our company please accept this coupon as gratitude!!";
                    emailSet = true;
                }
                else if (client.ClientType == "pending")
                {
                    client.Email = "LEMU EMU SUCKS! COME TO KOMODO INSURANCE INSTEAD!!\n" + "DONT BE THE EMU EAT THE EMU!!!!!";
                    emailSet = true;
                }
                else
                {
                    Console.WriteLine("ENTER VALID OPTION!!!:");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Your client type is : {client.ClientType}");
            bool wasUpdated = _clientRepo.UpdateExistingClient(oldClient, client);
            if (wasUpdated)
            {
                Console.WriteLine("Update Successful!");
            }
            else
            {
                Console.WriteLine("Please enter a valid responce.......");
            }
        }
        //deletes client from list

        private void DeleteClient()
        {
            Console.Clear();

            DisplayClientList();

            Console.WriteLine("Enter the client number that you would like to delete.");
            int responce = Convert.ToInt32(Console.ReadLine());
            bool deleted = _clientRepo.DeleteExistingClient(responce);

            if (deleted)
            {
                Console.WriteLine("You erased that client from total existance. I hope that makes you happy.");

            }
            else
            {
                Console.WriteLine("The Client is imortal and could not be deleted..... or you did something wrong.");
            }
        }
     }
}
