

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.Dimona.IDFLUX.IDFLUX231
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(AnonymousType = true)]
	[XmlRoot(Namespace = "", IsNullable = false)]
	public class Form : FormType
	{
		public ReferenceType Reference;

		public IdfluxInformation IdfluxInformation;
	}
}