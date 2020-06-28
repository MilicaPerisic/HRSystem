using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class UpdateMemberSO : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            Member m = (Member)entity;
            if (broker.Update(entity) > 0)
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
