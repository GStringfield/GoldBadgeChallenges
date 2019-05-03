using _04_BadgeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Badge
{
    public class ProgramUI
    {
        private BadgeRepository _badgeRepo = new BadgeRepository();


        public void Run()
        {

            RunMenu();

        }

        private void RunMenu()
        {

            bool running = true;
            while (running)
            {

                Console.WriteLine("Hello Security Admin, What would you like to do\n" +
                            "1. Add a badge\n" +
                            "2. Edit a badge.\n" +
                            "3. List all Badges\n" +
                            "4. Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateAndAddABadge();
                        break;
                    case "2":
                        EditABadge();
                        break;
                    case "3":
                        ListAllBadges();
                        break;
                    case "4":
                        running = false;
                        break;
                }

            }

        }

        public void CreateAndAddABadge()
        {
            string addMoreDoors = "y";

            List<string> _doorList = new List<string>();

            Console.WriteLine("Please enter the a badge number.");
            int badgeID = int.Parse(Console.ReadLine());

            while (addMoreDoors.Contains("y"))
            {
                Console.WriteLine("Enter a door the bage needs access to:");
                _doorList.Add(Console.ReadLine());
                Console.WriteLine("Are there any other doors you would like to add at this time? (y/n)");
                addMoreDoors = Console.ReadLine().ToLower();
            }

            Badge newBadgeID = new Badge(badgeID, _doorList);
            _badgeRepo.AddBadgeToDictionary(newBadgeID);
        }
        public void EditABadge()
        {
            List<string> _doorList = new List<string>();

            Console.WriteLine("What is the number of the badge you would like to update?");
            int badgeID = int.Parse(Console.ReadLine());
            Console.WriteLine($"{badgeID} has access to doors:");

            foreach (string door in _badgeRepo.GetAllBadges()[badgeID])
            {
                Console.WriteLine(door);
            }
                Console.WriteLine("What would you like to do?\n" +
                "1. Remove a door.\n" +
                "2. Add a door.");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Which door would you like to remove?");
                    string doorInput = Console.ReadLine();
                    foreach (var door in _badgeRepo.GetAllBadges()[badgeID])
                    {
                        if (doorInput == door)
                        {
                            _doorList.Remove(door);
                            break;
                        }
                    }
                    break;

                case "2":
                    Console.WriteLine("What door would you like to this badge?");
                    _doorList.Add(Console.ReadLine());
                    break;
                default:
                    break;


            }
        }

             public void ListAllBadges()
            {
           

            foreach (KeyValuePair<int, List<string>> badgeItem in _badgeRepo.GetAllBadges())
            {
                Console.Write($"{badgeItem.Key}");
                //{ badgeItem.Value.ToString() }")
                    foreach (string door in badgeItem.Value)
                {
                    Console.Write(" " + door);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

     
           

        




    }
}
