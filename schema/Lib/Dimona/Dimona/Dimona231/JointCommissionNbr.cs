﻿//By Bart Vertongen April 2023.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;
using VertSoft.BelgianHR.Xml.Dimona.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona231
{
	[Serializable()]
	[XmlType(AnonymousType = true)]
	[XmlRoot(Namespace = "", IsNullable = false)]
	public enum JointCommissionNbr
	{
		[XmlEnum("124")] Item124,

		[XmlEnum("140")] Item140,

		[XmlEnum("144")] Item144,

		[XmlEnum("145")] Item145,

		[XmlEnum("149")] Item149,

		[XmlEnum("302")] Item302,

		[XmlEnum("320")] Item320,

		[XmlEnum("322")] Item322,

		XXX,
	}
}
