using _3PidehTravelManagement_Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.Policies.Temrature
{
    public class LowTempraturePolicy : ITravellerItemsPolicy
    {
        public IEnumerable<TravellerItem> GenerateItems(PolicyData policy)
         => new List<TravellerItem>
         {
                new("Coat",1) ,
                new("Umbrella",1) ,
                new("Turtleneck",1)
         };



        public bool IsApplicable(PolicyData data)
               => data.Tempreture < 100 ;

    }
}
