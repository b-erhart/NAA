using NAA.Data.IDAO;
using NAA.Data.Models.Domain;
using NAA.Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.DAO
{
    public class ApplicationDAO : IApplicationDAO
    {
        public void AddApplication(NAAContext context, Application application)
        {
            context.Applications.Add(application);
        }

        public void DeleteApplication(NAAContext context, Application application)
        {
            Application delete = GetApplication(context, application.ApplicationId);
            context.Applications.Remove(delete);
        }

        public Application GetApplication(NAAContext context, int applicationId)
        {
            return context.Applications.Find(applicationId);
        }

        public void ConfirmApplication(NAAContext context, int applicationId)
        {
            Application old = GetApplication(context, applicationId);
            Application application = GetApplication(context, applicationId);
            application.Firm = true;
            context.Entry(old).CurrentValues.SetValues(application);
        }
        public void UpdateApplication(NAAContext context, Application application)
        {
            Application old = GetApplication(context, application.ApplicationId);
            context.Entry(old).CurrentValues.SetValues(application);
        }
    }
}
