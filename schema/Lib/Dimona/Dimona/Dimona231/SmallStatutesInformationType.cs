//By Bart Vertongen April 2023.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona231
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlRoot("SmallStatutesInformation", Namespace = "", IsNullable = false)]
	public class SmallStatutesInformationType
	{
		public EmploymentNature EmploymentNature;

		[XmlElement(DataType = "integer")]
		public string ActivityWithRisk;

		public WorkerStatus WorkerStatus;
	}
}