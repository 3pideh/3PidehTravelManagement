using _3PidehTravelManagement_Shared.Abstraction.Exceptions;
using System.Runtime.Serialization;

namespace _3PidehTravelManagement_Domain.Exceptions
{
    [Serializable]
    internal class TravellerItemNameException : TravellerCheckListException
    {
        

        public TravellerItemNameException() : base("Travel item name can not be null or empty")
        {
        }

        
    }
}