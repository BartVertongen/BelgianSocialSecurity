// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Update223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class EmployerDeclarationUpdate : EmployerDeclarationUpdateType
    {
        [XmlElement("CompanyVehicleUpdateAction", typeof(CompanyVehicleUpdateActionType))]
        [XmlElement("ContributionUnrelatedToNPUpdate", typeof(ContributionUnrelatedToNPUpdate))]
        [XmlElement("NaturalPersonUpdate", typeof(NaturalPersonUpdate))]
        public object[]? Items;
    }
}