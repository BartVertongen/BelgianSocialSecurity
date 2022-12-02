// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.PersonnelFileConsultationAnswer223
{
    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType2
    { NOSSLPARegistrationNbr, NOSSRegistrationNbr, ProvisionalNSSONbr, }
}
