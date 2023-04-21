//By Bart Vertongen April 2023.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.GenericXmlDocument224
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
	public class EmployerIdType
	{
		[XmlElement("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
		[XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
		[XmlElement("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
		[XmlChoiceIdentifier("ItemElementName")]
		public string Item;

		[XmlIgnore()]
		public ItemChoiceType1 ItemElementName;

		[XmlElement(DataType = "integer")]
		public string CompanyID;
	}
}