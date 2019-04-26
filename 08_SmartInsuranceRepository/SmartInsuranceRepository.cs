using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SmartInsuranceRepository
{
    public class SmartInsuranceRepository
    {
        List<DrivingProperty> _driveProp = new List<DrivingProperty>();




        public int CalculatePremium(int speeding, int tooClose, int texting, int noStop)
        {

            int speedingTotal = speeding * 5;

            int tooCloseTotal = tooClose * 50;

            int texingTotal = texting * 50;

            int noStopTotal = noStop * 10;

            

            

            int basePrice = 50 + speedingTotal +  tooCloseTotal + texingTotal + noStopTotal;

            return basePrice;


        }
























    }
}
