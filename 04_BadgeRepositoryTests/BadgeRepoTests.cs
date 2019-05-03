using System;
using System.Collections.Generic;
using _04_BadgeRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_BadgeRepositoryTests
{
    [TestClass]
    public class BadgeRepoTests
    {
        [TestMethod]
        public void AddBadgeToDictionaryTest()
        {
            {
                BadgeRepository _badgeRepo = new BadgeRepository();

                List<string> _doorList = new List<string>();

                Dictionary<int, List<string>> _badgeDict = _badgeRepo.GetAllBadges();

                _doorList.Add("B6");

                Badge badge1 = new Badge(1, _doorList);
                Badge badge2 = new Badge(2, _doorList);
                Badge badge3 = new Badge(3, _doorList);

                _badgeRepo.AddBadgeToDictionary(badge1);
                _badgeRepo.AddBadgeToDictionary(badge2);
                _badgeRepo.AddBadgeToDictionary(badge3);



                var actual = _badgeDict.Keys.Count;
                var expected = 3;

                Assert.AreEqual(expected, actual);
            }


        }
    }
}
