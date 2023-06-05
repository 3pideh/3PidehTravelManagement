using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PidehTravelManagement_Shared.Abstraction.Domain
{
    public abstract class AggregateRoot<T>
    {
        public T Id { get; set; }
        public int Version { get; set; }
        public bool _versionInvremented { get; set; }

        protected void IncrementedVersion()
        {
            if (_versionInvremented)
            {
                return;
            }
            _versionInvremented = true;
        }
    }
}
