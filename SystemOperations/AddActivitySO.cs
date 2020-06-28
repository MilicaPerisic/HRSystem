using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class AddActivitySO : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            Activity a = (Activity)entity;
            if (broker.Insert(entity) > 0)
            {
                return true;
            }
            return false;
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
