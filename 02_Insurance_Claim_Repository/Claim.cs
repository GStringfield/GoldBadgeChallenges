﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Insurance_Claim_Repository
{
    public enum ClaimType
    {
        Car=1, Home, Theft

    }
    public class Claim
    {
        public int ClaimID { get; set; }
        public ClaimType Type { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }



        public Claim(int claimID, ClaimType type, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            Type = type;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;

        }

        public Claim()
        {

        }



    }

}


