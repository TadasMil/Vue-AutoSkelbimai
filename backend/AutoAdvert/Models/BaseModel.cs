using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoAdvert.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UploadedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
