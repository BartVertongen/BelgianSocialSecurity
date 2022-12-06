//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("SecondPillarInformationAction", Namespace = "", IsNullable = false)]
    public class SecondPillarInformationActionType
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

        public Action Action;
    }
}
