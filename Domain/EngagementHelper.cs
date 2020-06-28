using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class EngagementHelper : IDomainObject
    {
        public int MemberID { get; set; }
        public int ActivityID { get; set; }
        public DateTime StartDate { get; set; }

        public string Table => "Engagement";

        public string InsertValues => $"{MemberID}, {ActivityID}, '{StartDate}'";

        public string UpdateValues => $"MemberID = {MemberID}, ActivityID = {ActivityID}, StartDate= '{StartDate}'";

        public string SearchId => $"where MemberID = {MemberID} and ActivityID = {ActivityID}";

        public string JoinFull => $" e join Member m on (e.MemberID = m.ID) join Activity a on (e.ActivityID = a.ID)";

        public string JoinWhere;

        public object ColumnId => "Id";

        public string SearchWhere { get; set; }

        public List<IDomainObject> GetReaderResult(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                EngagementHelper e = new EngagementHelper
                {
                    MemberID = reader.GetInt32(0),
                    ActivityID = reader.GetInt32(1),
                    StartDate = reader.GetDateTime(2),
                };
                list.Add(e);
            }
            return list;
        }




        public List<IDomainObject> GetReaderResultJoin(SqlDataReader reader)
        {
            throw new NotImplementedException();


        }
    }
}
