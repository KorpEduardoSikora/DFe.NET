using System.Xml.Serialization;

namespace CTe.Wsdl.Common
{
    [XmlRoot(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public abstract class CommonResponseBody
    {
    }
}