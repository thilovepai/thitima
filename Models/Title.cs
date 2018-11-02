using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop2.Models
{
    public class Title
    {
            public Title()
            {
                customers = new HashSet<Customer>();

            }
            [Key]
            public string initialCode { get; set; }
            public string initialName { get; set; }
            public ICollection<Customer> customers { get; set; }

        }
    
}
