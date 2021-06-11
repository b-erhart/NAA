using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.OutServices.IService;
using NAA.Data.Models.Domain;
using NAA.Data.Models.Repository;
using NAA.Data.IDAO;
using NAA.Data.DAO;

namespace NAA.OutServices.Service
{
    public class ApplicationService : IApplicationService
    {
        private IUniversityDAO universityDAO;
        public ApplicationService()
        {
            universityDAO = new UniversityDAO();
        }
        public Application[] GetApplications(string universityName)
        {
            using (var context = new NAAContext())
            {
                return universityDAO.GetApplications(context, universityName).ToArray();
            }
        }
    }
}
