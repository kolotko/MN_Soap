using System.Xml.Serialization;

namespace MN_Soap.Models.ExampleResponse;

public class SoapBodyExampleResponse
{
    [XmlNamespaceDeclarations] 
    public XmlSerializerNamespaces Ns = new ();
    [XmlElement(Namespace = "http://example.com/namespace")]
    public MyResponse Operation { get; set; }
    
    public SoapBodyExampleResponse()
    {
        Ns.Add("ser",  "http://example.com/namespace");
    }
}