// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.PID224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class IDEmployerDeclaration : IDEmployerDeclarationType
    {
        [XmlElement("IDNaturalPerson")]
        public IDNaturalPerson[]? IDNaturalPerson;

        [XmlElement("IDContUnrelatedToNP")]
        public IDContUnrelatedToNPType[]? IDContUnrelatedToNP;

        [XmlElement("CompanyVehicleID")]
        public CompanyVehicleIDType[]? CompanyVehicleID;
    }
}