//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Original223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class EmployerDeclaration : EmployerDeclarationType
    {
        [XmlElement("CompanyVehicle", typeof(CompanyVehicleType))]
        [XmlElement("ContributionUnrelatedToNP", typeof(ContributionUnrelatedToNPType))]
        [XmlElement("NaturalPerson", typeof(NaturalPerson))]
        public object[]? Items;
    }
}