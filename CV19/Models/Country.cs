using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV19.Models
{
    internal class PlaceInfo
    {
        public required string Name { get; set; }

        public Point Location { get; set; }

        public required IEnumerable<ConfirmedCount> Count { get; set; }
    }
}
