using NAA.Data.Models.Domain;
using NAA.Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.IService
{
    public interface IApplicationService
    {
        void AddApplication(Application application, string userId, int universityId);

        void DeleteApplication(Application application, string userId);

        Application GetApplication(int applicationId);

        void ConfirmApplication(int applicationId);
    }
}
