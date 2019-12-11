using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Professionist
    {
        public Professionist()
        {
            Availabilities = new HashSet<Availability>();
            Bid = new HashSet<Bid>();
            Candidature = new HashSet<Candidature>();
            Skills = new HashSet<Skill>();
            TrackRequests = new HashSet<TrackRequest>();
        }

        public int ProfId { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Profession { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Postalcode { get; set; }
        public int DestinationId { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string MinAvailability { get; set; }
        public string MaxAvailability { get; set; }

        public virtual Destination Destination { get; set; }
        public virtual ICollection<Availability> Availabilities { get; set; }
        public virtual ICollection<Bid> Bid { get; set; }
        public virtual ICollection<Candidature> Candidature { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<TrackRequest> TrackRequests { get; set; }
    }
}
