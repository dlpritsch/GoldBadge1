using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mime;

namespace Challenge_2
{
    class ProgramUI
    {
        private Repository _itemRepo = new Repository();


        //Starts app
        public void Run()
        {
            SeedMenuLibrary();
            Menu();
        }

        // Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                // Display Options
                Console.WriteLine("Choose a menu item:\n" +
                    "1. View all claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Create a new claim\n" +
                    "4. Exit\n");

                // User Input
                string input = Console.ReadLine();

                // Evaluate Input
                switch (input)
                {
                    case "1":
                        //View All
                        DisplayMenu();
                        break;
                    case "2":
                        //Take Care of next claim
                        GetClaim();
                        break;
                    case "3":
                        //Create
                        CreateNewItem();
                        break;
                    case "4":
                        //Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid selection.");
                        break;
                }

                Console.WriteLine("Please press any key to continu...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        // view current items
        private void DisplayMenu()
        {
            Console.Clear();

            Queue<Claim> listOfMenuItems = _itemRepo.GetClaim();

            foreach (Claim content in listOfMenuItems)
            {
                Console.WriteLine($"ClaimID: {content.ClaimID}\n" +
                    $"Claim Type: {content.ClaimType}\n" +
                    $"Description: {content.Description}\n" +
                    $"Claim Amount: {content.ClaimAmount}\n" +
                    $"Date of Incident: {content.DateOfIncident}\n" +
                    $"Date of Claim: {content.DateOfClaim}\n" +
                    $"Is Valid: {content.IsValid}\n");
            }
            
        }

        private void GetClaim()
        {
            Console.Clear();

        }

        // create new menu item
        private void CreateNewItem()
        {
            Console.Clear();

            Claim newClaim = new Claim();

            Console.WriteLine("Enter new claimID number:");
            string itemNumberString = Console.ReadLine();           //Takes in number as string 
            newClaim.ClaimID = int.Parse(itemNumberString);       //Converts string to integer

            Console.WriteLine("Enter type of claim:");
            newClaim.ClaimType = Console.ReadLine();

            Console.WriteLine("Enter the description of the claim:");
            newClaim.Description = Console.ReadLine();

            Console.WriteLine("Enter the new claim amount:");
            string priceAsString = Console.ReadLine();              //Takes in string on string
            newClaim.ClaimAmount = decimal.Parse(priceAsString);           //Converts string to decimal


            Console.WriteLine("Enter the date of the accident:");
            string incidentString = Console.ReadLine();
            newClaim.DateOfIncident = DateTime.Parse(incidentString);

            Console.WriteLine("Enter the date the claim was created:");
            string claimString = Console.ReadLine();
            newClaim.DateOfClaim = DateTime.Parse(claimString);


            _itemRepo.AddItemsToLibrary(newClaim);
        }



        //Seed Method
        private void SeedMenuLibrary()
        {
            Claim claim1 = new Claim(1, "Car", "Car accident on 465.", 400.00m, new DateTime (2018, 4, 25), new DateTime (2018, 4, 27));
            Claim claim2 = new Claim(2, "Home", "House fire in kitchen.", 4000.00m, new DateTime(2018, 4, 11), new DateTime (2018, 4, 12));
            Claim claim3 = new Claim(3, "Theft", "Stolen pancakes.", 4.00m, new DateTime (208, 4, 27), new DateTime (2018, 6, 1));

            _itemRepo.AddItemsToLibrary(claim1);
            _itemRepo.AddItemsToLibrary(claim2);
            _itemRepo.AddItemsToLibrary(claim3);
        }
    }
}

