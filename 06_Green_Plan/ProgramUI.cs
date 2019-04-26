using _06_Green_Plan_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Green_Plan
{
    public class ProgramUI
    {
        private GreenRepository _greenRepo = new GreenRepository();

        public void Run()
        {
            
            SeedList();
            RunMenu();
            
        }

        private void RunMenu()
        {
            bool running = true;
            while (running)
            {

                Console.WriteLine("What would you like to do?\n" +
                            "1. Add a new car to the list\n" +
                            "2. See all the cars on the list\n" +
                            "3. See all cars By fuel type\n" +
                            "4. Update information on a car on the list\n" +
                            "5. Remove a car from the list\n" +
                            "6. Exit");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddCarToList();
                        break;
                    case "2":
                        SeeAllCarsOnList();
                        break;
                    case "3":
                        SeeAllCarsByFuelType();
                        break;
                    case "4":
                        UpdateInfoOnCar();
                        break;
                    case "5":
                        RemoveCarFromList();
                        break;
                    case "6":
                        running = false;
                        break;
                        Console.Clear();

                }

            }

        }


        public void AddCarToList()
        {
            Console.Clear();
            Console.WriteLine("What type of Car is this?\n" +
               "1. Electric \n" +
               "2. Hybrid\n" +
               "3. Gas");
            string carTypeAsString = Console.ReadLine();
            int carTypeAsInt = int.Parse(carTypeAsString);
            CarType carType = (CarType)carTypeAsInt;

            Console.WriteLine("what is the make of the car?");
            string make = Console.ReadLine();

            Console.WriteLine("What is the model of the car?");
            string model = Console.ReadLine();


            Console.WriteLine("What is the year of the car?");
            string yearOfCarAsString = Console.ReadLine();
            int yearOfCar = int.Parse(yearOfCarAsString);


            Console.WriteLine("What is the number of doors on the car?");
            string numberofDoorsAsString = Console.ReadLine();
            int numberOfDoors = int.Parse(numberofDoorsAsString);

            Console.WriteLine("What is the ID number of the car?");
            string carIDAsString = Console.ReadLine();
            int carID = int.Parse(carIDAsString);


            Car newCarItem = new Car(carType, make, model, yearOfCar, numberOfDoors, carID);

            _greenRepo.AddCarToList(newCarItem);

        }


        public void SeeAllCarsOnList()
        {
            Console.Clear();
            List<Car> list = _greenRepo.SeeAllCarsOnList();

            foreach (Car item in list)
            {
                Console.WriteLine($"{item.CarType} {item.Make} {item.Model} {item.YearofCar} {item.NumberofDoors} {item.CarID} ");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public void SeeAllCarsByFuelType()
        {
            List<Car> list = _greenRepo.SeeAllCarsOnList();

            Console.WriteLine("What kind of car would you like to view? Please enter 1, 2 or 3.\n" +
                "1. Electric\n " +
                "2. Hybrid\n " +
                "3. Gas\n ");

            var type = int.Parse(Console.ReadLine());

            foreach (Car item in list)
            {
                if (item.CarType == (CarType)type)
                {
                    Console.WriteLine($"Type: {item.CarType}{item.Make} {item.Model} {item.YearofCar} {item.NumberofDoors} {item.CarID}\n");
                }
            }
            Console.ReadLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }



        public void UpdateInfoOnCar()
        {
            // So right here you have the repository method that gets the list from the repo and brings it forward
            List<Car> list = _greenRepo.SeeAllCarsOnList();

            foreach (Car item in list)
            {
                Console.WriteLine($"{item.CarType}{item.Make} {item.Model} {item.YearofCar} {item.NumberofDoors} {item.CarID} ");
            }

            Console.WriteLine("Enter the CarID of the vehicle information you would like to update?");
            var CarID = int.Parse(Console.ReadLine());

            Car car = new Car();

            foreach (Car item in list)
            {
                if (item.CarID == CarID)
                {
                    car = item;
                    Console.WriteLine($"Type: {item.CarType}{item.Make} {item.Model} {item.YearofCar} {item.NumberofDoors} {item.CarID}\n");
                }
            }
            Console.ReadLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Console.WriteLine("Which item would you like to update? \n" +
                          "1. Car type (gas, electric, hybrid)\n" +
                          "2. Make\n" +
                          "3. Model\n" +
                          "4. YearofCar\n" +
                          "5. NumberofDoors\n" +
                          "6. CarID\n" +
                          "Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine($"The current Brand is {car.CarType}");
                    car.CarType = EnterACarType();
                    break;
                case "2":
                    Console.WriteLine($"The current car type is {car.Make}");
                    car.Make = EnterAMake();
                    break;
                case "3":
                    Console.WriteLine($"The current car year is {car.Model}");
                    car.Model = EnterAModel();
                    break;
                case "4":
                    Console.WriteLine($"The current mileage is {car.YearofCar}");
                    car.YearofCar = YearofCar();
                    break;
                case "5":
                    Console.WriteLine($"The current number of doors are {car.NumberofDoors}");
                    car.NumberofDoors = EnterNumberofDoors();
                    break;
                case "6":
                    Console.WriteLine($"The current number of doors is {car.CarID}");
                    car.CarID = EnterCarID();
                    break;
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private CarType EnterACarType()
        {
            
            Console.WriteLine("What type of Car is this?\n" +
             "1. Electric \n" +
             "2. Hybrid\n" +
             "3. Gas");
            string carTypeAsString = Console.ReadLine();
            int carTypeAsInt = int.Parse(carTypeAsString);
            CarType carType = (CarType)carTypeAsInt;
            return carType;

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private string EnterAMake()
        {
            Console.WriteLine("what is the make of the car?");
            string make = Console.ReadLine();
            return make;
        }


        private string EnterAModel()
        {
            Console.WriteLine("What is the model of the car?");
            string model = Console.ReadLine();
            return model;
        }

        private int YearofCar()
        {
            Console.WriteLine("What is the year of the car?");
            string yearOfCarAsString = Console.ReadLine();
            int yearOfCar = int.Parse(yearOfCarAsString);
            return yearOfCar;
        }


        private int EnterNumberofDoors()
        {
            Console.WriteLine("What is the number of doors on the car?");
            string numberofDoorsAsString = Console.ReadLine();
            int numberOfDoors = int.Parse(numberofDoorsAsString);
            return numberOfDoors;
        }

        private int EnterCarID()
        {
            Console.WriteLine("What is the ID number of the car?");
            string carIDAsString = Console.ReadLine();
            int carID = int.Parse(carIDAsString);
            return carID;
        }


        public void RemoveCarFromList()
        {
            Console.Clear();
            List<Car> list = _greenRepo.SeeAllCarsOnList(); // And here you're doing the same thing

            //But then you have this foreach that lists the vehicles
            foreach (Car item in list)
            {
                Console.WriteLine($"{item.CarType} {item.Make} {item.Model} {item.YearofCar} {item.NumberofDoors} {item.CarID} ");
            }

           
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.WriteLine("What is the the Car ID number that you would like to remove?");
            int CarID = ParseInput();
            Console.ReadLine();
            _greenRepo.RemoveCarFromList(CarID);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private int ParseInput()
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 0 || input > 2000000)
            {
                Console.WriteLine("Your input was invalid, please enter a valid menu number.");
                input = ParseInput();
            }
            return input;
        }

        private void SeedList()
        {
            Car contentOne = new Car( CarType.Electric, "Blah", "fancy", 2014, 3, 12345);
            Car contentTwo = new Car( CarType.Hybrid, "Half", "this", 2018, 4, 245677);
            Car contentThree = new Car(CarType.Gas, "asdsdg", "Dunno", 1979, 2, 87432);

            _greenRepo.AddCarToList(contentOne);
            _greenRepo.AddCarToList(contentTwo);
            _greenRepo.AddCarToList(contentThree);
        }

        
            

            
    }
}