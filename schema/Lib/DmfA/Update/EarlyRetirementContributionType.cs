// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Update223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("EarlyRetirementContribution", Namespace = "", IsNullable = false)]
    public class EarlyRetirementContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementCode;

        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementNbrMonths;

        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementContributionAmount;
    }
}
