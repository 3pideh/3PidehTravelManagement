using _3PidehTravelManagement_Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.Exceptions
{
    public class TravellerItemNotFoundException : TravellerCheckListException
    {
        public string ItemName { get;  }
        public TravellerItemNotFoundException(string itemName)
            :base($"Traveller Check item:'{itemName}' not exist")
        {
            ItemName = itemName;
        }
    }
}
