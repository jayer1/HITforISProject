﻿using System;
using System.Collections.Generic;

namespace isprojectHiT.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Encounter = new HashSet<Encounter>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastModified { get; set; }

        public virtual ICollection<Encounter> Encounter { get; set; }
    }
}
