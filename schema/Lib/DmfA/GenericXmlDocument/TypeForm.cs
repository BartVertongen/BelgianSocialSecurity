//By Bart Vertongen April 2023.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.GenericXmlDocument224
{
	[Serializable()]
	[XmlType(AnonymousType = true, Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux")]
	[XmlRoot(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IsNullable = false)]
	public enum TypeForm { RE, PA, FA, LA, SU }
}