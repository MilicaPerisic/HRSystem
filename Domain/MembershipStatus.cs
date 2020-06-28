using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class MembershipStatus : IDomainObject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Table => "MembershipStatus";

        public string InsertValues => $"{ID}, '{Name}'";

        public string UpdateValues => $"ID = {ID}, Name = '{Name}'";

        public string SearchId => $"where Id = {ID}";

        public string JoinFull => "";

        public object ColumnId => "Id";

        public List<IDomainObject> GetReaderResult(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                MembershipStatus m = new MembershipStatus
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),

                };
                list.Add(m);
            }
            return list;
        }

        public List<IDomainObject> GetReaderResultJoin(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string SearchWhere => "";

        string IDomainObject.SearchWhere { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
