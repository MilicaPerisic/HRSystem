using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Member : IDomainObject
    {
        [Browsable(false)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfMembership{ get; set; }
        public int NumberOfPoints { get; set; }
        public City City { get; set; }
        public MembershipStatus MembershipStatus { get; set; }

        [Browsable(false)]
        public string Table => "Member";
        [Browsable(false)]
        public string InsertValues => $"'{Name}', '{Surname}', '{DateOfMembership}', {NumberOfPoints}, {City.ID}, {MembershipStatus.ID}";
        [Browsable(false)]
        public string UpdateValues => $"Name = '{Name}', Surname = '{Surname}', DateOfMembership = '{DateOfMembership}', NumberOfPoints= {NumberOfPoints}, City = {City.ID}, MembershipStatus = {MembershipStatus.ID}";
        [Browsable(false)]
        public string SearchId => $"ID = {ID}";
        [Browsable(false)]
        public string JoinFull => $"m join City c on (m.City = c.ID) join MembershipStatus ms on (m.MembershipStatus = ms.ID)";
        [Browsable(false)]
        public string JoinWhere;
        [Browsable(false)]
        public object ColumnId => "Id";
        [Browsable(false)]
        public string SearchWhere { get; set; }

        public List<IDomainObject> GetReaderResult(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                Member m = new Member
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Surname = reader.GetString(2),
                    DateOfMembership = reader.GetDateTime(3),
                    NumberOfPoints = reader.GetInt32(4),
                    City = new City
                    {
                        ID = reader.GetInt32(4),
                        
                    },
                    MembershipStatus = new MembershipStatus
                    {
                        ID = reader.GetInt32(6),
                    }
                };
                list.Add(m);
            }
            return list;
        }

        public List<IDomainObject> GetReaderResultJoin(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                Member m = new Member
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Surname = reader.GetString(2),
                    DateOfMembership = reader.GetDateTime(3),
                    NumberOfPoints = reader.GetInt32(4),
                    City = new City
                    {
                        ID = reader.GetInt32(5),
                        Name = reader.GetString(8)
                    },
                    MembershipStatus = new MembershipStatus
                    {
                        ID = reader.GetInt32(6),
                        Name = reader.GetString(10)
                    }
                };
                list.Add(m);
            }
            return list;
        }

        

        public override string ToString()
        {
            return this.Name + " " + this.Surname;
        }
    }
}
