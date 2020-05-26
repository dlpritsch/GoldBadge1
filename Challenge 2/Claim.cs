using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class Claim
    {

        public int ClaimID { get; set; }

        public string ClaimType { get; set; }

        public string Description { get; set; }

        public int ClaimAmount { get; set; }

        public DateTime IncidentDate { get; set; }

        public DateTime DateOfClaim { get; set; }

        bool IsValid = true;

        public Claim() { }

        public Claim(int claimID, string claimType, string description, int claimAmount, DateTime incidentDate, DateTime dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            IncidentDate = incidentDate;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}
