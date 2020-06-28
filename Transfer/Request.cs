using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer
{
    [Serializable]
    public class Request
    {
      
    public object Object { get; set; }
    public Operation Operation { get; set; }
}

public enum Operation
{
    Login,
    AddMember,
    AddActivity,
    UpdateMember,
    UpdateActivity,
    DeleteMember,
    AddEngagement,
    ReturnCities,
    ReturnMembershipStatuses,
    ReturnTypesOfActivities,
    FindMembers,
        ReturnActivities,
        ReturnMembers,
        FindActivities,
        ReturnEngagements
    }
}
