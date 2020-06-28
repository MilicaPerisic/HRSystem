using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class ReturnActivitiesSO : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            Activity a= (Activity)entity;
            List<Activity> activities = broker.Select(entity).OfType<Activity>().ToList();
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
