//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Common
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum NOSSLPASocialMaribel
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,

        [XmlEnum("3")] Item3,

        [XmlEnum("4")] Item4,

        [XmlEnum("5")] Item5,

        [XmlEnum("6")] Item6,

        [XmlEnum("7")] Item7,

        [XmlEnum("8")] Item8,

        [XmlEnum("9")] Item9,

        [XmlEnum("10")] Item10,

        [XmlEnum("11")] Item11,
    }
}