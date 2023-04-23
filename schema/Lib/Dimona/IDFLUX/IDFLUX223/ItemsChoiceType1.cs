// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.IDFLUX.IDFLUX223
{
    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {
        INSS,
        NOSSRegistrationNbr,
        WorkerBirthdate,
        WorkerFirstName,
        WorkerName,
        WorkerSex,
    }
}