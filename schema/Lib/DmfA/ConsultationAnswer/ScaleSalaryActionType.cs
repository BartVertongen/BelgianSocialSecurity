//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.ConsultationAnswer224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class ScaleSalaryActionType
    {
        [XmlElement(DataType = "date")]
        public DateTime ScaleSalaryStartDate;

        [XmlElement(DataType = "date")]
        public DateTime ScaleSalaryEndDate;

        [XmlIgnore()]
        public bool ScaleSalaryEndDateSpecified;

        [XmlElement(DataType = "gYearMonth")]
        public string? PecuniarySeniorityStartDate;

        [XmlElement(DataType = "integer")]
        public string? SalaryScaleReference;

        [XmlElement(DataType = "integer")]
        public string? ScaleSalaryAmount;

        [XmlElement(DataType = "integer")]
        public string? WeekHoursNbr;

        [XmlElement(DataType = "integer")]
        public string? ScaleSalaryWeekHoursNbr;

        public ReducedScaleSalaryNotion ReducedScaleSalaryNotion;

        [XmlIgnore()]
        public bool ReducedScaleSalaryNotionSpecified;

        public Action Action;
    }
}
