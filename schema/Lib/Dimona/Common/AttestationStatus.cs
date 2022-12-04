﻿//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Common
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum AttestationStatus
    {
        [XmlEnum("0")] Item0,

        [XmlEnum("1")] Item1,

        [XmlEnum("3")] Item3,
    }
}