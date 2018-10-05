using System.Collections.Generic;

namespace GoldfishLunch
{
    public class Menu {
        public Menu (List<MenuItem> items) {
            MenuItems = items;
        }

        public List<MenuItem> MenuItems = new List<MenuItem>();

        public int AvailabilityStart { get; set; }
        public int AvailabilityEnd { get; set; }
    }
}