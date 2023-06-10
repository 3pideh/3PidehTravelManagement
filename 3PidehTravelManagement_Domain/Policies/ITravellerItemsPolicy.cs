using _3PidehTravelManagement_Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Domain.Policies
{
    public interface ITravellerItemsPolicy
    {
        bool IsApplicable(PolicyData policy);
        IEnumerable<TravellerItem> GenerateItems(PolicyData policy);
    }
}
