using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.IDAO;
using NAA.Data.Models.Domain;
using NAA.Data.Models.Repository;

namespace NAA.Data.DAO
{
    public class UniversityDAO : IUniversityDAO
    {
        public IList<University> GetUniversities(NAAContext context)
        {
            //Include(a => a.Applications)
            return context.Universities.ToList();
        }

        public University GetUniversity(NAAContext context, int id)
        {
            return context.Universities.Find(id);
        }

        public void AddApplicationToCollection(NAAContext context, Application application, int universityKey)
        {
            context.Universities.Find(universityKey).Applications.Add(application);
        }

        public void RemoveFromCollection(NAAContext context, Application application)
        {
            IList<University> universities = GetUniversities(context);
            foreach (var item in universities)
            {
                if (context.Universities.Find(item.UniversityId).Applications.Contains(application))
                {
                    context.Universities.Find(item.UniversityId).Applications.Remove(application);
                    return;
                }
            }
        }
        public IList<Application> GetApplications(NAAContext context, string universityName)
        {
            IQueryable<University> university = from u
                                    in context.Universities
                                    where u.Name == universityName
                                    select u;

            if (university == null)
            {
                return new List<Application>();
            }
            return university.ToList().First().Applications.ToList();
        }
    }
}
