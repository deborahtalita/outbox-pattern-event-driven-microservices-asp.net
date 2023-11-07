using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PostService.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
    }
}
