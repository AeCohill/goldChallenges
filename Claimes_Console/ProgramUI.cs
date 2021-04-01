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
            {;

                Console.WriteLine(
                    "*************************************************\n"+
                    "NOTE: YOU MUST CREATE A NEW CLAIM TO VIEW LIST!!!\n"+
                    "Enter the number corrisponding to your choice....\n"+
                    "1: See all current claims........................\n"+
                    "2: Process next claim............................\n"+
                    "3: Create a new claim............................\n"+
                    "4: EXIT!.........................................\n"+
                    "*************************************************");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        SeeClaims();
                        break;
                    case "2":
                        NextClaim();
                        break;
                    case "3":
                        NewClaim();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }
                Console.WriteLine("Press any Keyto continue.........");
                Console.ReadKey();
                Console.Clear();
            }
        }private void SeeClaims()
        {
            Console.Clear();

            Queue<Claim> claims = _claims.GetQueue();

            foreach (Claim claim in claims)
            {
                Console.WriteLine(
                    $"Claim ID: {claim.ClaimNum}...\n"+
                    $"Description: {claim.Description}...\n"+
                    $"Date of Claim: {claim.DateOfClaim}...\n"+
                    $"Date of Incident: {claim.ReportDate}...\n"+
                    $"Is Claim Valid: {claim.IsTrue}...\n"+
                    $"Amount Paid: {claim.ClaimPrice}...\n"+
                    "************************************");
            }
        } 
        private void NewClaim()
        {
            Claim claim = new Claim();
            Console.Clear();

            Console.WriteLine("************************\n"
                +"Enter Claim Number.\n"+ 
                "****************************");
            claim.ClaimNum = Console.ReadLine();

            Console.WriteLine("*****************************************\n"+
                "Enter the claim type.......................\n"+
                "*****************************************");
            claim.ClaimType = Console.ReadLine();

            Console.WriteLine("*****************************************\n"+
                "Enter the description of the claim.........\n"+
                "*****************************************");
            claim.Description = Console.ReadLine();

            Console.WriteLine("*****************************************\n"+
                "Enter the date the incident took place.....\n"+
                "*****************************************");
            claim.ReportDate = Console.ReadLine();

            Console.WriteLine($"*****************************************\n"+
                "Enter the date the customer made the claim.\n" +
                "****************************************");
            claim.DateOfClaim = Console.ReadLine();

            Console.WriteLine($"*****************************************\n"+
                "Enter the amount paid for the claim........\n"+
                "***************************************");

            string conversion = Console.ReadLine();
            claim.ClaimPrice = decimal.Parse(conversion);

            bool isFalse = false;
            while (isFalse == false)
            {
                Console.WriteLine($"********************************\n"+
                    "Is your selected claim valid? Enter 'yes or no'\n"+
                    "***********************************");
                string answer = Console.ReadLine().ToLower();
                if (answer=="yes")
                {
                    claim.IsTrue = true;
                    isFalse = true;
                }
                else if (answer=="no")
                {
                    claim.IsTrue = false;
                    isFalse = true;
                }
                else
                {
                    Console.WriteLine($"***************************************\n"+
                        "Please enter a valid responce 'YES or NO'\n"+
                        "***************************************");
                }
            }
           

            _claims.CreateNew(claim);
        }
        private void NextClaim()
        {
            Console.Clear();

            Console.WriteLine($"*****************************************\n"+
                "Here is the next claim to be handled!\n"+
                "*****************************************");

            _claims.GetQueue();

            Console.WriteLine($"*****************************************\n"+
                "Do you want to deal with this claim now(yes/no)?\n"+
                "*****************************************");
            string answer = Console.ReadLine();
            bool validResponse = false;
            while (validResponse == false)
            {
                if (answer == "yes")
                {
                    _claims.DeQueueNext();
                }
                else if (answer == "no")
                {
                    Console.Clear();
                    Menu();
                }
                else
                {
                    Console.WriteLine("******************\n"+
                        "Please enter y or n\n"+
                        "********************");
                }
                validResponse = true;
               
            }
        }
    }
}


