using System.Xml.Serialization;

namespace MN_Soap.Models.Soap12Error;

public class FaultCode
{
    public string Value { get; set; }

    [XmlElement(IsNullable = true)]
    public FaultSubcode Subcode { get; set; }
}