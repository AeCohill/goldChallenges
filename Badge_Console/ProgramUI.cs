using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges_Repo
{
    class ProgramUI
    {
        public static Badge badge = new Badge();

        public void ShowMenu()
        {
            Console.WriteLine(
                "********************************************* \n" +
                "Badge Manager Menu - Select Option by number: \n" +
                "********************************************* \n" +
                "1. View All Doors \n" +
                "2. Add a door and badge \n" +
                "3. Update a door and badge \n" +
                "4. Delete a badge and door \n" +
                "5. Exit \n" +
                "*********************************************");
        }

        public void DisplayDoorsAndBadges()
        {
            var doors = GetAllBadgesDoors();
            doors = GetAllBadgesDoors();

            if (doors.Count > 0)
            {
                foreach (var item in doors)
                {
                    Console.WriteLine("BadgeID: " + item.Key.ToString() + "  |  " + "Door: " + item.Value.ToString());
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No Door/Badges Found!");
                Console.ReadLine();
                Program.Main(null);
            }
        }

        public List<KeyValuePair<int, string>> GetAllBadgesDoors()
        {
            if (badge.badgeDict == null)
            {
                badge.badgeDict = new Dictionary<int, string>();
            }

            List<KeyValuePair<int, string>> badgesList = badge.badgeDict.ToList();

            return badgesList;
        }

        public void AddBadgesDoors()
        {
            if (badge.badgeDict == null)
            {
                badge.badgeDict = new Dictionary<int, string>();
            }

            Console.WriteLine("Add a badge ID: ");
            string idInput = Console.ReadLine();

            Console.WriteLine("Add a door name: ");
            string doorInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(idInput))
            {
                badge.badgeDict.Add(Convert.ToInt32(idInput), doorInput);
            }

            DisplayDoorsAndBadges();
            Console.ReadLine();
            Program.Main(null);
        }

        public void UpdateBadgesDoors()
        {
            DisplayDoorsAndBadges();

            Console.WriteLine("Update access by badge ID. Enter ID from above list: ");
            string idInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(idInput) && badge.badgeDict.ContainsKey(Convert.ToInt32(idInput)))
            {
                Console.WriteLine("Edit the door name: ");
                string doorInput = Console.ReadLine();

                badge.badgeDict[Convert.ToInt32(idInput)] = doorInput;
            }
            else
            {
                Console.WriteLine("Badge not found!: ");
            }

            DisplayDoorsAndBadges();
            Console.ReadLine();
            Program.Main(null);
        }

        public void DeleteBadgesDoors()
        {
            DisplayDoorsAndBadges();

            Console.WriteLine("Delete access by badge ID. Enter ID from above list: ");
            string idInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(idInput) && badge.badgeDict.ContainsKey(Convert.ToInt32(idInput)))
            {
                badge.badgeDict.Remove(Convert.ToInt32(idInput));
            }
            else
            {
                Console.WriteLine("Badge not found!: ");
            }

            DisplayDoorsAndBadges();
            Console.ReadLine();
            Program.Main(null);
        }
    }
}
