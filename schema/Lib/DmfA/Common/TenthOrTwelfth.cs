
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Common
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum TenthOrTwelfth
    {
        [XmlEnum("10")]
        Item10,

        [XmlEnum("12")]
        Item12,

        [XmlEnum("20")]
        Item20,
    }
}
