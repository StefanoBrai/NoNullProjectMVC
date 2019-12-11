using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Request
    {
        public Request()
        {
            Bid = new HashSet<Bid>();
            Candidature = new HashSet<Candidature>();
            TrackRequests = new HashSet<TrackRequest>();
        }

        public int ReqId { get; set; }
        public int CompId { get; set; }
        public int ProjId { get; set; }
        public int SkillId { get; set; }
        public int DestinationId { get; set; }
        public DateTime BeginningDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public string Description { get; set; }

        public virtual Company Comp { get; set; }
        public virtual Destination Destination { get; set; }
        public virtual Project Proj { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual ICollection<Bid> Bid { get; set; }
        public virtual ICollection<Candidature> Candidature { get; set; }
        public virtual ICollection<TrackRequest> TrackRequests { get; set; }
    }
}
