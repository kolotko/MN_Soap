using Microsoft.AspNetCore.Mvc;
using MN_Soap.Models.ExampleOperation;
using MN_Soap.Models.Soap11Error;

namespace MN_Soap.Controllers;

[ApiController]
[Route("[controller]")]
public class Error11Controller : ControllerBase
{
    [HttpPost]
    [Produces("application/xml")]
    public IActionResult Post()
    {
        var fault = new SoapFault
        {
            FaultCode = "Server",
            FaultString = "Error details",
            FaultActor = "http://localhost:5000/api/Soap",
            Detail = new FaultDetail
            {
                ErrorCode = "500",
                ErrorMessage = "Internal server error occurred."
            }
        };
        return StatusCode(StatusCodes.Status500InternalServerError, fault);
    }
}