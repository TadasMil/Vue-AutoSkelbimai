using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoAdvert.Models
{
    public class Car : BaseModel
    {
        public Car ()
        {
            UploadedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }
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
        public decimal Price { get; set; }
        public int Power { get; set; }
        public int Miles { get; set; }
        public int Year { get; set; }
        public int Volume { get; set; }
        public int Seats { get; set; }
        public ICollection<Image> Images { get; set; }

    }
}
