using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class CompanyReference
    {
        public int RefId { get; set; }
        public int CompId { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

        public virtual Company Comp { get; set; }
    }
}
