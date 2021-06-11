using NAA.Data.Models.Domain;
using NAA.Data.Models.Repository;
using NAA.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.IDAO;
using NAA.Data.DAO;

namespace NAA.Services.Service
{
    public class ApplicationService : IApplicationService
    {
        private IApplicationDAO applicationDAO;
        private IUserDAO userDAO;
        private IUniversityDAO universityDAO;
        public ApplicationService()
        {
            applicationDAO = new ApplicationDAO();
            userDAO = new UserDAO();
            universityDAO = new UniversityDAO();
        }
        public void AddApplication(Application application, string userId, int universityId)
        {
            using (var context = new NAAContext())
            {
                applicationDAO.AddApplication(context, application);
                userDAO.AddApplicationToCollection(context, application, userId);
                universityDAO.AddApplicationToCollection(context, application, universityId);
                context.SaveChanges();
            }
        }

        public void DeleteApplication(Application application, string userId)
        {
            using (var context = new NAAContext())
            {
                userDAO.RemoveApplicationFromCollection(context,userId, application);
                universityDAO.RemoveFromCollection(context, application);
                applicationDAO.DeleteApplication(context, application);
                context.SaveChanges();
            }
        }

        public Application GetApplication(int applicationId)
        {
            using (var context = new NAAContext())
            {
                return applicationDAO.GetApplication(context, applicationId);
            }
        }

        public void ConfirmApplication(int applicationId)
        {
            using (var context = new NAAContext())
            {
                applicationDAO.ConfirmApplication(context, applicationId);
            }
        }
    }
}
