using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class ReturnMembershipStatusesSO : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            MembershipStatus ms = (MembershipStatus)entity;
            List<MembershipStatus> statuses = broker.Select(entity).OfType<MembershipStatus>().ToList();
            return statuses;
        }

        protected override void Validate(IDomainObject entity)
        {
            if (!(entity is MembershipStatus))
            {
                throw new ArgumentException();
            }
        }
    }
}
