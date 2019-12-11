using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Candidature
    {
        public int CandidatureId { get; set; }
        public int ProfId { get; set; }
        public int ReqId { get; set; }
        public bool Acceptation { get; set; }
        public DateTime SendData { get; set; }
        public string Message { get; set; }

        public virtual Professionist Prof { get; set; }
        public virtual Request Req { get; set; }
    }
}
