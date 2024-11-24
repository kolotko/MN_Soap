using System.Xml.Serialization;

namespace MN_Soap.Models.Soap11Error;

public class FaultDetail
{
    public string ErrorCode { get; set; }
    public string ErrorMessage { get; set; }
}