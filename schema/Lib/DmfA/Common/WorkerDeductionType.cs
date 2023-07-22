
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Common
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class WorkerDeductionType
    {
        [XmlElement(DataType = "integer")]
        public string? DeductionCode;

        [XmlElement(DataType = "integer")]
        public string? DeductionCalculationBasis;

        [XmlElement(DataType = "integer")]
        public string? DeductionAmount;

        [XmlElement(DataType = "date")]
        public DateTime DeductionRightStartingDate;

        [XmlIgnore()]
        public bool DeductionRightStartingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? ManagementCostNbrMonths;

        [XmlElement(DataType = "integer")]
        public string? ReplacedINSS;

        [XmlElement(DataType = "integer")]
        public string? ApplicantINSS;

        [XmlElement(DataType = "integer")]
        public string? CertificateOrigin;
    }
}
