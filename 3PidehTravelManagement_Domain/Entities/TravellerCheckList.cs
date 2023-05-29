using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.Entities
{
    internal class TravellerCheckList
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Destination { get; set; }

    }
}
