using System;
using System.Collections.Generic;
using System.Text;

namespace Almodhtar.Entities
{
    public class Visit
    {
        public string NewsId { get; set; }
        public string IpAddress { get; set; }
        public DateTime LastVisitDateTime { get; set; }
        public int NumberOfVisit { get; set; }

        public virtual News News { get; set; }
    }
}
