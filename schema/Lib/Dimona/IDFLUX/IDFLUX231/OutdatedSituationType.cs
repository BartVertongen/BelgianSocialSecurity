

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.IDFLUX.IDFLUX231
{
	[Serializable()]
	[System.Diagnostics.DebuggerStepThrough()]
	[System.ComponentModel.DesignerCategory("code")]
	[XmlRoot("OutdatedSituation", Namespace = "", IsNullable = false)]
	public class OutdatedSituationType
	{
		[XmlElement("INSS", typeof(string), DataType = "integer")]
		[XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
		[XmlElement("WorkerBirthdate", typeof(string))]
		[XmlElement("WorkerFirstName", typeof(string))]
		[XmlElement("WorkerName", typeof(string))]
		[XmlElement("WorkerSex", typeof(string), DataType = "integer")]
		[XmlChoiceIdentifier("ItemsElementName")]
		public string[] Items;

		[XmlElement("ItemsElementName")]
		[XmlIgnore()]
		public ItemsChoiceType1[] ItemsElementName;
	}
}