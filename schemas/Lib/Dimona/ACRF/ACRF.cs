﻿

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.ACRF223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class ACRF
    {
        [XmlElement("Form")]
        public Form[]? Form;
    }
}