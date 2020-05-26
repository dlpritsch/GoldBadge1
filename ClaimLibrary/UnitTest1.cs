using System;
using Challenge_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClaimLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ClaimTest()
        {
            Claim claim1 = new Claim();
            claim1.ClaimID = 1;
            claim1.ClaimType = "Car";
            claim1.Description = "Car accident on 465.";
            claim1.ClaimAmount = 400.00m;
            claim1.DateOfIncident = new DateTime(2018, 4, 25);
            claim1.DateOfClaim = new DateTime(2018, 4, 27);

            Claim claim2 = new Claim();
            claim1.ClaimID = 2;
            claim1.ClaimType = "Home";
            claim1.Description = "House fire in kitchen.";
            claim1.ClaimAmount = 4000.00m;
            claim1.DateOfIncident = new DateTime(2018, 4, 11);
            claim1.DateOfClaim = new DateTime(2018, 4, 12);

            Claim claim3 = new Claim();
            claim1.ClaimID = 3;
            claim1.ClaimType = "Theft";
            claim1.Description = "Stolen pancakes.";
            claim1.ClaimAmount = 4.00m;
            claim1.DateOfIncident = new DateTime(2018, 4, 27);
            claim1.DateOfClaim = new DateTime(2018, 6, 01);
        }
    }
}
