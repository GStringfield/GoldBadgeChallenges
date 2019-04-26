using _02_Insurance_Claim_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Insurance_Claim
{
    public class ProgramUI
    {


        private ClaimRepository _claimRepo = new ClaimRepository();


        public void Run()
        {
            ClaimList();
            RunMenu();

        }

        private void RunMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Choose a menu item:\n" +
                    "1.See all claims\n" +
                    "2.Take care of next claim\n" +
                    "3.Enter a new claim\n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        EnterANewClaim();
                        break;
                    case "4":
                        running = false;
                        break;
                }

            }
        }


        private void SeeAllClaims()
        {

            Queue<Claim> list = _claimRepo.GetClaimQueue();

            foreach (Claim content in list)
            {
                Console.WriteLine($"{content.ClaimID}  {content.Type}  {content.Description}  {content.ClaimAmount}  {content.DateOfIncident}  {content.DateOfClaim}  {content.IsValid}");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }


        private void TakeCareOfNextClaim()
        {
            Claim nextClaim = _claimRepo.PeekNextContent();
            Console.WriteLine($"{nextClaim.ClaimID}  {nextClaim.Type}  {nextClaim.Description}  {nextClaim.ClaimAmount}  {nextClaim.DateOfIncident}  {nextClaim.DateOfClaim}  {nextClaim.IsValid}");

            Console.WriteLine("Would you like to handle this claim now?(y/n)");
            string nextClaimAsString= Console.ReadLine();

            if (nextClaimAsString == "y")
            {
                _claimRepo.GetNextClaim();
            }
        }


        public void EnterANewClaim()
        {
            Console.WriteLine("what is the claim ID number?");
            string claimIDAsString = Console.ReadLine();
            int claimID = int.Parse(claimIDAsString);

            Console.WriteLine("What is the type of claim?\n" +
                   "1. Car\n" +
                   "2. Home\n" +
                   "3. Theft");

            string typeAsString = Console.ReadLine();
            int typeAsInt = int.Parse(typeAsString);

            ClaimType type = (ClaimType)typeAsInt;

            Console.WriteLine("What is the description of the claim?");
            string description = Console.ReadLine();


            Console.WriteLine("What is the amount of the claim??");
            string claimAmountAsString = Console.ReadLine();
            decimal claimAmount = decimal.Parse(claimAmountAsString);

            Console.WriteLine("What was the date when the incident happened? Please use(mm/dd/yy) format.");
            string dateOfIncidentAsString = Console.ReadLine();
            DateTime dateOfIncident = DateTime.Parse(dateOfIncidentAsString);

            Console.WriteLine("what is the date the claim was filed? Please use(mm/dd/yy) format.");
            string dateOfClaimAsString = Console.ReadLine();
            DateTime dateOfClaim = DateTime.Parse(dateOfClaimAsString);

            
            bool isValid = false;
            if ((dateOfClaim - dateOfIncident).Days <= 30)
            {
                isValid = true;
            }


            Claim newContent = new Claim(claimID, type, description, claimAmount, dateOfIncident, dateOfClaim,  isValid);

            _claimRepo.AddToQueue(newContent);

        }

        private void ClaimList()
        {
            Claim claimOne = new Claim(1, ClaimType.Car, "Car accident on 465", 400.00m, new DateTime(2018,04,25), new DateTime (2018,04,27), true);
            Claim claimTwo = new Claim(2, ClaimType.Theft, "Fire in kitchen", 4000.00m, new DateTime (2018,04,26), new DateTime (2018,04,28), true);
            Claim claimThree = new Claim(3, ClaimType.Theft, "Stolen pancakes", 4.00m, new DateTime (2018,04,27), new DateTime(2018,06,01), false);
            Claim claimFour = new Claim();


            _claimRepo.AddToQueue(claimOne);
            _claimRepo.AddToQueue(claimTwo);
            _claimRepo.AddToQueue(claimThree);
           


        }

     















    }
}
