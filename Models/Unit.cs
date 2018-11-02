using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Workshop2.Models
{
    public partial class Unit
    { 
    public  Unit ()
    {
        products = new HashSet<Product>();
         
    }
    [Key]
    public string UniCode { get; set; }
    public string NameU { get; set; }
    public ICollection<Product> products { get; set; }
        
    }
}
