﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.IDAO;
using NAA.Data.Models.Domain;
using NAA.Data.Models.Repository;

namespace NAA.Data.DAO
{
    public class UserDAO : IUserDAO
    {
        public IList<User> GetUsers(NAAContext context)
        {
            return context.Users.ToList();
        }
        public User GetUser(string userId, NAAContext context)
        {
            return context.Users.Find(userId);
        }
        public User GetUserByEmailAddress(string emailAddress, NAAContext context)
        {
            IQueryable<User> user = from u
                                    in context.Users
                                    where u.Email == emailAddress
                                    select u;

            return user.ToList().First();
        }
        public void AddUser(User user, NAAContext context)
        {
            context.Users.Add(user);
        }

        public void AddApplicationToCollection(NAAContext context, Application application)
        {
            context.Applications.Add(application);
        }
    }
}
