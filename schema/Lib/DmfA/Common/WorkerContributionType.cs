//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Common
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("WorkerContribution", Namespace = "", IsNullable = false)]
    public class WorkerContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? ContributionWorkerCode;

        [XmlElement(DataType = "integer")]
        public string? ContributionType;

        [XmlElement(DataType = "integer")]
        public string? ContributionCalculationBasis;

        [XmlElement(DataType = "integer")]
        public string? ContributionAmount;

        [XmlElement(DataType = "date")]
        public DateTime FirstHiringDate;

        [XmlIgnore()]
        public bool FirstHiringDateSpecified;
    }
}