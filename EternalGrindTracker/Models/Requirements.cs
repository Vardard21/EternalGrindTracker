using System;
using System.Collections.Generic;
using System.Text;

namespace EternalGrindTracker
{
    public class Requirements
    {
        public int Id { get; set; }
        public string Stage { get; set; }

        public List<Material> Materials { get; set; }

    }
}
