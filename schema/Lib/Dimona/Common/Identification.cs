

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Common
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum Identification { ACRF001, DIMONA, IDFLUX }
}