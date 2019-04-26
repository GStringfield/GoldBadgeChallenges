using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ChallengeRepository
{
    public class MenuRepository
    {
        List<Meal> _menu = new List<Meal>();
      

        public void AddItemToMenu(Meal meal)
        {
            _menu.Add(meal);
        }

        public List<Meal> GetListOfMeals()
        {
            return _menu;
        }

        public void RemoveMealFromMenu(int itemID)
        {
            foreach (Meal item in _menu)
            {
                bool removed = false;
                if (item.MealNumber == itemID)
                {
                    removed = true;
                    _menu.Remove(item);
                    break;
                }


            }

           
        }


        



    }
}
