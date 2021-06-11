using NAA.Data.Models.Domain;
using NAA.Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.IDAO
{
    public interface IApplicationDAO
    {
        void AddApplication(NAAContext context, Application application);

        void DeleteApplication(NAAContext context, Application application);

        Application GetApplication(NAAContext context, int applicationId);

        void ConfirmApplication(NAAContext context, int applicationId);
    }
}
