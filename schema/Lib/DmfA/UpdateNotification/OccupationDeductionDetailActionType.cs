//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("OccupationDeductionDetailAction", Namespace = "", IsNullable = false)]
    public class OccupationDeductionDetailActionType
    {
        [XmlElement(DataType = "integer")]
        public string? DeductionDetailSequenceNbr;

        [XmlElement(DataType = "date")]
        public DateTime WorkingRegulationsStartingDate;

        [XmlIgnore()]
        public bool WorkingRegulationsStartingDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime WorkingRegulationsEndingDate;

        [XmlIgnore()]
        public bool WorkingRegulationsEndingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? AverageWorkingTimeBeforeReduction;

        [XmlElement(DataType = "integer")]
        public string? AverageWorkingTimeAfterReduction;

        public Action Action;
    }
}
