
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Common
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ReorganisationMeasure
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("2")] Item2,

        [XmlEnum("3")] Item3,

        [XmlEnum("4")] Item4,

        [XmlEnum("5")] Item5,

        [XmlEnum("6")] Item6,

        [XmlEnum("7")] Item7,

        [XmlEnum("8")] Item8,

        [XmlEnum("501")] Item501,

        [XmlEnum("502")] Item502,

        [XmlEnum("503")] Item503,

        [XmlEnum("504")]
        Item504,

        [XmlEnum("505")]
        Item505,

        [XmlEnum("506")]
        Item506,

        [XmlEnum("507")]
        Item507,

        [XmlEnum("508")]
        Item508,

        [XmlEnum("509")]
        Item509,

        [XmlEnum("510")]
        Item510,

        [XmlEnum("511")]
        Item511,

        [XmlEnum("512")]
        Item512,

        [XmlEnum("513")]
        Item513,

        [XmlEnum("514")]
        Item514,

        [System.Xml.Serialization.XmlEnum("515")]
        Item515,

        [System.Xml.Serialization.XmlEnum("516")]
        Item516,

        [System.Xml.Serialization.XmlEnum("517")]
        Item517,

        [System.Xml.Serialization.XmlEnum("531")]
        Item531,

        [System.Xml.Serialization.XmlEnum("541")]
        Item541,

        [System.Xml.Serialization.XmlEnum("542")]
        Item542,

        [XmlEnum("543")]
        Item543,

        [XmlEnum("544")]
        Item544,

        [XmlEnum("545")]
        Item545,

        [XmlEnum("546")]
        Item546,

        [XmlEnum("599")]
        Item599,
    }
}
