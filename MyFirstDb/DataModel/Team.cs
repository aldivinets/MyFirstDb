using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstDb.DataModel;
using System.ComponentModel.DataAnnotations;

namespace MyFirstDb.DataModel
{
    public class Team
    {
        public int Id { get; set; }
        [MaxLength(100)][Required]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        public int Capacity { get; set; }
    }
}
