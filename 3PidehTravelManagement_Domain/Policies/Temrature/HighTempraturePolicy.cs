using _3PidehTravelManagement_Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.Policies.Temrature
{
    public class HighTempraturePolicy : ITravellerItemsPolicy
    {
        public IEnumerable<TravellerItem> GenerateItems(PolicyData policy)
         => new List<TravellerItem>
         {
                new("Sandal",1) ,
                new("SunOil",1) ,
                new("Cap",1)
         };



        public bool IsApplicable(PolicyData data)
               => data.Tempreture > 100 ;

    }
}
