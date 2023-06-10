using _3PidehTravelManagement_Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.Exceptions
{
    public class InvalidTravelDaysException : TravellerCheckListException
    {

        public ushort Days { get; }
        public InvalidTravelDaysException(ushort days) : base($"Value '{days}' is invalid travelDays")
        {
            this.Days = days;
        }
    }
}
