using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Project
    {
        public Project()
        {
            Requests = new HashSet<Request>();
        }

        public int ProjId { get; set; }
        public int GeneralareaId { get; set; }
        public int CompId { get; set; }
        public string Description { get; set; }

        public virtual Company Comp { get; set; }
        public virtual GeneralArea Generalarea { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
