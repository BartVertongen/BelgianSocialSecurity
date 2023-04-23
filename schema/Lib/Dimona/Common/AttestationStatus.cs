//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Common
{
    /// <summary>
    /// 00110
    /// </summary>
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum AttestationStatus
    {
        [XmlEnum("0")] Original,
        [XmlEnum("1")] Change,
        [XmlEnum("2")] Duplicate,
        [XmlEnum("3")] Cancelling,
        [XmlEnum("4")] Item4, //Herziening
        [XmlEnum("5")] Item5, //Herinnering
        [XmlEnum("6")] Item6, //Afsluiting
        [XmlEnum("7")] Item7, //Wijziging van papieren origineel
        [XmlEnum("8")] Copy,
    }
}