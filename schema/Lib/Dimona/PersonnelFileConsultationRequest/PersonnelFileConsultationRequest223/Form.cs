//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;

namespace Schemas.Lib.Dimona.PersonnelFileConsultationRequest.PersonnelFileConsultationRequest223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Form : FormType
    {
        public ReferenceType? Reference;

        public EmployerIdType? EmployerId;

        public ReferencePeriodType? ReferencePeriod;

        public DataOptionType? DataOption;
    }
}
