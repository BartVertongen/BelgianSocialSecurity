using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.ACRF223
{ 
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum TypeForm { FA, PA, }
}
