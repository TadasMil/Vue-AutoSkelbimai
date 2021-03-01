using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoAdvert.Models
{
    public class Brand : BaseModel
    {
        public Brand()
        {
            UploadedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }
        public int Amount { get; set; }
        public ICollection<Model> Models { get; set; }
    }
}
