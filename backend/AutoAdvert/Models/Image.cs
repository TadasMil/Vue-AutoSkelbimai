using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoAdvert.Models
{
    public class Image
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string Name { get; set; }
        public Car Car { get; set; }
    }
}
