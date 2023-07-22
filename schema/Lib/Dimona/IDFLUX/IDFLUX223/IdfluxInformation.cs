// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.IDFLUX.IDFLUX223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class IdfluxInformation : IdfluxInformationType
    {
        public EmployerIdType? EmployerId;

        public ValidSituationType? ValidSituation;

        public OutdatedSituationType? OutdatedSituation;
    }
}