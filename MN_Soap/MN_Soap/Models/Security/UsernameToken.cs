using System.Xml.Serialization;

namespace MN_Soap.Models.Security;

public class UsernameToken
{
    [XmlAttribute("Id")]
    public string Id { get; set; }
    
    public string Username { get; set; }
    public Password Password { get; set; }
    public string Nonce { get; set; }

    [XmlElement(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd")]
    public DateTime Created { get; set; }
}