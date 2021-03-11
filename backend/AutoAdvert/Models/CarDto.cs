using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoAdvert.Models
{
    public class CarDto
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }
        public string WheelPosition { get; set; }
        public string City { get; set; }
        public string Gear { get; set; }
        public string Wheels { get; set; }
        public string BodyType { get; set; }
        public string Color { get; set; }
        public string FirstRegistration { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public int? PriceTo { get; set; }
        public int? Power { get; set; }
        public int? PowerTo { get; set; }
        public int? Miles { get; set; }
        public int? MilesTo { get; set; }
        public int? Year { get; set; }
        public int? YearTo { get; set; }
        public double? Volume { get; set; }
        public double? VolumeTo { get; set; }
        public int? Seats { get; set; }
        public int? SeatsTo { get; set; }

    }
}
