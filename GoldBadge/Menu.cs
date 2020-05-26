using System;

namespace Cafe
{
    public class Menu
    {
        private int v1;
        private string v2;

        public int MenuNumber { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Ingredients { get; set; }

        public decimal Price { get; set; }

        public Menu() {}

        public Menu(int menuNumber, string name, string description, string ingredients, decimal price)   //Constructor: refers to the menu items created in unit test.
        {
            MenuNumber = menuNumber;
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }

        public Menu(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }


}

