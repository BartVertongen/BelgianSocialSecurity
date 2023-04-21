//By Bart Vertongen April 2023.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.GenericXmlDocument224
{
	[Serializable()]
	[XmlType(Namespace = "http://www.smals-mvm.be/xml/ns/systemFlux", IncludeInSchema = false)]
	public enum ItemChoiceType1 { NOSSLPARegistrationNbr, NOSSRegistrationNbr, ProvisionalNSSONbr }
}