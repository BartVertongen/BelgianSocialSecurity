//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.PersonnelFileConsultationRequest223
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum ReferenceOrigin
    {
        [XmlEnum("1")]
        Item1,
    }
}
