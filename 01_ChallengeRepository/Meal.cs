using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ChallengeRepository
{
    public enum MenuType
    {
        Breakfast =1, Lunch, Dinner
    }
    
    public class Meal
    {
        public MenuType MenuType { get; set; }
        public string MealName { get; set; }
        public int MealNumber { get; set; }
        public string MealDescription { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }

        public Meal(MenuType menuType, string mealName, int mealNumber, string mealDescription, string ingredients, decimal price)
        {

            MenuType = menuType;
            MealName = mealName;
            MealNumber = mealNumber;
            MealDescription = mealDescription;
            Ingredients = ingredients;
            Price = price;

        }

        public Meal()
        {

        }




    }
}
