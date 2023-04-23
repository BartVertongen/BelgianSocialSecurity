//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace Schemas.Lib.Dimona.PersonnelFileConsultationRequest.PersonnelFileConsultationRequest223
{
    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType { NOSSLPARegistrationNbr, NOSSRegistrationNbr, ProvisionalNSSONbr }
}
