using System.Xml.Serialization;

namespace MN_Soap.Models.Soap12Error;

public class FaultReasonText
{
    [XmlAttribute("xml:lang")]
    public string Lang { get; set; }

    [XmlText]
    public string Value { get; set; }
}