using _3PidehTravelManagement_Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.ValueObjects
{
    internal class TravellerItem
    {
        public TravellerItem() { }

        public string Name { get; set; }
        public uint Quantity { get; set; }

        public bool IsTaken { get; set; }

        public TravellerItem(string name, uint quantity, bool isTaken)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new TravellerItemNameException();
            }
            Name = name;
            Quantity = quantity;
            IsTaken = isTaken;
        }
    }
}
