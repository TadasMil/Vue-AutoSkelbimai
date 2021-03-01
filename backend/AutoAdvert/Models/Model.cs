using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoAdvert.Models
{
    public class Model : BaseModel
    {
        public Model()
        {
            UploadedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }

        public int Amount { get; set; }
        public Brand Brand { get; set; }
    }
}
