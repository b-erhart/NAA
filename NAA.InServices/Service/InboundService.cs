using NAA.InServices.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.InServices.ProxyToSheffieldWebService;
using NAA.InServices.ProxyToSheffieldHallamWebService;

namespace NAA.InServices.Service
{
    public class InboundService : IInboundService
    {
        private SheffieldWebServiceSoapClient sheffield;
        private SHUWebServiceSoapClient sheffieldHallam;

        public InboundService()
        {
            sheffield = new SheffieldWebServiceSoapClient("SheffieldWebServiceSoap", "http://webteach_net.hallam.shu.ac.uk/cmsmr2/SheffieldWebService.asmx");
            sheffieldHallam = new SHUWebServiceSoapClient("SHUWebServiceSoap", "http://webteach_net.hallam.shu.ac.uk/cmsmr2/SHUWebService.asmx");
        }
        public IList<ShefCourse> GetSheffieldCourses()
        {
            return sheffield.SheffCourses();
        }

        public IList<SHUCourse> getSheffieldHallamCourses()
        {
            return sheffieldHallam.SheffCourses();
        }
    }
}
