using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class TrackRequest
    {
        public int TrackId { get; set; }
        public int ProfId { get; set; }
        public int ReqId { get; set; }
        public DateTime BeginningDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public string Profcomment { get; set; }
        public string Compcomment { get; set; }
        public int ProfEValuation { get; set; }
        public int CompEvaluetion { get; set; }

        public virtual Professionist Prof { get; set; }
        public virtual Request Req { get; set; }
    }
}
