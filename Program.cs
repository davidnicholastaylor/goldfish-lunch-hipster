using System;
using System.Collections.Generic;

namespace GoldfishLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MenuItem> menuItems = new List<MenuItem>() {
                new MenuItem() {
                    Name = "Red Goldfish",
                    Price = 8
                },
                new MenuItem() {
                    Name = "Blue Goldfish",
                    Price = 15
                },
            };

            Menu lunchMenu = new Menu(menuItems);

            Menu dinnerMenu = new Menu(menuItems);
        }
    }
}
