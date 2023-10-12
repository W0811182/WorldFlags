using System;
using System.ComponentModel.DataAnnotations;

namespace WorldFlags.Models
{
    public class Flag
    {
        public int Id { get; set; }
        public string Continent { get; set; }
        public string Country { get; set; }
        public decimal Price { get; set; }
        public string Colour { get; set; }
        public string Size { get; set; }
        public string rating { get; set; }
    }
}
