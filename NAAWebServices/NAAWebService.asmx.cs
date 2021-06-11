using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using NAA.OutServices.Models;
using NAA.OutServices.IService;
using NAA.OutServices.Service;

namespace NAAWebServices
{
    /// <summary>
    /// Summary description for NAAWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NAAWebService : System.Web.Services.WebService
    {
        private IApplicationService applicationService;
        public NAAWebService()
        {
            applicationService = new ApplicationService();
        }
        [WebMethod]
        public UniversityApplication[] GetApplications(string universityName)
        {
            return applicationService.GetApplications(universityName);
        }
        public string MakeOffer(string universityName, int applicationId, string offer, string statement, string teacherContact, string teacherReference)
        {
            return applicationService.MakeOffer(universityName, applicationId, offer, statement, teacherContact, teacherReference);
        }
    }
}
