
using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona231
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	public class DimonaUpdateType
	{
		[XmlElement(DataType = "integer")]
		public string DimonaPeriodId;


		[XmlElement(DataType = "date")]
		public DateTime StartingDate;


		[XmlIgnore()]
		public bool StartingDateSpecified;


		[XmlElement(DataType = "integer")]
		public string StartingHour;


		[XmlElement(DataType = "date")] public DateTime EndingDate;


		[XmlIgnore()] public bool EndingDateSpecified;


		[XmlElement(DataType = "integer")]
		public string EndingHour;


		[XmlElement(DataType = "integer")]
		public string INSS;


		[XmlElement("PlannedDaysNbr", typeof(string), DataType = "integer")]
		[XmlElement("PlannedHoursNbr", typeof(string), DataType = "integer")]
		[XmlChoiceIdentifier("ItemElementName")]
		public string Item;

		[XmlIgnore()] public ItemChoiceType2 ItemElementName;
	}
}
