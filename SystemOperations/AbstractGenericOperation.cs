using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DatabaseBroker;

namespace SystemOperations
{
    public abstract class AbstractGenericOperation
    {
        protected abstract object Execute(IDomainObject entity);
        protected abstract void Validate(IDomainObject entity);
        protected Broker broker = new Broker();

        public object ExecuteSO(IDomainObject entity)
        {
            object res = null;

            try
            {
                Validate(entity);
                broker.OpenConnection();
                broker.BeginTransaction();

                res = Execute(entity);
   
                broker.CommitTransaction();
            }
            catch (Exception)
            {
                broker.RollbackTransaction();
            }
            finally
            {
                broker.CloseConnection();
            }

            return res;
        }


        
    }
}
