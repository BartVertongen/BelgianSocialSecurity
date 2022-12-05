// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Update223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class ComplementaryIndemnityType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string EmployerNotion;

        public string JointCommissionNbr;

        [XmlElementAttribute(DataType = "integer")]
        public string ActivityCode;

        public DebtorType DebtorType;

        [XmlIgnoreAttribute()]
        public bool DebtorTypeSpecified;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime FirstComplIndemnityDate;

        [XmlElementAttribute(DataType = "integer")]
        public string ComplIndemnityAgreementNotion;

        public HalfTimeCareerInterruptionNotion HalfTimeCareerInterruptionNotion;

        public ServiceExemptionNotion ServiceExemptionNotion;

        public ReplacementAccordanceWCCNotion ReplacementAccordanceWCCNotion;

        [XmlElementAttribute(DataType = "integer")]
        public string SubstituteINSS;

        public ResumptionOfWorkMeasure ResumptionOfWorkMeasure;

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResumptionOfWorkMeasureSpecified;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string ComplIndemnityNbrOfParts;

        [XmlElement(DataType = "date")]
        public System.DateTime NoticeDate;

        [XmlIgnoreAttribute()]
        public bool NoticeDateSpecified;

        public AilingOrReorgCompanyNotion AilingOrReorgCompanyNotion;

        [XmlIgnore()]
        public bool AilingOrReorgCompanyNotionSpecified;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime AcknowledgementStartDate;

        [XmlIgnoreAttribute()]
        public bool AcknowledgementStartDateSpecified;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime AcknowledgementEndDate;

        [XmlIgnoreAttribute()]
        public bool AcknowledgementEndDateSpecified;
    }
}
