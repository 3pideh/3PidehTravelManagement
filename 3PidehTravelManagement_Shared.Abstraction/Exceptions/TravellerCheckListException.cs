using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Shared.Abstraction.Exceptions
{
    public abstract class TravellerCheckListException : Exception
    {
        public TravellerCheckListException(string message) : base(message)
        {

        }
    }
}
