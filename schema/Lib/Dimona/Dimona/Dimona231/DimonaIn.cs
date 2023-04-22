//By Bart Vertongen April 2023.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;
using VertSoft.BelgianHR.Xml.Dimona.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona231
{
	[SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true)]
	[XmlRoot(Namespace = "", IsNullable = false)]
	public class DimonaIn : DimonaInType
	{
		public EmployerIdType EmployerId;

		public NaturalPersonType NaturalPerson;

		public DimonaFeatures DimonaFeatures;

		public ConstructionControlCardsType ConstructionControlCards;

		public StudentPlaceOfWork StudentPlaceOfWork;

		public SmallStatutesInformationType SmallStatutesInformation;
	}
}