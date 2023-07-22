//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("AdditionalScaleSalaryAction", Namespace = "", IsNullable = false)]
    public class AdditionalScaleSalaryActionType
    {
        [XmlElement(DataType = "date")]
        public DateTime AdditionalScaleSalaryStartDate;

        [XmlElement(DataType = "date")]
        public DateTime AdditionalScaleSalaryEndDate;

        [XmlIgnore()]
        public bool AdditionalScaleSalaryEndDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? AdditionalScaleSalaryReference;

        [XmlElement(DataType = "integer")]
        public string? AdditionalScaleSalaryBasisAmount;

        [XmlElement(DataType = "integer")]
        public string? AdditionalScaleSalaryPercentage;

        [XmlElement(DataType = "integer")]
        public string? NbrHoursOrServices;

        [XmlElement(DataType = "integer")]
        public string? AdditionalScaleSalaryAmount;

        public Action Action;
    }
}