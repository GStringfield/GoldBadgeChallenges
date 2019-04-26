using System;
using _02_Insurance_Claim_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Insurance_Claim_Repository_Tests
{
    [TestClass]
    public class ClaimRepoTests
    {
        [TestMethod]
        public void AddToQueue()
        {
            ClaimRepository claimRepo = new ClaimRepository();
            Claim claim = new Claim(5, ClaimType.Home,"Dumpster Fire",42.00m, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27), true);


            claimRepo.AddToQueue(claim);
            Claim claimContent = claimRepo.PeekNextContent();

            int expectedCount = 1;
            int actualCount = claimRepo.GetClaimQueue().Count;

            Assert.AreSame(claim, claimContent);
            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void ClaimProcessed()
       
        {
            ClaimRepository claimRepo = new ClaimRepository();
            Claim claim = new Claim(5, ClaimType.Home, "Dumpster Fire", 42.00m, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27), true);


            claimRepo.AddToQueue(claim);
            Claim claimContent = claimRepo.GetNextClaim();

            int expectedCount = 0;
            int actualCount = claimRepo.GetClaimQueue().Count;

            Assert.AreSame(claim, claimContent);
            Assert.AreEqual(expectedCount, actualCount);
        }







    }
}
