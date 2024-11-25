using MN_WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MN_WebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class ExampleService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string test)
        {
            return "Hello World";
        }

        [WebMethod]
        public CalculateResponse Calculate(CalculateRequest req)
        {
            return new CalculateResponse()
            {
                Result = req.A + req.B
            };
        }
    }
}
