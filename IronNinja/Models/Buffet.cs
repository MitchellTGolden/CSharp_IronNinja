using System;
using System.Collections.Generic;

namespace IronNinja.Models
{
    public class Buffet
    {
        public static Random rand = new Random();

        public List<IConsumable> Menu;

        //constructor
        public Buffet()
        {
        Menu = new List<IConsumable>()
        {
            new Food("RubixCubes", 100, false, false),
            new Food("Apple Pie", 400, false, true),
            new Food("Kimchi", 8, true, false),
            new Food("Nachos", 346, true, false),
            new Food("Soup", 90, false, false),
            new Food("Pizza", 285, false, false),
            new Food("Ice Cream", 137, false, true),
            new Drink("Bourbon", 97, false),
            new Drink("Sake", 39, false),
            new Drink("Soju", 540, false)
        };

        }

        public IConsumable Serve()
        {
            var item = Menu[rand.Next(0, Menu.Count)];
            return item;
        }
    }
}