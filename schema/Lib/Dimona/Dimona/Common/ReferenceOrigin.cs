//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Common
{
	/// <summary>
	/// Block:90082  Zone:00298  HERKOMST VAN DE REFERENTIE
	/// </summary>
	/// <remarks>
	/// For Dimona this is always 1.
	/// </remarks>
	[Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ReferenceOrigin
    {
        [XmlEnum("1")] Declarant_or_Requester,
		[XmlEnum("2")] TicketNumber,
		[XmlEnum("3")] SocialSecurity,
		[XmlEnum("4")] ePostService,
		[XmlEnum("5")] KSZ,
		[XmlEnum("6")] ArchiveSystem,
		[XmlEnum("7")] DspId
	}
}