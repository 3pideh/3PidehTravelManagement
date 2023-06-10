using _3PidehTravelManagement_Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.Exceptions
{
    internal class InvalidTempretureException : Exception
    {
        public double Value { get; }
        public InvalidTempretureException(double value) : base($"Value '{value}' is invalid tempreture")
        {
            Value = value;
        }
    }
}
