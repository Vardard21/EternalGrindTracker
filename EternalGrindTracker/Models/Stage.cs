using System;
using System.Collections.Generic;
using System.Text;

namespace EternalGrindTracker
{
    public class Stage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Requirements> Requirements { get; set; }
    }
}
