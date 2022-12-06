//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class EmployerDeclarationUpdateNotif : EmployerDeclarationUpdateNotifType
    {
        [XmlElement("SubGroupInformation")]
        public SubGroupInformationType[]? SubGroupInformation;

        [XmlElement("CUNPUpdateNotif", typeof(CUNPUpdateNotif))]
        [XmlElement("CompanyVehicleUpdateNotif", typeof(CompanyVehicleUpdateNotif))]
        [XmlElement("NaturalPersonUpdateNotif", typeof(NaturalPersonUpdateNotif))]
        public object[]? Items1;
    }
}
