
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Original223
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum HalfTimeCareerInterruptionNotion
    {
        [XmlEnum("0")]
        Item0,

        [XmlEnum("1")]
        Item1,

        [XmlEnum("9")]
        Item9,
    }
}