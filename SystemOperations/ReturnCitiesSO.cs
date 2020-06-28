using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class ReturnCitiesSO : AbstractGenericOperation
    {

        protected override object Execute(IDomainObject entity)
        {
            City c = (City)entity;
            List<City> cities = broker.Select(entity).OfType<City>().ToList();
            return cities;
        }

        protected override void Validate(IDomainObject entity)
        {
            if (!(entity is City))
            {
                throw new ArgumentException();
            }
        }
    }
}
