using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class City : IDomainObject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Table => "City";

        public string InsertValues => $"{ID}, '{Name}'";

        public string UpdateValues => $"ID = {ID}, Name = '{Name}'";

        public string SearchId => $"where Id = {ID}";

        public string JoinFull => "";

        public object ColumnId => "Id";

        public string SearchWhere { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<IDomainObject> GetReaderResult(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                City c = new City
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),

                };
                list.Add(c);
            }
            return list;
        }

        public List<IDomainObject> GetReaderResultJoin(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        

        public override string ToString()
        {
            return this.Name;
        }

        
    }
}
