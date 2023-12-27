using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationAssignmentDay14.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }

        public int NumberOfWorldCups { get; set; }
    }
}