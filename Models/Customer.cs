using System;
using System.Collections.Generic;

namespace Workshop2.Models
{
    public partial class Customer
    {
        public string CustId { get; set; }
        public string initialCode { get; set; }
        public string initialName { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public short? CustType { get; set; }
        
    }
}
