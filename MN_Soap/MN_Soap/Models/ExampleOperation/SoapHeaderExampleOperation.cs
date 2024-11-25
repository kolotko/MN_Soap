using System.Xml.Serialization;

namespace MN_Soap.Models.ExampleOperation;

public class SoapHeaderExampleOperation
{
    [XmlElement("Security", Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
    public Security.Security Security { get; set; }
}