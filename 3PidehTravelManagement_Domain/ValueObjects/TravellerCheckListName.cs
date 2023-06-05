using _3PidehTravelManagement_Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.ValueObjects
{
    public record TravellerCheckListName
    {
        public string Value { get; }

        public TravellerCheckListName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new TravellerCheckListNameException();
            }

            Value = value;
        }

        public static implicit operator string(TravellerCheckListName name) => name.Value;

        public static implicit operator TravellerCheckListName(string name) => new(name);
    }
}
