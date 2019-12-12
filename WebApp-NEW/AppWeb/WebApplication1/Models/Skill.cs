using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Skill
    {
        public Skill()
        {
            Requests = new HashSet<Request>();
        }

        public int SkillId { get; set; }
        public int GeneralareaId { get; set; }
        public int ProfId { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }

        public virtual GeneralArea Generalarea { get; set; }
        public virtual Professionist Prof { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
