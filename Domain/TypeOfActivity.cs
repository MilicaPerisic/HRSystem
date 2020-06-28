using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class TypeOfActivity : IDomainObject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Table => "TypeOfActivity";

        public string InsertValues => $"'{Name}'";

        public string UpdateValues => $"Name = '{Name}'";

        public string SearchId => $"where Id = {ID}";

        public string JoinFull => "";

        public object ColumnId => "Id";

        public string SearchWhere { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<IDomainObject> GetReaderResult(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                TypeOfActivity t = new TypeOfActivity
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),

                };
                list.Add(t);
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
