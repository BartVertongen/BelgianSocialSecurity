//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Common
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DismissedStatutoryWorkerContribution", Namespace = "", IsNullable = false)]
    public class DismissedStatutoryWorkerContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? GrossRefRemunAmount;

        [XmlElement(DataType = "integer")]
        public string? GrossRefRemunContributionAmount;

        [XmlElement(DataType = "integer")]
        public string? RefNbrDays;

        [XmlElement(DataType = "date")]
        public DateTime SubjectionStartingDate;

        [XmlElement(DataType = "date")]
        public DateTime SubjectionEndingDate;
    }
}