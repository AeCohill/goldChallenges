using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Badges;

namespace Badges
{
    public class Program
    {
        public static BadgeRepo repo = new BadgeRepo();
        public static void Main(string[] args)
        {
            repo.ShowMenu();
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                // Get
                if (Convert.ToInt32(input) == 1)  
                {
                    repo.DisplayDoorsAndBadges();
                }

                // Add
                if (Convert.ToInt32(input) == 2) 
                {
                    repo.AddBadgesDoors();
                }

                // Update
                if (Convert.ToInt32(input) == 3) 
                {
                    repo.UpdateBadgesDoors();
                }

                // Delete
                if (Convert.ToInt32(input) == 4) 
                {
                    repo.DeleteBadgesDoors();
                }

                // Exit
                if (Convert.ToInt32(input) == 5) 
                {
                    Console.Clear();
                }
            }
        }
    }
}
