using System;
using Challenge_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library
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
            claim1.DateOfIncident = new DateTime(2018, 4, 27);
            claim1.DateOfClaim = new DateTime(2018, 4, 25);

            Claim claim2 = new Claim();
            claim2.ClaimID = 2;
            claim2.ClaimType = "Home";
            claim2.Description = "House fire in kitchen.";
            claim2.ClaimAmount = 4000.00m;
            claim2.DateOfIncident = new DateTime(2018, 4, 11);
            claim2.DateOfClaim = new DateTime(2018, 4, 12);

            Claim claim3 = new Claim();
            claim3.ClaimID = 3;
            claim3.ClaimType = "Theft";
            claim3.Description = "Stolen pancakes.";
            claim3.ClaimAmount = 4.00m;
            claim3.DateOfIncident = new DateTime(2018, 4, 27);
            claim3.DateOfClaim = new DateTime(2018, 6, 01);

        }
    }
}
