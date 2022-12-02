//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona223
{
    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType { PlannedDaysNbr, PlannedHoursNbr, }
}
