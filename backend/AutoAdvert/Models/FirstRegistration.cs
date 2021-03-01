using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoAdvert.Models
{
    public class FirstRegistration : BaseModel
    {
        public FirstRegistration()
        {
            UploadedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }
    }
}
