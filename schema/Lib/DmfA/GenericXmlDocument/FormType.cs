//By Bart Vertongen April 2023.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.GenericXmlDocument224
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
	public class FormType
	{
		public string? Identification;

		[XmlElement(DataType = "date")]
		public DateTime FormCreationDate;

		[XmlElement(DataType = "time")]
		public DateTime FormCreationHour;

		[XmlElement(DataType = "integer")]
		public string? AttestationStatus;

		public TypeForm TypeForm;
	}
}