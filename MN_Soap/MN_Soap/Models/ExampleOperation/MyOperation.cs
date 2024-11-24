using System.Xml.Serialization;

namespace MN_Soap.Models.ExampleOperation;

public class MyOperation
{
    [XmlElement(ElementName = "Parameter", Namespace = "http://example.com/namespace")]
    public string Parameter { get; set; }
}