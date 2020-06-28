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
    public class Activity : IDomainObject
    {
        [Browsable(false)]
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfPoints { get; set; }
        public string Description { get; set; }
        public City City { get; set; }
        public TypeOfActivity Type { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

        [Browsable(false)]
        public Activity Self { get { return this; } }
        [Browsable(false)]
        public string Table => "Activity";
        [Browsable(false)]
        public string InsertValues => $"'{Name}', {NumberOfPoints}, '{Description}', {City.ID}, {Type.ID}";
        [Browsable(false)]
        public string UpdateValues => $"Name = '{Name}', NumberOfPoints = {NumberOfPoints}, Description = '{Description}', City = {City.ID}, TypeOfActivity = {Type.ID}";
        [Browsable(false)]
        public string JoinFull => $" a join City c on (a.City = c.ID) join TypeOfActivity t on (a.TypeOfActivity = t.ID)";
        [Browsable(false)]
        public string JoinWhere;
        [Browsable(false)]
        public string SearchId => $"ID = {ID}";
        [Browsable(false)]
        public object ColumnId => "Id";
        [Browsable(false)]
        public string SearchWhere { get; set; }

        public List<IDomainObject> GetReaderResultJoin(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                Activity a = new Activity
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    NumberOfPoints = reader.GetInt32(2),
                    Description = reader.GetString(3),
                    City = new City
                    {
                        
                        ID = reader.GetInt32(4),
                        Name = reader.GetString(7)
                    },
                    Type = new TypeOfActivity
                    {
                        ID = reader.GetInt32(5),
                        Name = reader.GetString(9)
                    }
                };
                list.Add(a);
            }
            return list;
        }

        public List<IDomainObject> GetReaderResult(SqlDataReader reader)
        {
            List<IDomainObject> list = new List<IDomainObject>();
            while (reader.Read())
            {
                Activity a = new Activity
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    NumberOfPoints = reader.GetInt32(2),
                    Description = reader.GetString(3),
                    City = new City
                    {
                        ID = reader.GetInt32(4),
                        
                    },
                    Type = new TypeOfActivity
                    {
                        ID = reader.GetInt32(5),
                       
                    }
                };
                list.Add(a);
            }
            return list;
        }

    }
}
