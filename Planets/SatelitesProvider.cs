using System;
using System.Collections.Generic;
using System.Text;

namespace Universe
{
    class SatelitesProvider
    {

        public int id { get; set; }
        public int planetId { get; set; }
        public string name { get; set; }
        public double gm { get; set; }
        public double radius { get; set; }
        public double? density { get; set; }
        public double? magnitude { get; set; }
        public double? albedo { get; set; }

    }
}
