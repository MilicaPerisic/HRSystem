using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseBroker;
using Domain;
using Storage;
using SystemOperations;


namespace Controller
{
    public class Controller
    {
        private Broker broker = new Broker();
        private static Controller _instance;
        public static Controller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Controller();
                }
                return _instance;
            }
        }
        private Controller()
        {
        }

        public bool LoginUser(User u)
        {
            StorageUser storage = new StorageUser();
            List<User> users = storage.ReturnUsers();

            if (users.SingleOrDefault((user) => (user.Username == u.Username && user.Password == u.Password)) is null) return false;
            return true;
        }

        public bool AddMember(Member member)
        {
            AbstractGenericOperation ado = new AddMemberSO();
            bool success = (bool)ado.ExecuteSO(member);
            return success;
        }

        public List<City> ReturnCities()
        {
            AbstractGenericOperation ado = new ReturnCitiesSO();
            List<City> cities = (List<City>)ado.ExecuteSO(new City());
            return cities;
        }

        public List<MembershipStatus> ReturnMembershipStatuses()
        {
            AbstractGenericOperation ado = new ReturnMembershipStatusesSO();
            List<MembershipStatus> statuses = (List<MembershipStatus>)ado.ExecuteSO(new MembershipStatus());
            return statuses;
        }

        public List<TypeOfActivity> ReturnTypesOfActivities()
        {
            AbstractGenericOperation ado = new ReturnTypesOfActivitiesSO();
            List<TypeOfActivity> types = (List<TypeOfActivity>)ado.ExecuteSO(new TypeOfActivity());
            return types;
        }

        public bool AddActivity(Activity activity)
        {
            AbstractGenericOperation ado = new AddActivitySO();
            bool success = (bool)ado.ExecuteSO(activity);
            return success;
        }

        public List<Member> FindMembers(Member member)
        {
            AbstractGenericOperation ado = new FindMembersSO();
            List<Member> members = (List<Member>)ado.ExecuteSO(member);
            return members;
        }

        public bool DeleteMember(Member member)
        {
            AbstractGenericOperation ado = new DeleteMemberSO();
            bool success = (bool)ado.ExecuteSO(member);
            return success;
        }

        public List<Member> ReturnMembers()
        {
            AbstractGenericOperation ado = new ReturnMembersSO();
            List<Member> members = (List<Member>)ado.ExecuteSO(new Member());
            return members;
        }

        public List<Activity> ReturnActivities()
        {
            AbstractGenericOperation ado = new ReturnActivitiesSO();
            List<Activity> activities = (List<Activity>)ado.ExecuteSO(new Activity());
            return activities;
        }

        public bool AddEngagement(Engagement engagement)
        {
            AbstractGenericOperation ado = new AddEngagementSO();
            bool success = (bool)ado.ExecuteSO(engagement);
            return success;
        }

        public bool UpdateMember(Member member)
        {
            AbstractGenericOperation ado = new UpdateMemberSO();
            bool success = (bool)ado.ExecuteSO(member);
            return success;
        }

        public List<Activity> FindActivities(Activity activity)
        {
            AbstractGenericOperation ado = new FindActivitiesSO();
            List<Activity> activities = (List<Activity>)ado.ExecuteSO(activity);
            return activities;
        }

        public bool UpdateActivity(Activity activity)
        {
            AbstractGenericOperation ado = new UpdateActivitySO();
            bool success = (bool)ado.ExecuteSO(activity);
            return success;
        }

        public List<EngagementHelper> ReturnEngagements()
        {
            AbstractGenericOperation ado = new ReturnEngagementsSO();
            List<EngagementHelper> engagements = (List<EngagementHelper>)ado.ExecuteSO(new EngagementHelper());
            Console.WriteLine(engagements.ElementAt(0));
            return engagements;
        }
    }
}
