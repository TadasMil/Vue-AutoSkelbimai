using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoAdvert.Models
{
    public class Attributes
    {
        public List<Brand> brands { get; set;  }
        public List<City> cities { get; set; }
        public List<Color> colors { get; set; }
        public List<FirstRegistration> firstRegistrations { get; set; }
        public List<BodyType> bodyTypes { get; set; }

    }
}
