//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace Schemas.Lib.Dimona.Dimona.Dimona223
{
    [Serializable()]
    [XmlType(IncludeInSchema = false)]
    public enum ItemChoiceType2 { PlannedDaysNbr, PlannedHoursNbr, }
}