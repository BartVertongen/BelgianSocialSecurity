//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Common
{
    [Serializable()]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public enum EmploymentNature
    { EMPLOYEE, WORKER, }
}
