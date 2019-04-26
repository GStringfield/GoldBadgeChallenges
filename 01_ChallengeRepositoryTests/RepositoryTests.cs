using System;
using System.Collections.Generic;
using _01_ChallengeRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_ChallengeRepositoryTests
{
    [TestClass]
    public class RepositoryTests
    {
        [TestMethod]
        public void AddItemToMenuTest()
        {
            MenuRepository menuRepo = new MenuRepository();
            Meal meal = new Meal(MenuType.Lunch, "Hamburger", 3, "Delicious ground up cow", "Meat and bread", 6.99m);


            menuRepo.AddItemToMenu(meal);
            List<Meal> listofmeals = menuRepo.GetListOfMeals();

            int actual = listofmeals.Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(listofmeals.Contains(meal));

        }


        [TestMethod]
        public void RemoveMealFromMenu()
        {
            MenuRepository menuRepo = new MenuRepository();
            Meal meal = new Meal(MenuType.Lunch, "Hamburger", 3, "Delicious ground up cow", "Meat and bread", 6.99m);

            Meal mealTwo = new Meal();

            menuRepo.AddItemToMenu(meal);
            menuRepo.AddItemToMenu(mealTwo);

            menuRepo.RemoveMealFromMenu(3);

            int actual = menuRepo.GetListOfMeals().Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
    }
}
