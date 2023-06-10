using _3PidehTravelManagement_Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _3PidehTravelManagement_Domain.Policies.Universall
{
    internal class BasicPolicy : ITravellerItemsPolicy
    {
        public IEnumerable<TravellerItem> GenerateItems(PolicyData policy)
        
           => new List<TravellerItem>
            {
                new("Trousers",policy.TravelDays < 7 ? 1u : 4u ) ,
                new("ToothBrush",1),
                new("Shoe",1),
               new("Shirt",1),
               new("Bottlewater",1 )
            };

        

        public bool IsApplicable(PolicyData policy)
        => true;
    }
}
