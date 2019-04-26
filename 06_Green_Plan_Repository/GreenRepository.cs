using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Green_Plan_Repository
{
    public class GreenRepository
    {
        List<Car> _cars = new List<Car>();

        public void AddCarToList(Car car)
        {
            _cars.Add(car);
        }


        public List<Car> SeeAllCarsOnList()
        {
            return _cars;
        }
     
     
        public void RemoveCarFromList(int itemID)
        {
            foreach (Car item in _cars)
            {
                bool removed = false;
                if (item.CarID == itemID)
                {
                    removed = true;
                    _cars.Remove(item);
                    break;
                }

            }


        }
    }
}
