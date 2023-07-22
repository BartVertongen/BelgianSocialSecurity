//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum NonSituableAbsenceCode
    {
        [XmlEnum("31")] Item31,

        [XmlEnum("32")] Item32,

        [XmlEnum("33")] Item33,

        [XmlEnum("41")] Item41,

        [XmlEnum("42")] Item42,

        [XmlEnum("43")] Item43,
    }
}