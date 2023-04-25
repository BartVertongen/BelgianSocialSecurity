

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.IDFLUX.IDFLUX231
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	public class IdfluxInformationType
	{
		public JustificationCode JustificationCode;

		[XmlElement(DataType = "date")]
		public DateTime EffectiveStartingDate;
	}
}