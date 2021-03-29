using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Menu
{
    class Menu
    {
        //properties, constructors, and fields for project
       

        public int MealNum { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public double Price { get; set; }
        
        //Empty Constructor here
        public Menu(int mealNum, string mealName, string description, List<string> ingredients, double price)
        {
            MealName = mealName;
            MealNum = mealNum;
            Price = price;
            Ingredients = ingredients;
            Description = description;

        }
        //basic Constructor
        public Menu()
        {
        }
    }
}
