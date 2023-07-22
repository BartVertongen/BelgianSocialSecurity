//By Bart Vertongen April 2023.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona231
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	public class DimonaFeaturesType
	{
		public JointCommissionNbr JointCommissionNbr;

		[XmlIgnore()] public bool JointCommissionNbrSpecified;

		public WorkerType WorkerType;

		[XmlElement(DataType = "integer")]
		public string SubEntityNbr;
	}
}