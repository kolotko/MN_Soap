using System.Xml.Serialization;

namespace MN_Soap.Models.ExampleOperation;

public class SoapBodyExampleOperation
{
    [XmlElement(Namespace = "http://example.com/namespace")]
    public MyOperation Operation { get; set; }
}