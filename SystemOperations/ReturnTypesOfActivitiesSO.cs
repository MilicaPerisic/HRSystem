using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class ReturnTypesOfActivitiesSO : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            TypeOfActivity t = (TypeOfActivity)entity;
            List<TypeOfActivity> types = broker.Select(entity).OfType<TypeOfActivity>().ToList();
            return types;
        }

        protected override void Validate(IDomainObject entity)
        {
            if (!(entity is TypeOfActivity))
            {
                throw new ArgumentException();
            }
        }
    }
}
