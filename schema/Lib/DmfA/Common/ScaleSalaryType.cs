
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Common
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class ScaleSalaryType
    {
        [XmlElement(DataType = "date")]
        public DateTime ScaleSalaryStartDat;

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
    }
}