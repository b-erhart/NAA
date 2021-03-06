using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.Models.Domain;
using NAA.Data.Models.Repository;

namespace NAA.Data.IDAO
{
    public interface IUniversityDAO
    {
        IList<University> GetUniversities(NAAContext context);
        University GetUniversity(NAAContext context, int id);
        IList<Application> GetApplications(NAAContext context, string universityName);
        void AddApplicationToCollection(NAAContext context, Application application, int universityKey);
        void RemoveFromCollection(NAAContext context, Application application);
    }
}
