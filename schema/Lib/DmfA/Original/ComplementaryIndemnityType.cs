
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Original223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class ComplementaryIndemnityType
    {
        [XmlElement(DataType = "integer")]
        public string? EmployerNotion;

        public string? JointCommissionNbr;

        [XmlElement(DataType = "integer")]
        public string? ActivityCode;

        public DebtorType DebtorType;

        [XmlIgnore()]
        public bool DebtorTypeSpecified;

        [XmlElement(DataType = "date")]
        public DateTime FirstComplIndemnityDate;

        [XmlElement(DataType = "integer")]
        public string? ComplIndemnityAgreementNotion;

        public HalfTimeCareerInterruptionNotion HalfTimeCareerInterruptionNotion;

        public ServiceExemptionNotion ServiceExemptionNotion;

        public ReplacementAccordanceWCCNotion ReplacementAccordanceWCCNotion;

        [XmlElement(DataType = "integer")]
        public string? SubstituteINSS;

        public ResumptionOfWorkMeasure ResumptionOfWorkMeasure;

        [XmlIgnore()]
        public bool ResumptionOfWorkMeasureSpecified;

        [XmlElement(DataType = "integer")]
        public string? ComplIndemnityNbrOfParts;

        [XmlElement(DataType = "date")]
        public DateTime NoticeDate;

        [XmlIgnore()]
        public bool NoticeDateSpecified;

        public AilingOrReorgCompanyNotion AilingOrReorgCompanyNotion;

        [XmlIgnoreAttribute()]
        public bool AilingOrReorgCompanyNotionSpecified;

        [XmlElement(DataType = "date")]
        public DateTime AcknowledgementStartDate;

        [XmlIgnore()]
        public bool AcknowledgementStartDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime AcknowledgementEndDate;

        [XmlIgnore()]
        public bool AcknowledgementEndDateSpecified;
    }
}