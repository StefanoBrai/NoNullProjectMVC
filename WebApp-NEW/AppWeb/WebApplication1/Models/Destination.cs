using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Destination
    {
        public Destination()
        {
            Availabilities = new HashSet<Availability>();
            Companies = new HashSet<Company>();
            InverseMacroareaNavigation = new HashSet<Destination>();
            Professionists = new HashSet<Professionist>();
            Requests = new HashSet<Request>();
        }

        public int DestinationId { get; set; }
        public string Name { get; set; }
        public int? MacroArea { get; set; }

        public virtual Destination MacroareaNavigation { get; set; }
        public virtual ICollection<Availability> Availabilities { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Destination> InverseMacroareaNavigation { get; set; }
        public virtual ICollection<Professionist> Professionists { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
