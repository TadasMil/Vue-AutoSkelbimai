using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoAdvert.Models
{
    public class Color : BaseModel
    {
        public Color()
        {
            UploadedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }
    }
}
