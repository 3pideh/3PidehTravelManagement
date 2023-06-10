using _3PidehTravelManagement_Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.Policies.Gender
{
    public sealed class MaleGenderPolicy : ITravellerItemsPolicy
    {

        public IEnumerable<TravellerItem> GenerateItems(PolicyData policy)
            => new List<TravellerItem>
            {
                new("Tie",1) ,
                new("Bow",1)
            };
        


        public bool IsApplicable(PolicyData data)
               => data.Gender is Consts.Gender.Male;
      
        
    }
}
