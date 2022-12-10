// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.PID224
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot("ReferenceType", Namespace = "", IsNullable = false)]
    public enum ReferenceType1
    {
        [XmlEnum("1")] Item1,

        [XmlEnum("3")] Item3,
    }
}
