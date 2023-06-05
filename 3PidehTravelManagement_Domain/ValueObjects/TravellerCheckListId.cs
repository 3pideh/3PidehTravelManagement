using _3PidehTravelManagement_Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.ValueObjects
{
    public record TravellerCheckListId
    {
        public Guid Value { get; }

        public TravellerCheckListId(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new TravellerCheckListIdException();
            }

            Value = value;
        }

        public static implicit operator Guid(TravellerCheckListId id) => id.Value ;

        public static implicit operator TravellerCheckListId(Guid id) => new(id);

    }
}
