using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    class ProgramUI
    {
        private Repository _itemRepo = new Repository();
        private int menuNumber;

        //Starts app
        public void Run()
        {
            SeedMenuList();
            Menu();
        }

        // Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                // Display Options
                Console.WriteLine("Make a selection:\n" +
                    "1. Create a new menu item\n" +
                    "2. View all menu items\n" +
                    "3. View content by number\n" +
                    "4. Update existing menu item\n" +
                    "5. Delete menu item\n" +
                    "6. Exit");

                // User Input
                string input = Console.ReadLine();

                // Evaluate Input
                switch (input)
                {
                    case "1":
                        //Create
                        CreateNewItem();
                        break;
                    case "2":
                        //View All
                        DisplayMenu();
                        break;
                    case "3":
                        //View by number
                        DisplayByNumber();
                        break;
                    case "4":
                        //Update
                        UpdateMenu();
                        break;
                    case "5":
                        //Delete
                        DeleteItem();
                        break;
                    case "6":
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

        // create new menu item
        private void CreateNewItem()
        {
            Console.Clear();

            Menu newMenu = new Menu();

            Console.WriteLine("Enter the name of the new item:");
            newMenu.Name = Console.ReadLine();

            Console.WriteLine("Enter the new item's menu number:");
            string itemNumberString = Console.ReadLine();           //Takes in number as string 
            newMenu.MenuNumber = int.Parse(itemNumberString);       //Converts string to integer

            Console.WriteLine("Enter the new item's price:");
            string priceAsString = Console.ReadLine();              //Takes in string on string
            newMenu.Price = decimal.Parse(priceAsString);           //Converts string to decimal

            Console.WriteLine("Enter the description of the new item:");
            newMenu.Description = Console.ReadLine();

            Console.WriteLine("Enter the ingredients of the new item:");
            newMenu.Ingredients = Console.ReadLine();

            _itemRepo.AddItemsToMenu(newMenu);
        }

        // view current items
        private void DisplayMenu()
        {
            Console.Clear();

            List<Menu> listOfMenuItems = _itemRepo.GetMenu();

            foreach (Menu content in listOfMenuItems)
            {
                Console.WriteLine($"Name: {content.Name}\n" +
                    $"Number: {content.MenuNumber}\n" +
                    $"Description: {content.Description}\n" +
                    $"Ingredients: {content.Ingredients}\n" +
                    $"Price: {content.Price}\n");
            }
        }

        // view menu item by number
        private void DisplayByNumber()
        {
            Console.Clear();
            // Ask for menu item number
            Console.WriteLine("Enter the menu item number");

            // Get input
            string input = Console.ReadLine();
            int claimID = int.Parse(input);

            // Find the item
            Menu content = _itemRepo.GetItemByNumber(claimID);
            
            // Display requested info
            if(claimID != null)
            {
                Console.WriteLine($"Name: {content.Name}\n" +
                    $"Number: {content.MenuNumber}\n" +
                    $"Description: {content.Description}\n" +
                    $"Ingredients: {content.Ingredients}\n" +
                    $"Price: {content.Price}\n");
            }
            else
            {
                Console.WriteLine("No item listed under that number.");
            }

        }

        // update menu
        private void UpdateMenu()
        {
            // Display Content
            DisplayMenu();

            // Ask for number of item to update
            Console.WriteLine("Enter the number of the menu item to update:");

            // Get the number
            string input = Console.ReadLine();
            int menuNumber = int.Parse(input);

            // Build new item
            Menu newMenu = new Menu();

            Console.WriteLine("Enter the name of the new item:");
            newMenu.Name = Console.ReadLine();

            Console.WriteLine("Enter the new item's menu number:");
            string itemNumberString = Console.ReadLine();           //Takes in number as string 
            newMenu.MenuNumber = int.Parse(itemNumberString);       //Converts string to integer

            Console.WriteLine("Enter the new item's price:");
            string priceAsString = Console.ReadLine();              //Takes in string on string
            newMenu.Price = decimal.Parse(priceAsString);           //Converts string to decimal

            Console.WriteLine("Enter the description of the new item:");
            newMenu.Description = Console.ReadLine();

            Console.WriteLine("Enter the ingredients of the new item:");
            newMenu.Ingredients = Console.ReadLine();

            // Verify update worked
            bool wasUpdated = _itemRepo.UpdateMenu(menuNumber, newMenu);

            if (wasUpdated)
            {
                Console.WriteLine("Item updated successfully!");
            }
            else
            {
                Console.WriteLine("Item could not be updated.");
            }
        }

        // delete item
        private void DeleteItem()
        {
            DisplayMenu();


            // Get item to delete
            Console.WriteLine("\nEnter the number of the item to remove:");

            string input = Console.ReadLine();
            int menuNumber = int.Parse(input);

            // Call method
            bool wasDeleted = _itemRepo.RemoveItemFromMenu(menuNumber);

            // If deleted, say so
            if (wasDeleted)
            {
                Console.WriteLine("The item has been deleted from the menu.");
            }
            else
            {
                Console.WriteLine("Item could not be deleted.");
            }

            // Otherwise state it couldn't be deleted
        }

        //Seed Method
        private void SeedMenuList()
        {
            Menu cheeseburger = new Menu(1, "Cheeseburger", "Ground beef topped with cheddar cheese and your choice of condiments", "Ground beef and cheddar cheese.", 2.00m);
            Menu pizza = new Menu(2, "Pizza", "Pizza topped with pepperoni or just cheese", "Flour, tomato sauce, provolone cheese, pepperoni", 2.50m);
            Menu hotdog = new Menu(3, "Hot Dog", "Beef Kosher hot dog with your choice of condiments.", "Beef and a bun made from white flour.", 1.50m);
            Menu nachos = new Menu(4, "Nachos", "Corn tortilla chips topped with your choice of cheese sauce or salsa", "Corn flour, tomatos, green peppers, red peppers, onions, cheese sauce", 1.50m);

            _itemRepo.AddItemsToMenu(cheeseburger);
            _itemRepo.AddItemsToMenu(pizza);
            _itemRepo.AddItemsToMenu(hotdog);
            _itemRepo.AddItemsToMenu(nachos);
        }


    }
}


