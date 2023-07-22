//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("StudentContributionAction", Namespace = "", IsNullable = false)]
    public class StudentContributionActionType
    {
        [XmlElement(DataType = "integer")]
        public string? StudentRemunAmount;

        [XmlElement(DataType = "integer")]
        public string? StudentContributionAmount;

        [XmlElement("StudentHoursNbr", typeof(string), DataType = "integer")]
        [XmlElement("StudentNbrDays", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType1 ItemElementName;

        [XmlElement(DataType = "integer")]
        public string? LocalUnitID;

        public Action Action;
    }
}
