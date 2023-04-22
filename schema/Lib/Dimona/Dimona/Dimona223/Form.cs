//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Form : Xml.Dimona.Common.FormType
	{
        [XmlElement("Reference")]
        public ReferenceType[]? Reference;

        [XmlElement("DailyRegistrationDeclaration", typeof(DailyRegistrationDeclarationType))]
        [XmlElement("DimonaCancel", typeof(DimonaCancel))]
        [XmlElement("DimonaIn", typeof(DimonaIn))]
        [XmlElement("DimonaOut", typeof(DimonaOut))]
        [XmlElement("DimonaUpdate", typeof(DimonaUpdate))]
        public object? Item;
    }
}