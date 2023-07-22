//By Bart Vertongen April 2023.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona231
{
	[Serializable()]
	[XmlType(AnonymousType = true)]
	[XmlRoot(Namespace = "", IsNullable = false)]
	public enum WorkerType
	{
		A17,
		ALT,
		BCW,
		DWD,
		EXT,
		FLX,
		IVT,
		O17,
		PMP,
		RTA,
		S17,
		STU,
		T17,
		TEA,
		TRI,
		STG,
		OTH,
	}
}