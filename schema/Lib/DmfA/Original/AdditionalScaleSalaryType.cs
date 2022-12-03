// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Original223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("AdditionalScaleSalary", Namespace = "", IsNullable = false)]
    public class AdditionalScaleSalaryType
    {
        [XmlElement(DataType = "date")]
        public DateTime AdditionalScaleSalaryStartDate;

        [XmlElement(DataType = "date")]
        public DateTime AdditionalScaleSalaryEndDate;

        [XmlIgnoreAttribute()]
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
    }
}