using _08_SmartInsuranceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SmartInsurance
{
    public class ProgramUI
    {
        private SmartInsuranceRepository _SmartIRepo = new SmartInsuranceRepository();

        public void Run()
        {
            Console.Clear();
            RunMenu();

        }
        private void RunMenu()
        {


            bool running = true;
            while (running)
            {

                Console.WriteLine("Welcome to the Smart Insurance monthly premium calculations app. Please enter the information recieved from smart car. Hit the Enter key to continue.");
                string input = Console.ReadLine();


                bool speeds = FollowsSpeedLimit();


                int timesSpentSpeeding = 0;
                if (speeds)
                {
                    timesSpentSpeeding = TimesPerMonthSpeeding();
                }


                int timesFollowedTooClosely = TimesFollowedTooClosely();



                int timesSwervedOutsideOfLane = TimesSwervedOutsideOfLane();


                int timesRolledThroughStopSign = TimesRolledThroughStopSign();


                int calculatePremium = _SmartIRepo.CalculatePremium(timesSpentSpeeding, timesFollowedTooClosely, timesSwervedOutsideOfLane, timesRolledThroughStopSign);
                Console.WriteLine($"The monthly premium for this customer will be: {calculatePremium}");
                Console.ReadKey();

                Console.Clear();
            }

         

        }

        public bool FollowsSpeedLimit()
        {
            Console.WriteLine("Has the driver traveled over the speed limit this month? (y/n)");
            string followsSpeedLimitAsString = Console.ReadLine().ToLower();

            bool followsSpeedLimit;
            switch (followsSpeedLimitAsString)
            {
                case "y":
                case "yes":
                    followsSpeedLimit = true;
                    break;
                case "n":
                case "no":
                default:
                    followsSpeedLimit = false;
                    break;
            }

            return followsSpeedLimit;
        }

        private int TimesPerMonthSpeeding()
        {
            Console.WriteLine("How many times has the drive traveled over the speed limit this month?");
            string timesSpentSpeedingAsString = Console.ReadLine();
            int timesSpedPerMonth = int.Parse(timesSpentSpeedingAsString);
            return timesSpedPerMonth;
        }


        public int TimesFollowedTooClosely()
        {
            Console.WriteLine("How many times has the driver followed too closely this month?");
            string timesFollowedTooCloselyAsString = Console.ReadLine();
            int timesFollowedTooClosely = int.Parse(timesFollowedTooCloselyAsString);
            return timesFollowedTooClosely;
        }

        public int TimesSwervedOutsideOfLane()
        {
            Console.WriteLine("How man times has the driver swerved outside of their lane this month?");
            string timessSwervedOutsideOfLaneAsString = Console.ReadLine();
            int timessSwervedOutsideOfLane = int.Parse(timessSwervedOutsideOfLaneAsString);
            return timessSwervedOutsideOfLane;

        }

        public int TimesRolledThroughStopSign()
        {
            Console.WriteLine("How many times has the driver rolled through a stop sign this month?");
            string timesRolledThroughStopSignAsString = Console.ReadLine();
            int timesRolledThroughStopSign = int.Parse(timesRolledThroughStopSignAsString);
            return timesRolledThroughStopSign;
        }








    }


}
