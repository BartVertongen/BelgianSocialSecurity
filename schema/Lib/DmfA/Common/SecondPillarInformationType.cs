//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Common
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("SecondPillarInformation", Namespace = "", IsNullable = false)]
    public class SecondPillarInformationType
    {
        public string? ReferenceYearMonth;

        [XmlElement(DataType = "integer")]
        public string? MonthlyScaleSalary;

        [XmlElement(DataType = "integer")]
        public string? MonthlyAdditionalScaleSalary;

        [XmlElement(DataType = "integer")]
        public string? MonthlyHomeIndemnity;

        [XmlElement(DataType = "integer")]
        public string? OfficialLanguage;
    }
}