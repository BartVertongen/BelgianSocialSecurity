//By Bart Vertongen April 2023.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;
using VertSoft.BelgianHR.Xml.Dimona.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona231
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(AnonymousType = true)]
	[XmlRoot(Namespace = "", IsNullable = false)]
	public class Form : FormType
	{
		[XmlElement("Reference")]
		public ReferenceType[] Reference;

		[XmlElementAttribute("DailyRegistrationDeclaration", typeof(DailyRegistrationDeclarationType))]
		[XmlElementAttribute("DimonaCancel", typeof(DimonaCancel))]
		[XmlElementAttribute("DimonaIn", typeof(DimonaIn))]
		[XmlElementAttribute("DimonaOut", typeof(DimonaOut))]
		[XmlElementAttribute("DimonaUpdate", typeof(DimonaUpdate))]
		public object Item;
	}
}