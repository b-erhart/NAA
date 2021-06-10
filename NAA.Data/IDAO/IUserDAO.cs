using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.Models.Domain;
using NAA.Data.Models.Repository;

namespace NAA.Data.IDAO
{
    public interface IUserDAO
    {
        IList<User> GetUsers(NAAContext context);
        User GetUser(string userId, NAAContext context);
        User GetUserByEmailAddress(string emailAddress, NAAContext context);
        void AddUser(User user, NAAContext context);
        void AddApplicationToCollection(NAAContext context, Application application);
        void RemoveUser(User user, NAAContext context);
        void UpdateUser(User user, NAAContext context);
        IList<Application> GetApplications(NAAContext context);
    }
}
