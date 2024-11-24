using System.Xml.Serialization;
using MN_Soap.Models.Soap11Error;

namespace MN_Soap.Models.Soap12Error;

[XmlRoot("Fault", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
public class SoapFault
{
    public FaultCode Code { get; set; }
    public FaultReason Reason { get; set; }

    [XmlElement(IsNullable = true)]
    public string Node { get; set; }

    [XmlElement(IsNullable = true)]
    public string Role { get; set; }

    [XmlElement(IsNullable = true)]
    public FaultDetail Detail { get; set; }
}