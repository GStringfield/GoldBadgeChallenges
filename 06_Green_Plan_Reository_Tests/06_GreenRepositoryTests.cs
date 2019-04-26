using System;
using System.Collections.Generic;
using _06_Green_Plan_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Green_Plan_Reository_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddCarToListTest()

        {
            GreenRepository _greenRepo = new GreenRepository();
            Car car = new Car(CarType.Gas, "Honda", "Accord", 2009, 4, 256 );


            _greenRepo.AddCarToList(car);
           
            List<Car>list = _greenRepo.SeeAllCarsOnList();

            int actual = list.Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(list.Contains(car));

        }
        [TestMethod]
        public void RemoveCarFromList()
        {
            GreenRepository _greenRepo = new GreenRepository();
            Car car = new Car(CarType.Gas, "Honda", "Accord", 2009, 4, 256);

            Car carTwo = new Car();

            _greenRepo.AddCarToList(car);
            _greenRepo.AddCarToList(carTwo);

            _greenRepo.RemoveCarFromList(256);

            int actual = _greenRepo.SeeAllCarsOnList().Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
    }
}
