// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Update223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("AdditionalScaleSalary", Namespace = "", IsNullable = false)]
    public class AdditionalScaleSalaryType
    {
        [XmlElementAttribute(DataType = "date")]
        public System.DateTime AdditionalScaleSalaryStartDate;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime AdditionalScaleSalaryEndDate;

        [XmlIgnoreAttribute()]
        public bool AdditionalScaleSalaryEndDateSpecified;

        [XmlElementAttribute(DataType = "integer")]
        public string? AdditionalScaleSalaryReference;

        [XmlElementAttribute(DataType = "integer")]
        public string? AdditionalScaleSalaryBasisAmount;

        [XmlElementAttribute(DataType = "integer")]
        public string? AdditionalScaleSalaryPercentage;

        [XmlElementAttribute(DataType = "integer")]
        public string? NbrHoursOrServices;

        [XmlElementAttribute(DataType = "integer")]
        public string? AdditionalScaleSalaryAmount;
    }
}