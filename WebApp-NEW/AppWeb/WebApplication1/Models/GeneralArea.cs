using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class GeneralArea
    {
        public GeneralArea()
        {
            Companies = new HashSet<Company>();
            Projects = new HashSet<Project>();
            Skills = new HashSet<Skill>();
        }

        public int GeneralareaId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
