using System.Collections.Generic;

namespace GoldfishLunch
{
    public class Company {
        public List<Employee> employees = new List<Employee>();
        public string Name { get; set; } = "Goldfish & Lunch";
        public string DateFounded { get; set; }
        public string EIN { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

    }
}