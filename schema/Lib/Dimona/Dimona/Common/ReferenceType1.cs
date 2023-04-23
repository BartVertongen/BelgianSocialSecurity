//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Common
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot("ReferenceType", Namespace = "", IsNullable = false)]
    public enum ReferenceType1
    {
        [XmlEnum("1")] ReferenceToThisForm,

        [XmlEnum("6")] ReferenceToRefusedForm,

        [XmlEnum("7")] ReferenceToEmployer,

        [XmlEnum("8")] ReferenceToEmployee,
    }
}