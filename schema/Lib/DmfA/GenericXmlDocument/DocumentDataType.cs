//By Bart Vertongen April 2023.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.GenericXmlDocument224
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
	public class DocumentDataType
	{
		[XmlElement(DataType = "date")]
		public DateTime DocumentDate;

		[XmlIgnore()]
		public bool DocumentDateSpecified;

		public string DocumentReference;

		[XmlElement(DataType = "integer")]
		public string INSS;

		[XmlElement(DataType = "integer")]
		public string CompanyID;
	}
}