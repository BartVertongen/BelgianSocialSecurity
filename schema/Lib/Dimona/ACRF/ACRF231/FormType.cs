// By Bart Vertongen April 2023.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.Dimona.ACRF.ACRF231
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	public class FormType
	{
		public Identification Identification;

		[XmlElement(DataType = "date")]
		public DateTime FormCreationDate;

		[XmlElement(DataType = "time")]
		public DateTime FormCreationHour;

		public AttestationStatus AttestationStatus;

		public TypeForm TypeForm;
	}
}