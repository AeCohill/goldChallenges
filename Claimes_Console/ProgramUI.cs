using Claims_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claimes_Console
{
    class ProgramUI
    {
        private Claim_Repo _claims = new Claim_Repo();

        public void Run()
        {
            Menu();
        }
        public void Menu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine(
                    "*************************************************\n"+
                    "Enter the number corrisponding to your choice....\n"+
                    "1: See all current claims........................\n"+
                    "2: Process next claim............................\n"+
                    "3: Create a new claim............................\n"+
                    "4: EXIT!.........................................\n"+
                    "*************************************************");
            }
        }
    }
}
