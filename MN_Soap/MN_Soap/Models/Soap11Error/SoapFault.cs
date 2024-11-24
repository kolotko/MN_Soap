using System.Xml.Serialization;

namespace MN_Soap.Models.Soap11Error;

[XmlRoot("Fault", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public class SoapFault
{
    [XmlElement("faultcode")]
    public string FaultCode { get; set; }

    [XmlElement("faultstring")]
    public string FaultString { get; set; }

    [XmlElement("faultactor", IsNullable = true)]
    public string FaultActor { get; set; }

    [XmlElement("detail", IsNullable = true)]
    public FaultDetail Detail { get; set; }
}