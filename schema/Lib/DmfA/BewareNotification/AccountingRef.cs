// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum AccountingRef
    {
        [XmlEnum("121")] Item121,

        [XmlEnum("221")] Item221,

        [XmlEnum("128")] Item128,

        [XmlEnum("228")] Item228,

        [XmlEnum("132")] Item132,

        [XmlEnum("232")] Item232,

        [XmlEnum("316")] Item316,

        [XmlEnum("356")] Item356,
    }
}