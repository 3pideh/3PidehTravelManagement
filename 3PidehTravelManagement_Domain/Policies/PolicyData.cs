using _3PidehTravelManagement_Domain.Consts;
using _3PidehTravelManagement_Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.Policies
{
    public record PolicyData(TravelDays TravelDays , Gender Gender , Destination Destination , Tempreture Tempreture);
    
    
}
