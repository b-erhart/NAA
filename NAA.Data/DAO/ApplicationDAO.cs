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
            context.Applications.Remove(application);
        }

        public Application GetApplication(NAAContext context, int applicationId)
        {
            return context.Applications.Find(applicationId);
        }
    }
}
