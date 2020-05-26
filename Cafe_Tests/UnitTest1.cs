using System;
using Cafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cafe_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MenuTest()
        {
            Menu menu1 = new Menu();             //Makes new menu item
            menu1.MenuNumber = 1;
            menu1.Name = "Cheeseburger";         //Gives new item a name
            menu1.Description = "Ground beef topped with cheddar cheese and your choice of condiments.";
            menu1.Ingredients = "Ground beef and cheddar cheese.";
            menu1.Price = 2.00m;

            Menu menu2 = new Menu();
            menu2.MenuNumber = 2;
            menu2.Name = "Pizza";
            menu2.Description = "Pizza topped with pepperoni or just cheese.";
            menu2.Ingredients = "Flour, tomato sauce, provolone cheese, pepperoni";
            menu2.Price = 2.50m;


            Menu menu3 = new Menu();
            menu3.MenuNumber = 3;
            menu3.Name = "Hot Dog";
            menu3.Description = "Beef Kosher hot dog with your choice of condiments.";
            menu3.Ingredients = "Beef and a bun made from white flour.";
            menu3.Price = 1.50m;


            Menu menu4 = new Menu();
            menu4.MenuNumber = 4;
            menu4.Name = "Nachos";
            menu4.Description = "Corn tortilla chips topped with your choice of cheese sauce or salsa.";
            menu4.Ingredients = "Corn flour, tomatos, green peppers, red peppers, onions, cheese sauce.";
            menu4.Price = 1.50m;
        }
    }
}

