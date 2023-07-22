
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Common
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum DaysJustification
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,

        [XmlEnum("3")] Item3,

        [XmlEnum("4")] Item4,

        [XmlEnum("5")] Item5,

        [XmlEnum("6")] Item6,

        [XmlEnum("7")] Item7,

        [XmlEnum("8")] Item8,
    }
}