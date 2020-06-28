using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Engagement : IDomainObject
    {
        public Member Member { get; set; }
        public Activity Activity { get; set; }
        public DateTime StartDate { get; set; }
        public List<Member> Members { get; set; }

        public string Table => "Engagement";

        public string InsertValues => $"{Member.ID}, {Activity.ID}, '{StartDate}'";

        public string UpdateValues => $"MemberID = {Member.ID}, ActivityID = {Activity.ID}, StartDate= '{StartDate}'";

        public string SearchId => $"where MemberID = {Member.ID} and ActivityID = {Activity.ID}";

        public string JoinFull => $" e join Member m on (e.MemberID = m.ID) join Activity a on (e.ActivityID = a.ID)";

        public string JoinWhere;

        public object ColumnId => "Id";

        public string SearchWhere { get; set; }

        public List<IDomainObject> GetReaderResult(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                Engagement e = new Engagement
                {
                    Member = new Member
                    {
                        ID = reader.GetInt32(0),
                        
                    },

                    Activity = new Activity
                    {
                        ID = reader.GetInt32(1),
                        
                    },
                    StartDate = reader.GetDateTime(2),
                };
                list.Add(e);
            }
            return list;
        }
        

        
        
        public List<IDomainObject> GetReaderResultJoin(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                Engagement e = new Engagement
                {
                    Member = new Member
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(4),
                        Surname = reader.GetString(5),
                        DateOfMembership = reader.GetDateTime(6),
                        NumberOfPoints = reader.GetInt32(7),
                        City = new City
                        {
                            ID = reader.GetInt32(8)
                        },
                        MembershipStatus = new MembershipStatus
                        {
                            ID = reader.GetInt32(9)
                        }
                    },

                    Activity = new Activity
                    {
                        ID = reader.GetInt32(1),
                        Name = reader.GetString(11),
                        NumberOfPoints = reader.GetInt32(12),
                        Description = reader.GetString(13),
                        City = new City
                        {
                            ID = reader.GetInt32(14)
                        },
                        Type = new TypeOfActivity
                        {
                            ID = reader.GetInt32(15)
                        }                     
                    },
                    StartDate = reader.GetDateTime(2), 
                };
                list.Add(e);
            }
            return list;
        }

        
    }
}
