using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Company
    {
        public Company()
        {
            CompanyReference = new HashSet<CompanyReference>();
            Projects = new HashSet<Project>();
            Requests = new HashSet<Request>();
        }

        public int CompId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Postalcode { get; set; }
        public int DestinationId { get; set; }
        public int GeneralareaId { get; set; }
        public string Mission { get; set; }

        public virtual Destination Destination { get; set; }
        public virtual GeneralArea Generalarea { get; set; }
        public virtual ICollection<CompanyReference> CompanyReference { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
