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
    public class UniversityService : IUniversityService
    {
        private IUniversityDAO universityDAO;

        public UniversityService()
        {
            universityDAO = new UniversityDAO();
        }
        public IList<University> GetUniversities()
        {
            using (var context = new NAAContext())
            {
                return universityDAO.GetUniversities(context);
            }
        }

        public University GetUniversity(int id)
        {
            using (var context = new NAAContext())
            {
                return universityDAO.GetUniversity(context, id);
            }
        }
    }
}
