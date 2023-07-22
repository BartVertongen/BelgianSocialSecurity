//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;

namespace VertSoft.BelgianHR.Xml.DmfA.Original223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ComplIndemnityContribution", Namespace = "", IsNullable = false)]
    public class ComplIndemnityContributionType
    {
        [XmlElement(DataType = "integer")]
        public string? ContributionWorkerCode;

        [XmlElement(DataType = "integer")]
        public string? ContributionType;

        [XmlElement(DataType = "integer")]
        public string? IndemnityContributionPeriodCode;

        public ComplIndemnityAmountAdjustNotion ComplIndemnityAmountAdjustNotion;

        [XmlElement(DataType = "integer")]
        public string? ContributionSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? ComplIndemnityAmount;

        public CapitalizationNotion CapitalizationNotion;

        [XmlIgnore()]
        public bool CapitalizationNotionSpecified;

        [XmlElement(DataType = "integer")]
        public string? WelfareBenefitTheoreticalAmount;

        [XmlElement(DataType = "integer")]
        public string? ComplIndemnityNbrMonths;

        [XmlElement(DataType = "integer")]
        public string? NbrMonthsDecimals;

        [XmlElement(DataType = "integer")]
        public string? IncompleteMonthNbrDays;

        [XmlElement(DataType = "integer")]
        public string? IncompleteMonthReason;

        [XmlElement(DataType = "integer")]
        public string? FloorApplicationNotion;

        [XmlElement(DataType = "integer")]
        public string? ContributionAmount;
    }
}