//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Common
{
    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType { StudentHoursNbr, StudentNbrDays, }
}