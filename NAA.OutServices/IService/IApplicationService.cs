using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.OutServices.Models;

namespace NAA.OutServices.IService
{
    public interface IApplicationService
    {
        UniversityApplication[] GetApplications(string universityName);
        string MakeOffer(string universityName, int applicationId, string offer);
    }
}
