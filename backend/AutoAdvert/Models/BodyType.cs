using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoAdvert.Models
{
    public class BodyType : BaseModel
    {
        public BodyType()
        {
            UploadedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }
    }
}
