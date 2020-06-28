using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class ReturnEngagementsSO : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            EngagementHelper e = (EngagementHelper)entity;
            List<EngagementHelper> engagements = broker.Select(entity).OfType<EngagementHelper>().ToList();
            return engagements;
        }

        protected override void Validate(IDomainObject entity)
        {
            if (!(entity is EngagementHelper))
            {
                throw new ArgumentException();
            }
        }
    }
}
