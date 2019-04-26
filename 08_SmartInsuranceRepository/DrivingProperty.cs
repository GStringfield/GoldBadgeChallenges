using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SmartInsuranceRepository
{
    public class DrivingProperty
    {
        public bool FollowsSpeedLimit { get; set; }
        public  int TimesPerMonthSpeeding { get; set; }
        public int  TimesFollowedToClosely { get; set; } 
        public int  TimesSwervedOutsideOfLane { get; set; }
        public int TimesRolledThroughStopSign { get; set; }

        public DrivingProperty(string name, bool followsSpeedLimit, int timesPerMonthSpeeding, int timesFollowedToClosely, int timesSwervedOutsideOfLane, int timesRolledThroughStopSign)
        {
            FollowsSpeedLimit = followsSpeedLimit;
            TimesPerMonthSpeeding = timesPerMonthSpeeding;
            TimesFollowedToClosely = timesFollowedToClosely;
            TimesSwervedOutsideOfLane = timesSwervedOutsideOfLane;
            TimesRolledThroughStopSign = timesRolledThroughStopSign;

        }

        public DrivingProperty()
        {

        }

    }
}
