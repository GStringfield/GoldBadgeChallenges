using System;
using _08_SmartInsuranceRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_SmartInsuranceRepositoryTests
{
    [TestClass]
    public class SmartInsuranceRepoTests
    {
        [TestMethod]
        public void CalculatePremiumTest()
        {
            SmartInsuranceRepository smartRepo = new SmartInsuranceRepository();


            int actual = smartRepo.CalculatePremium(3, 1, 2, 1);
            int expected = (225);

            Assert.AreEqual(expected, actual);
        } 
       
      
    }
}
