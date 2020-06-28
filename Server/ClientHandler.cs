using Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Transfer;

namespace Server
{
    class ClientHandler
    {
        private Socket clientSocket;
        private NetworkStream stream;
        private BinaryFormatter formatter;
        private List<Socket> connectedClients;
        public ClientHandler(Socket clientSocket, List<Socket> connectedClients)
        {
            this.clientSocket = clientSocket;
            this.stream = new NetworkStream(clientSocket);
            formatter = new BinaryFormatter();
            this.connectedClients = connectedClients;

            Thread clientThread = new Thread(HandleRequest);
            clientThread.IsBackground = true;
            clientThread.Start();
        }

        private void HandleRequest()
        {
            bool end = false;
            while (!end)
            {
                try
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response = null;
                    switch (request.Operation)
                    {
                        case Operation.Login:
                            response = Login((User)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.AddActivity:
                            response = AddActivity((Activity)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.AddMember:
                            response = AddMember((Member)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.AddEngagement:
                            response = AddEngagement((Engagement)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.DeleteMember:
                            response = DeleteMember((Member)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.FindMembers:
                            response = FindMembers((Member)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.FindActivities:
                            response = FindActivities((Activity)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.UpdateActivity:
                            response = UpdateActivity((Activity)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.UpdateMember:
                            response = UpdateMember((Member)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.ReturnCities:
                            response = ReturnCities();
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.ReturnMembershipStatuses:
                            response = ReturnMembershipStatuses();
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.ReturnTypesOfActivities:
                            response = ReturnTypesOfActivities();
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.ReturnMembers:
                            response = ReturnMembers();
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.ReturnActivities:
                            response = ReturnActivities();
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.ReturnEngagements:
                            response = ReturnEngagemnts();
                            formatter.Serialize(stream, response);
                            break;
                        default:
                            Response r = new Response();
                            r.Signal = Signal.Error;
                            formatter.Serialize(stream, r);

                            break;
                    }
                }
                catch (SocketException)
                {
                    end = true;
                    connectedClients.Remove(clientSocket);

                }
                catch (IOException)
                {
                    end = true;
                    connectedClients.Remove(clientSocket);

                }
            }

        }

        private Response ReturnEngagemnts()
        {
            List<EngagementHelper> engagements = new List<EngagementHelper>();
            Response r = new Response();
            engagements = Controller.Controller.Instance.ReturnEngagements();
            if (engagements is null)
            {
                return createResponse(Signal.Error, "Greska prilikom preuzimanja angazovanja.", engagements);
            }
            return createResponse(Signal.Ok, "Lista angazovanja ucitana!", engagements);
        }

        private Response FindActivities(Activity activity)
        {
            List<Activity> activities = new List<Activity>();
            Response r = new Response();
            activities = Controller.Controller.Instance.FindActivities(activity);
            if (activities is null) return createResponse(Signal.Error, "Greska prilikom pronalazenja clanova sa zadatim kriterijumima.", activities);

            if (activities.Count == 0)
            {
                return createResponse(Signal.Ok, "Ne postoje aktivnosti sa zadatim kriterijumima.", activities);
            }
            return createResponse(Signal.Ok, "Aktivnosti su pronadjene.", activities);
        }

        private Response ReturnActivities()
        {
            List<Activity> activities = new List<Activity>();
            Response r = new Response();
            activities = Controller.Controller.Instance.ReturnActivities();
            if (activities is null)
            {
                return createResponse(Signal.Error, "Greska prilikom preuzimanja aktivnosti.", activities);
            }
            return createResponse(Signal.Ok, "Lista aktivnosti ucitana!", activities);
        }

        private Response ReturnMembers()
        {
            List<Member> members = new List<Member>();
            Response r = new Response();
            members = Controller.Controller.Instance.ReturnMembers();
            if (members is null)
            {
                return createResponse(Signal.Error, "Greska prilikom preuzimanja clanova.", members);
            }
            return createResponse(Signal.Ok, "Lista clanova ucitana!", members);
        }

        private Response ReturnTypesOfActivities()
        {
            List<TypeOfActivity> types = new List<TypeOfActivity>();
            Response r = new Response();
            types = Controller.Controller.Instance.ReturnTypesOfActivities();
            if (types is null)
            {
                return createResponse(Signal.Error, "Greska prilikom preuzimanja tipova aktivnosti.", types);
            }
            return createResponse(Signal.Ok, "Lista tipova aktivnosti ucitana!", types);
        }

        private Response ReturnMembershipStatuses()
        {
            List<MembershipStatus> statuses = new List<MembershipStatus>();
            Response r = new Response();
            statuses = Controller.Controller.Instance.ReturnMembershipStatuses();
            if (statuses is null) return createResponse(Signal.Error, "Greska prilikom preuzimanja statusa clanstva.", statuses);

            return createResponse(Signal.Ok, "Lista statusa clanstva ucitana!", statuses);
        }

        private Response ReturnCities()
        {
            List<City> cities = new List<City>();
            Response r = new Response();
            cities = Controller.Controller.Instance.ReturnCities();
            if (cities is null) return createResponse(Signal.Error, "Greska prilikom preuzimanja mesta.", cities);

            return createResponse(Signal.Ok, "Lista gradova ucitana!", cities);
        }

        private Response UpdateMember(Member member)
        {
            Response r = new Response();
            if (Controller.Controller.Instance.UpdateMember(member))
            {
                return createResponse(Signal.Ok, "Uspesno ste izmenili clana.", member);
            }
            return createResponse(Signal.Error, "Sistem ne moze da izmeni clana.", member);
        }

        private Response UpdateActivity(Activity activity)
        {
            Response r = new Response();
            if (Controller.Controller.Instance.UpdateActivity(activity))
            {
                return createResponse(Signal.Ok, "Uspesno ste izmenili aktivnost.", activity);
            }
            return createResponse(Signal.Error, "Sistem ne moze da izmeni aktivnost.", activity);
        }

        private Response FindMembers(Member member)
        {
            List<Member> members = new List<Member>();
            Response r = new Response();
            members = Controller.Controller.Instance.FindMembers(member);
            if (members is null) return createResponse(Signal.Error, "Greska prilikom pronalazenja clanova sa zadatim kriterijumima.", members);

            if(members.Count == 0)
            {
                return createResponse(Signal.Ok, "Ne postoje clanovi sa zadatim kriterijumima.", members);
            } 
            return createResponse(Signal.Ok, "Clanovi su pronadjeni.", members);
        }

        private Response DeleteMember(Member member)
        {
            if (Controller.Controller.Instance.DeleteMember(member))
            {
                return createResponse(Signal.Ok, "Clan je uspesno obrisan!", member);
            }
            return createResponse(Signal.Error, "Doslo je do greske prilikom brisanja clana.", member);
        }

        private Response AddEngagement(Engagement engagement)
        {
            Response r = new Response();
            if (Controller.Controller.Instance.AddEngagement(engagement))
            {
                return createResponse(Signal.Ok, "Uspesno ste uneli angazovanje za clanove..", engagement);
            }
            return createResponse(Signal.Error, "Sistem ne moze da unese angazovanje.", engagement);
        }

        private Response AddMember(Member member)
        {
            Response r = new Response();
            if (Controller.Controller.Instance.AddMember(member))
            {
                return createResponse(Signal.Ok, "Uspesno ste uneli clana.", member);
            }
            return createResponse(Signal.Error, "Sistem ne moze da unese clana.", member);
        }

        private Response AddActivity(Activity activity)
        {
            Response r = new Response();
            if (Controller.Controller.Instance.AddActivity(activity))
            {
                return createResponse(Signal.Ok, "Uspesno ste uneli aktivnost.", activity);
            }
            return createResponse(Signal.Error, "Sistem ne moze da unese aktivnost.", activity);
        }

        private Response Login(User u)
        {
            if (Controller.Controller.Instance.LoginUser(u))
            {
                return createResponse(Signal.Ok, "Uspesno ste se prijavili!", u);
            }
            return createResponse(Signal.Error, "Pogresno ste uneli neki parametar", u);
        }

        private Response createResponse(Signal signal, string message, Object obj)
        {
            Response r = new Response();
            r.Object = obj;
            r.Message = message;
            r.Signal = signal;
            return r;
        }
    }
    }

