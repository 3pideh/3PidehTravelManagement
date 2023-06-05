using _3PidehTravelManagement_Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.Exceptions
{
    public class TravellerItemAlreadyExistsException : TravellerCheckListException
    {
        public string ListName { get; set; }
        public string ItemName { get; set; }

        public TravellerItemAlreadyExistsException(string listName, string itemName)
            :base($"Traveller Check List:'{listName}' already exist")
        {
            ListName = listName;
            ItemName = itemName;
        }
    }
}
