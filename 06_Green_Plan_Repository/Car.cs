using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Green_Plan_Repository
{
    public enum CarType
    {
        Electric = 1, Hybrid, Gas
    }

    public class Car
    {
        public CarType CarType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int YearofCar { get; set; }
        public int NumberofDoors { get; set; }
        public int CarID { get; set; }



        public Car(CarType carType, string make, string model,int yearofCar, int numberofDoors, int carID)
        {
            CarType = carType;
            Make = make;
            Model = model;
            YearofCar = yearofCar;
            NumberofDoors = numberofDoors;
            CarID = carID;
         
        }


        public Car()
        {

        }

    }


}
