using _3PidehTravelManagement_Shared.Abstraction.Exceptions;
using System.Runtime.Serialization;

namespace _3PidehTravelManagement_Domain.Exceptions
{
    [Serializable]
    internal class TravellerCheckListNameException : TravellerCheckListException
    {
        

        public TravellerCheckListNameException() : base("Travel check list name can not be null or empty")
        {
        }

        
    }
}