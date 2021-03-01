using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoAdvert.Models
{
    public class City : BaseModel
    {
        public City()
        {
            UploadedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }
    }
}
