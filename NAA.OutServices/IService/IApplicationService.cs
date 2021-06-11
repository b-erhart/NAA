using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.Models.Domain;

namespace NAA.OutServices.IService
{
    public interface IApplicationService
    {
        Application[] GetApplications(string universityName);
    }
}
