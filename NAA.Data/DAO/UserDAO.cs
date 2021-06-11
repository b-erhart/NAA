using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return context.Users.Include(u => u.Applications).ToList();
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

        public void AddApplicationToCollection(NAAContext context, Application application, string userId)
        {
            context.Users.Find(userId).Applications.Add(application);
        }

        public IList<Application> GetApplications(NAAContext context, User user)
        {
            return context.Users.Find(user.UserId).Applications.ToList();
        }
        public void RemoveUser(User user, NAAContext context)
        {
            user = context.Users.Find(user.UserId);
            context.Users.Remove(user);
        }
        public void UpdateUser(User user, NAAContext context)
        {
            User dbUser = GetUser(user.UserId, context);
            context.Entry(dbUser).CurrentValues.SetValues(user);
        }

        public void RemoveApplicationFromCollection(NAAContext context, string userId, Application application)
        {
            context.Users.Find(userId).Applications.Remove(application);
        }
    }
}
