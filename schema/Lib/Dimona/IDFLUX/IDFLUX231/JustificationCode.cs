﻿
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.IDFLUX.IDFLUX231
{
	[Serializable()]
	[XmlType(AnonymousType = true)]
	[XmlRoot(Namespace = "", IsNullable = false)]
	public enum JustificationCode
	{
		[XmlEnum("90")] Item90,

		[XmlEnum("91")] Item91,

		[XmlEnum("92")] Item92,

		[XmlEnum("93")] Item93,
	}
}