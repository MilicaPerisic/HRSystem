using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class AddEngagementSO : AbstractGenericOperation
    {
        protected override object Execute(IDomainObject entity)
        {
            Engagement e = (Engagement)entity;
            bool success = false;
            foreach (Member m in e.Members)
            {
                e.Member = m;
                Console.WriteLine(e);
                if (broker.Insert(e) == 0)
                {
                    success = false;
                }
                else
                {
                    success = true;
                }
                
            }
            // to do: azurirati clanove zbog broja poena
            return success;
        }

        protected override void Validate(IDomainObject entity)
        {
            if (!(entity is Engagement))
            {
                throw new ArgumentException();
            }
        }
    }
}
