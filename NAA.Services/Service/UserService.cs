using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Services.IService;
using NAA.Data.Models.Domain;
using NAA.Data.Models.Repository;
using NAA.Data.IDAO;
using NAA.Data.DAO;

namespace NAA.Services.Service
{
    public class UserService : IUserService
    {
        private IUserDAO userDAO;
        private IApplicationDAO applicationDAO;
        public UserService()
        {
            userDAO = new UserDAO();
            applicationDAO = new ApplicationDAO();
        }
        public IList<User> GetUsers()
        {
            using (var context = new NAAContext())
            {
                return userDAO.GetUsers(context);
            }
        }
        public User GetUser(string userId)
        {
            using (var context = new NAAContext())
            {
                return userDAO.GetUser(userId, context);
            }
        }
        public User GetUserByEmailAddress(string emailAddress)
        {
            using (var context = new NAAContext())
            {
                return userDAO.GetUserByEmailAddress(emailAddress, context);
            }
        }
        public void AddUser(User user)
        {
            using (var context = new NAAContext())
            {
                userDAO.AddUser(user, context);
                context.SaveChanges();
            }
        }
        public void UpdateUser(User user)
        {
            using (var context = new NAAContext())
            {
                User existingUser = userDAO.GetUser(user.UserId, context);
                if (existingUser == null)
                {
                    userDAO.AddUser(user, context);
                }
                else
                {
                    userDAO.UpdateUser(user, context);
                }

                context.SaveChanges();
            }
        }

        public IList<Application> GetApplications(User user)
        {
            using (var context = new NAAContext())
            {
                return userDAO.GetApplications(context, user);
            }
        }

        public void DeleteUser(string userId)
        {
            using (var context = new NAAContext())
            {
                User user = GetUser(userId);
                foreach (var item in user.Applications)
                {
                    applicationDAO.DeleteApplication(context, item);
                }
                userDAO.DeleteUser(context, userId);
                context.SaveChanges();
            }
        }
    }
}
