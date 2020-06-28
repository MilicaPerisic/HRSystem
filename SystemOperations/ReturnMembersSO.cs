using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class ReturnMembersSO : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            Member m = (Member)entity;
            List<Member> member = broker.Select(entity).OfType<Member>().ToList();
            return member;
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
