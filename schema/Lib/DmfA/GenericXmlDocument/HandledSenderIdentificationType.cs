//By Bart Vertongen April 2023.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.GenericXmlDocument224
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
	public class HandledSenderIdentificationType
	{
		[XmlElement(DataType = "integer")]
		public string? CompanyID;

		[XmlElement(DataType = "integer")]
		public string? NOSSRegistrationNbr;

		[XmlElement(DataType = "integer")]
		public string? NOSSLPARegistrationNbr;

		[XmlElement(DataType = "integer")]
		public string? ProvisionalNSSONbr;

		[XmlElement(DataType = "integer")]
		public string? SocialSecretariatNumber;

		[XmlElement(DataType = "integer")]
		public string? INSS;
	}
}
