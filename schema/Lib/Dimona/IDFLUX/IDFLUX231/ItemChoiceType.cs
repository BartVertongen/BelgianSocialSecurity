

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.IDFLUX.IDFLUX231
{
	[Serializable()]
	[XmlType(IncludeInSchema = false)]
	public enum ItemChoiceType
	{
		NOSSLPARegistrationNbr,
		NOSSRegistrationNbr,
		ProvisionalNSSONbr,
	}
}