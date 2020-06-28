using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Transfer;

namespace Client
{
    public class Communication
    {
        private static Communication instance;
        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();

        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }

        

        internal bool Connect()
        {
            try
            {
                if (socket == null || !socket.Connected)
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect("localhost", 9090);
                    stream = new NetworkStream(socket);
                }
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }

        

        private void SendRequest(Object obj, Operation operation)
        {
            Request request = new Request();
            request.Object = obj;
            request.Operation = operation;
         
            formatter.Serialize(stream, request);
            

}


        internal bool LoginUser(User u)
        {
            
                SendRequest(u, Operation.Login);
                Response r = (Response)formatter.Deserialize(stream);
                if (r.Signal.Equals(Signal.Ok)) return true;
                else return false;
           
            
        }       

        internal List<MembershipStatus> ReturnMembershipStatuses()
        {
            SendRequest(null, Operation.ReturnMembershipStatuses);
            Response r = (Response)formatter.Deserialize(stream);
            return (List<MembershipStatus>)r.Object;
        }

        internal string AddMember(Member member)
        {
            SendRequest(member, Operation.AddMember);
            Response r = (Response)formatter.Deserialize(stream);
            return r.Message;

        }

        internal string AddEngagement(Engagement engagement)
        {
            SendRequest(engagement, Operation.AddEngagement);
            Response r = (Response)formatter.Deserialize(stream);
            return r.Message;
        }

        internal List<EngagementHelper> ReturnEngagements()
        {
            SendRequest(null, Operation.ReturnEngagements);
            Response r = (Response)formatter.Deserialize(stream);
            return (List<EngagementHelper>)r.Object;
        }

        internal string UpdateActivity(Activity activity)
        {
            SendRequest(activity, Operation.UpdateActivity);
            Response r = (Response)formatter.Deserialize(stream);
            return r.Message;
        }

        internal string UpdateMember(Member member)
        {
            SendRequest(member, Operation.UpdateMember);
            Response r = (Response)formatter.Deserialize(stream);
            return r.Message;
        }

        internal List<City> ReturnCities()
        {
            SendRequest(null, Operation.ReturnCities);
            Response r = (Response)formatter.Deserialize(stream);
            return (List<City>)r.Object;
        }

        internal List<TypeOfActivity> ReturnTypes()
        {
            SendRequest(null, Operation.ReturnTypesOfActivities);
            Response r = (Response)formatter.Deserialize(stream);
            return (List<TypeOfActivity>)r.Object;
        }

        internal string AddActivity(Activity activity)
        {
            SendRequest(activity, Operation.AddActivity);
            Response r = (Response)formatter.Deserialize(stream);
            return r.Message;
        }

        internal List<Member> FindMembers(Member member)
        {
            SendRequest(member, Operation.FindMembers);
            Response r = (Response)formatter.Deserialize(stream);
            MessageBox.Show(r.Message);
            return (List<Member>)r.Object;
        }

        internal List<Activity> FindActivities(Activity activity)
        {
            SendRequest(activity, Operation.FindActivities);
            Response r = (Response)formatter.Deserialize(stream);
            MessageBox.Show(r.Message);
            return (List<Activity>)r.Object;
        }

        internal string DeleteMember(Member member)
        {
            SendRequest(member, Operation.DeleteMember);
            Response r = (Response)formatter.Deserialize(stream);
            return r.Message;
        }

        internal List<Member> ReturnMembers()
        {
            SendRequest(null, Operation.ReturnMembers);
            Response r = (Response)formatter.Deserialize(stream);
            return (List<Member>)r.Object;
        }

        internal List<Activity> ReturnActivities()
        {
            SendRequest(null, Operation.ReturnActivities);
            Response r = (Response)formatter.Deserialize(stream);
            return (List<Activity>)r.Object;
        }
    }
}
