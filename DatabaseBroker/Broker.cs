using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DatabaseBroker
{
    public class Broker
    {

        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HRSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public int Update(IDomainObject entity)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.Transaction = transaction;

            command.CommandText = $"update {entity.Table} set {entity.UpdateValues} where {entity.SearchId}";
            Console.WriteLine(command.CommandText);
            return command.ExecuteNonQuery();
        }

        public int Delete(IDomainObject entity)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.Transaction = transaction;
            command.CommandText = $"delete from {entity.Table} where ({entity.SearchId})";
            Console.WriteLine(command.CommandText);
            return command.ExecuteNonQuery();
        }

        public List<IDomainObject> SelectJoin(IDomainObject entity)
        {
            SqlCommand command = new SqlCommand();
            command.Transaction = transaction;
            command.Connection = connection;

            command.CommandText = $"select * from {entity.Table} {entity.JoinFull} {entity.SearchWhere}";
            Console.WriteLine(command.CommandText);
            SqlDataReader reader = command.ExecuteReader();
            List<IDomainObject> entities = entity.GetReaderResultJoin(reader);
            reader.Close();
            return entities;
        }

        public List<IDomainObject> Select(IDomainObject entity)
        {
            SqlCommand command = new SqlCommand();
            command.Transaction = transaction;
            command.Connection = connection;
            command.CommandText = $"select * from {entity.Table}";
            SqlDataReader reader = command.ExecuteReader();
            List<IDomainObject> entities = entity.GetReaderResult(reader);
            reader.Close();
            return entities;
        }

        public int Insert(IDomainObject entity)
        {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandText = $"insert into {entity.Table} values ({entity.InsertValues})";
                return command.ExecuteNonQuery();
           
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void CommitTransaction()
        {
            transaction.Commit();
        }

        public void RollbackTransaction()
        {
            transaction.Rollback();
        }


    }
}
