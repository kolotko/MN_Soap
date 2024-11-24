using System.Xml.Serialization;

namespace MN_Soap.Models.ExampleResponse;

[XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
public class SoapEnvelopeExampleResponse
{
    [XmlNamespaceDeclarations] 
    public XmlSerializerNamespaces Ns = new ();
    public SoapBodyExampleResponse Body { get; set; }

    public SoapEnvelopeExampleResponse()
    {
        Ns.Add("soap",  "http://www.w3.org/2003/05/soap-envelope");
    }
}