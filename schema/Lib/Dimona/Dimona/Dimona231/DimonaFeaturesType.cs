//By Bart Vertongen April 2023.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;
using VertSoft.BelgianHR.Xml.Dimona.Dimona.Common;


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