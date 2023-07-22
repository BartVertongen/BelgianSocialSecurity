//By Bart Vertongen April 2023.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.GenericXmlDocument224
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
	public class MandateCriteriaType
	{
		[XmlElement("Date", typeof(System.DateTime), DataType = "date")]
		[XmlElement("MandateType", typeof(MandateType))]
		[XmlElement("Quarter", typeof(string), DataType = "integer")]
		public object Item;
	}
}
