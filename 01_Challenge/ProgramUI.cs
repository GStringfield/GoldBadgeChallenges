using _01_ChallengeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class ProgramUI
    {


        private MenuRepository _MenuRepo = new MenuRepository();

        public void Run()
        {
            Console.Clear();
            MealList();
            RunMenu();

        }

        private void RunMenu()
        {
            bool running = true;
            while (running)
            {

                Console.WriteLine("What would you like to do?\n" +
                            "1. Add a new meal to the menu\n" +
                            "2. See all menu items\n" +
                            "3. Remove a meal from the menu\n" +
                            "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateAndAddMealToMenu();
                        break;
                    case "2":
                        ShowAllMenuItems();
                        break;
                    case "3":
                        RemoveMealFromMenu();
                        break;
                    case "4":
                        running = false;
                        break;
                }

            }
        }

        public void CreateAndAddMealToMenu()
        {
           
            Console.Write("Enter the number on the badge: ");
            int badgeID = int.Parse(Console.ReadLine());

           

            Console.WriteLine("What is the description of the meal?");
            string mealDescription = Console.ReadLine();

            Console.WriteLine("What are the ingrdients in this meal?");
            string mealIndgrediants = Console.ReadLine();

            Console.WriteLine("What meal type is this?\n" +
                "1. Breakfast\n" +
                "2. Lunch\n" +
                "3. Dinner");
            string mealTypeAsString = Console.ReadLine();
            int mealTypeAsInt = int.Parse(mealTypeAsString);

            MenuType menu = (MenuType)mealTypeAsInt;

            Console.WriteLine("What is the price of the meal?");
            string mealPriceAsString = Console.ReadLine();
            decimal mealPrice = decimal.Parse(mealPriceAsString);

            // these lines are making a meal or a "crate". That is the first line the second line is sending it to the "warehouse" or repository.
            Meal newMenuItem = new Meal(menu, mealName, mealNumber, mealDescription, mealIndgrediants, mealPrice);

            _MenuRepo.AddItemToMenu(newMenuItem);

        }

        private void ShowAllMenuItems()
        {

            List<Meal> menu = _MenuRepo.GetListOfMeals();

            foreach (Meal item in menu)
            {
                Console.WriteLine($"{item.MealName} {item.MealNumber} {item.MealDescription} {item.Ingredients} {item.Price}");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }


        private void RemoveMealFromMenu()
        {
            Console.Clear();
            ShowAllMenuItems();
            

            Console.WriteLine("What is the number of the meal would you like to remove?");
            int mealNumber = ParseInput();
            Console.ReadLine();
            _MenuRepo.RemoveMealFromMenu(mealNumber);
           

        }

        private int ParseInput()
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 0|| input > 20)
            {
                Console.WriteLine("Your input was invalid, please enter a valid menu number.");
                input = ParseInput();
            }
            return input;
        }


        private void MealList()
        {
            Meal mealOne = new Meal(MenuType.Lunch, "Hamburger and Fries", 5, "Greasy food", "Ground up cow with bread and cut potatoes", 6.99m);
            Meal mealTwo = new Meal(MenuType.Breakfast, "Eggs and Bacon", 9, "Typical 1950's Breakfast", "Chicken embryos and strips of pig fat.", 5.99m);
            _MenuRepo.AddItemToMenu(mealOne);
            _MenuRepo.AddItemToMenu(mealTwo);
        }
    }
}







