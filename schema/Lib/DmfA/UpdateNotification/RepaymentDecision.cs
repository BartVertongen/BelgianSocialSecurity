﻿//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum RepaymentDecision
    {
        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,
    }
}
