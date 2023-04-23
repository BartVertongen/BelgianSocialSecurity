//By Bart Vertongen April 2023.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona231
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	public class UsingEmployerType
	{
		public JointCommissionNbr JointCommissionNbr;
		[XmlIgnore()]
		public bool JointCommissionNbrSpecified;

		public string UsingEmployerName;

		[XmlElement(DataType = "integer")]
		public string UsingEmployerCompanyID;

		public string VATNbr;

		[XmlElement(DataType = "integer")]
		public string INSS;

		[XmlElement(DataType = "integer")]
		public string DailyContractNbr;
	}
}