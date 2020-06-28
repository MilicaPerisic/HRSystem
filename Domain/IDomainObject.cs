using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDomainObject
    {
        string Table { get; }
        string InsertValues { get; }
        string UpdateValues { get; }
        string SearchWhere { get; set; }
        string SearchId { get; }
        string JoinFull { get; }
        object ColumnId { get; }
        List<IDomainObject> GetReaderResultJoin(SqlDataReader reader);
        List<IDomainObject> GetReaderResult(SqlDataReader reader);
    }
}
