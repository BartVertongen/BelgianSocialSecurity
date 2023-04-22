//By Bart Vertongen April 2023.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona231
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
		public ItemChoiceType1 ItemElementName;

		[XmlElement(DataType = "integer")]
		public string CompanyID;
	}
}