using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class FindMembersSO : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            Member member = (Member)entity;
            List<Member> members = broker.SelectJoin(entity).OfType<Member>().ToList();
            return members;
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
