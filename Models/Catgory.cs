using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Workshop2.Models
{
    public class Catgory
    {
        public Catgory()
        {
            customers = new HashSet<Catgory>();

        }
        [Key]
        public string CutID { get; set; }
        public string CatName { get; set; }
        public ICollection<Catgory> customers { get; set; }
    }
}
