using _3PidehTravelManagement_Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.Exceptions
{
    public class TravellerCheckListIdException : TravellerCheckListException
    {
        public TravellerCheckListIdException(): base("Id can not be empty")
        {

        }
    }
}
