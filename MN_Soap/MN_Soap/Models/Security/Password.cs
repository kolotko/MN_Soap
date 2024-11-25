using System.Xml.Serialization;

namespace MN_Soap.Models.Security;

public class Password
{
    [XmlText]
    public string Value { get; set; }
    
    [XmlAttribute("Type")]
    public string Type { get; set; }
}