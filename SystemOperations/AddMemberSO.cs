using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class AddMemberSO : AbstractGenericOperation
    {
      

        protected override object Execute(IDomainObject entity)
        {
            Member m = (Member)entity;
            if (broker.Insert(entity) > 0)
            {
                return true;
            }
            return false;
        }

        protected override void Validate(IDomainObject entity)
        {
            if (!(entity is Member))
            {
                throw new ArgumentException();
            }
        }
    }
}
