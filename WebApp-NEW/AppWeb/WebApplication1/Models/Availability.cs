using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Availability
    {
        public int Avaid { get; set; }
        public int ProfId { get; set; }
        public DateTime BeginningDate { get; set; }
        public DateTime EndingDate { get; set; }
        public int DestinationId { get; set; }

        public virtual Destination Destination { get; set; }
        public virtual Professionist Prof { get; set; }
    }
}
