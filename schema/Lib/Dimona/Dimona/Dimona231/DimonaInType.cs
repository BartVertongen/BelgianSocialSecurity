//By Bart Vertongen April 2023.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona231
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	public class DimonaInType
	{
		[XmlElement(DataType = "date")]
		public DateTime StartingDate;

		[XmlElement(DataType = "integer")]
		public string StartingHour;

		[XmlElement(DataType = "date")]
		public DateTime EndingDate;

		[XmlIgnore()]
		public bool EndingDateSpecified;

		[XmlElement(DataType = "integer")]
		public string EndingHour;

		[XmlElement("PlannedDaysNbr", typeof(string), DataType = "integer")]
		[XmlElement("PlannedHoursNbr", typeof(string), DataType = "integer")]
		[XmlChoiceIdentifier("ItemElementName")]
		public string Item;


		[XmlIgnore()]
		public ItemChoiceType ItemElementName;
	}
}