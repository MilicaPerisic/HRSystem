using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class StorageUser
    {
        private List<User> users;
        public StorageUser()
        {
            users = new List<User>() {
                new User {
                Username = "milica",
                Password = "123"

            }

         };
        }


        public List<User> ReturnUsers()
        {
            return users;
        }
    }
    } 
