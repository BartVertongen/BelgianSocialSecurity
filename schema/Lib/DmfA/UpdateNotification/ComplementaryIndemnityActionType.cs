//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class ComplementaryIndemnityActionType
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

        public string? HalfTimeCareerInterruptionNotion;

        public string? ServiceExemptionNotion;

        public string? ReplacementAccordanceWCCNotion;

        [XmlElement(DataType = "integer")]
        public string? SubstituteINSS;

        public string? ResumptionOfWorkMeasure;

        [XmlElement(DataType = "integer")]
        public string? ComplIndemnityNbrOfParts;

        [XmlElement(DataType = "date")]
        public DateTime NoticeDate;

        [XmlIgnore()]
        public bool NoticeDateSpecified;

        public AilingOrReorgCompanyNotion AilingOrReorgCompanyNotion;

        [XmlIgnore()]
        public bool AilingOrReorgCompanyNotionSpecified;

        [XmlElement(DataType = "date")]
        public DateTime AcknowledgementStartDate;

        [XmlIgnore()]
        public bool AcknowledgementStartDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime AcknowledgementEndDate;

        [XmlIgnore()]
        public bool AcknowledgementEndDateSpecified;

        public Action Action;
    }
}