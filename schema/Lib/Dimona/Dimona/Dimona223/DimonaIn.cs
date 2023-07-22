//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Dimona.Common;


namespace Schemas.Lib.Dimona.Dimona.Dimona223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class DimonaIn : DimonaInType
    {
        public EmployerIdType? EmployerId;

        public NaturalPersonType? NaturalPerson;

        public DimonaFeatures? DimonaFeatures;

        public ConstructionControlCardsType? ConstructionControlCards;

        public StudentPlaceOfWork? StudentPlaceOfWork;

        public SmallStatutesInformationType? SmallStatutesInformation;
    }
}
