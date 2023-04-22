﻿//By Bart Vertongen April 2023.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;
using VertSoft.BelgianHR.Xml.Dimona.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona231
{
	[SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlRoot("ConstructionControlCards", Namespace = "", IsNullable = false)]
	public class ConstructionControlCardsType
	{
		[XmlElement(DataType = "integer")]
		public string FirstMonthC32ANbr;

		[XmlElement(DataType = "integer")]
		public string NextMonthC32ANbr;
	}
}