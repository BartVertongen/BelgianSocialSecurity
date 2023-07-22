// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum AccountUpdateReportParticipation
    {
        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,
    }
}
