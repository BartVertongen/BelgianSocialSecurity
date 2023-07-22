

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.IDFLUX.IDFLUX231
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlRoot("EmployerId", Namespace = "", IsNullable = false)]
	public class EmployerIdType
	{
		[XmlElement("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
		[XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
		[XmlElement("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
		[XmlChoiceIdentifier("ItemElementName")]
		public string Item;

		[XmlIgnore()]
		public ItemChoiceType ItemElementName;

		[XmlElement(DataType = "integer")]
		public string CompanyID;
	}
}