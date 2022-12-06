//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("EarlyRetirementContAction", Namespace = "", IsNullable = false)]
    public class EarlyRetirementContActionType
    {
        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementCode;

        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementNbrMonths;

        [XmlElement(DataType = "integer")]
        public string? EarlyRetirementContributionAmount;

        public Action Action;
    }
}