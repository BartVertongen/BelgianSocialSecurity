// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.ConsultationRequest224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class EmployerDeclarationId : EmployerDeclarationIdType
    {
        [XmlElement("ContributionUnrelatedToNPId", typeof(ContributionUnrelatedToNPIdType))]
        [XmlElement("NaturalPerson", typeof(NaturalPersonType))]
        public object[]? Items1;
    }
}
