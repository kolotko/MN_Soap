using Microsoft.AspNetCore.Mvc;
using MN_Soap.Models.Soap12Error;

namespace MN_Soap.Controllers;

[ApiController]
[Route("[controller]")]
public class Error12Controller : ControllerBase
{
    [HttpPost]
    [Produces("application/xml")]
    public IActionResult Post()
    {
        var fault = new SoapFault
        {
            Code = new FaultCode
            {
                Value = "env:Receiver",
                Subcode = new FaultSubcode
                {
                    Value = "InvalidRequest"
                }
            },
            Reason = new FaultReason
            {
                Text = new FaultReasonText
                {
                    Lang = "en",
                    Value = "Example fault"
                }
            },
            Node = "http://localhost:5000/api/Soap",
            Detail = new FaultDetail
            {
                ErrorCode = "500",
                ErrorMessage = "Internal server error occurred."
            }
        };
        return StatusCode(StatusCodes.Status500InternalServerError, fault);
    }
}