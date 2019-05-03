using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BadgeRepository
{
    public class BadgeRepository
    {
        private Dictionary<int, List<string>> _badgeDict = new Dictionary<int, List<string>>();
        

        public void AddBadgeToDictionary(Badge badge)
        {
            _badgeDict.Add(badge.BadgeID, badge.Doors);
        }

       

        public void EditABadge(int badgeID, List<string> doors)
        {
            _badgeDict[badgeID] = doors;
        }



        public Dictionary<int, List<string>> GetAllBadges()
        {
            return _badgeDict;
        }


        











    }
}
