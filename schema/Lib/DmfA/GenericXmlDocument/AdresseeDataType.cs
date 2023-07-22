//By Bart Vertongen April 2023.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.GenericXmlDocument224
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
	[XmlRoot("AddresseeData", Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
	public class AddresseeDataType
	{
		public string? Addressee;

		public string? AddresseeType;

		public string? AddresseeQuality;

		public string? Identification;
	}
}