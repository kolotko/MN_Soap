using Microsoft.AspNetCore.Mvc;
using MN_Soap.Models;
using MN_Soap.Models.ExampleOperation;
using MN_Soap.Models.ExampleResponse;

namespace MN_Soap.Controllers;

[ApiController]
[Route("[controller]")]
public class Service1Controller : ControllerBase
{
    private readonly ILogger<Service1Controller> _logger;
    public Service1Controller(ILogger<Service1Controller> logger)
    {
        _logger = logger;
    }
    
    [HttpPost]
    [Produces("application/xml")]
    public IActionResult Post(SoapEnvelopeExampleOperation req)
    {
        var response = new SoapEnvelopeExampleResponse()
        {
            Body = new SoapBodyExampleResponse()
            {
                Operation = new MyResponse()
                {
                    Test = new string[] { "value1", "value2" }
                }
            }
        };
        return Ok(response);
    }
}