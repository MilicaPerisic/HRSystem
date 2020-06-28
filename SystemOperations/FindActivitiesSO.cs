using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class FindActivitiesSO : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            Activity activity = (Activity)entity;
            List<Activity> activities = broker.SelectJoin(entity).OfType<Activity>().ToList();
            return activities;
        }

        protected override void Validate(IDomainObject entity)
        {
            if (!(entity is Activity))
            {
                throw new ArgumentException();
            }
        }
    }
}
