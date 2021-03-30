using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class ProgramUI
    {
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
                Console.WriteLine("What Would You Like ToDo??\n"
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
                    //delet
                    case "1":
                        CreateNewClient();
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
