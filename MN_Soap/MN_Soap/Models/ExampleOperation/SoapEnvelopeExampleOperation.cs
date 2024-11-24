using System.Xml.Serialization;

namespace MN_Soap.Models.ExampleOperation;

// [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
[XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
public class SoapEnvelopeExampleOperation
{
    public SoapHeaderExampleOperation Header { get; set; }
    public SoapBodyExampleOperation Body { get; set; }
}