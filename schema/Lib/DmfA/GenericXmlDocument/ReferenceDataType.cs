//By Bart Vertongen April 2023.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.GenericXmlDocument224
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
	public class ReferenceDataType
	{
		[XmlElement(DataType = "integer")]
		public string? INSS;

		[XmlElement("Quarter", DataType = "integer")]
		public string[]? Quarter;

		public string? GroupName;

		[XmlElement(DataType = "integer")]
		public string? FormSequenceNbr;

		public bool IsLastForm;

		[XmlIgnore()]
		public bool IsLastFormSpecified;
	}
}
