using _3PidehTravelManagement_Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.ValueObjects
{
    public record Tempreture
    {
        public double Value { get; }

        public Tempreture(double value)
        {
            if(value is < -100 or > 100)
            {
                throw new InvalidTempretureException(value);
            }
        }

        public static implicit operator double(Tempreture tempreture) => tempreture.Value;

        public static implicit operator Tempreture(double tempreture) => new(tempreture);
    }
}
